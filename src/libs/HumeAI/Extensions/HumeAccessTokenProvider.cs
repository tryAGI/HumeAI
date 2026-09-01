#nullable enable

using System.Collections.Concurrent;
using System.Net;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

namespace HumeAI;

public sealed partial class HumeAIClient
{
    /// <summary>Creates a client authenticated with a temporary Hume access token.</summary>
    public static HumeAIClient CreateWithAccessToken(
        string accessToken,
        HttpClient? httpClient = null,
        Uri? baseUri = null,
        bool disposeHttpClient = true)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(accessToken);

        var client = new HumeAIClient(httpClient, baseUri, authorizations: null, disposeHttpClient);
        client.AuthorizeUsingBearer(accessToken);
        return client;
    }
}

/// <summary>
/// Mints and caches temporary Hume access tokens using the OAuth 2.0 client-credentials flow.
/// Use <see cref="HumeAIClient" /> with an API key for server-side calls; access tokens are
/// intended for clients that must not receive the API key or secret key.
/// </summary>
public sealed class HumeAccessTokenProvider : IDisposable
{
    public static readonly Uri DefaultTokenEndpoint = new("https://api.hume.ai/oauth2-cc/token");
    public static readonly TimeSpan DefaultRefreshSkew = TimeSpan.FromMinutes(2);

    private readonly HttpClient _httpClient;
    private readonly bool _disposeHttpClient;
    private readonly Uri _tokenEndpoint;
    private readonly TimeProvider _timeProvider;
    private readonly TimeSpan _refreshSkew;
    private readonly ConcurrentDictionary<string, TokenCacheEntry> _tokens = new(StringComparer.Ordinal);
    private readonly ConcurrentDictionary<string, SemaphoreSlim> _credentialLocks = new(StringComparer.Ordinal);

    public HumeAccessTokenProvider(
        HttpClient? httpClient = null,
        Uri? tokenEndpoint = null,
        TimeProvider? timeProvider = null,
        TimeSpan? refreshSkew = null,
        bool disposeHttpClient = true)
    {
        _httpClient = httpClient ?? new HttpClient();
        _disposeHttpClient = httpClient is null || disposeHttpClient;
        _tokenEndpoint = tokenEndpoint ?? DefaultTokenEndpoint;
        _timeProvider = timeProvider ?? TimeProvider.System;
        _refreshSkew = refreshSkew ?? DefaultRefreshSkew;

        if (_refreshSkew < TimeSpan.Zero)
        {
            throw new ArgumentOutOfRangeException(nameof(refreshSkew), "Refresh skew cannot be negative.");
        }
    }

    /// <summary>
    /// Returns a cached access token when it remains valid beyond the refresh skew; otherwise
    /// performs one client-credentials exchange per credential pair.
    /// </summary>
    public async Task<string> GetAccessTokenAsync(
        string apiKey,
        string secretKey,
        CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(apiKey);
        ArgumentException.ThrowIfNullOrWhiteSpace(secretKey);

        var cacheKey = CreateCacheKey(apiKey, secretKey);
        if (TryGetCachedToken(cacheKey, out var accessToken))
        {
            return accessToken;
        }

        var credentialLock = _credentialLocks.GetOrAdd(cacheKey, static _ => new SemaphoreSlim(1, 1));
        await credentialLock.WaitAsync(cancellationToken).ConfigureAwait(false);
        try
        {
            if (TryGetCachedToken(cacheKey, out accessToken))
            {
                return accessToken;
            }

            var token = await FetchAccessTokenAsync(apiKey, secretKey, cancellationToken).ConfigureAwait(false);
            _tokens[cacheKey] = token;
            return token.AccessToken;
        }
        finally
        {
            credentialLock.Release();
        }
    }

    private bool TryGetCachedToken(string cacheKey, out string accessToken)
    {
        if (_tokens.TryGetValue(cacheKey, out var cached) &&
            cached.ExpiresAt > _timeProvider.GetUtcNow() + _refreshSkew)
        {
            accessToken = cached.AccessToken;
            return true;
        }

        accessToken = string.Empty;
        return false;
    }

    private async Task<TokenCacheEntry> FetchAccessTokenAsync(
        string apiKey,
        string secretKey,
        CancellationToken cancellationToken)
    {
        using var request = new HttpRequestMessage(HttpMethod.Post, _tokenEndpoint);
        var credentials = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{apiKey}:{secretKey}"));
        request.Headers.Authorization = new AuthenticationHeaderValue("Basic", credentials);
        request.Content = new FormUrlEncodedContent(
        [
            new KeyValuePair<string, string>("grant_type", "client_credentials"),
        ]);

        using var response = await _httpClient
            .SendAsync(request, HttpCompletionOption.ResponseContentRead, cancellationToken)
            .ConfigureAwait(false);
        var responseBody = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
        if (!response.IsSuccessStatusCode)
        {
            throw new HumeAccessTokenException(response.StatusCode, responseBody);
        }

        try
        {
            using var document = JsonDocument.Parse(responseBody);
            if (!document.RootElement.TryGetProperty("access_token", out var accessTokenElement) ||
                accessTokenElement.ValueKind != JsonValueKind.String ||
                string.IsNullOrWhiteSpace(accessTokenElement.GetString()))
            {
                throw new HumeAccessTokenException(
                    response.StatusCode,
                    responseBody,
                    "Hume access-token response did not include access_token.");
            }

            var expiresInSeconds = document.RootElement.TryGetProperty("expires_in", out var expiresInElement) &&
                                   expiresInElement.TryGetInt32(out var parsedExpiresIn)
                ? parsedExpiresIn
                : 1_800;
            var expiresAt = _timeProvider.GetUtcNow().AddSeconds(Math.Max(60, expiresInSeconds));
            return new TokenCacheEntry(accessTokenElement.GetString()!.Trim(), expiresAt);
        }
        catch (JsonException ex)
        {
            throw new HumeAccessTokenException(
                response.StatusCode,
                responseBody,
                "Hume access-token response was not valid JSON.",
                ex);
        }
    }

    private static string CreateCacheKey(string apiKey, string secretKey) =>
        Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes($"{apiKey}:{secretKey}")));

    public void Dispose()
    {
        if (_disposeHttpClient)
        {
            _httpClient.Dispose();
        }
    }

    private sealed record TokenCacheEntry(string AccessToken, DateTimeOffset ExpiresAt);
}

/// <summary>Failure returned by Hume's client-credentials token endpoint.</summary>
public sealed class HumeAccessTokenException : HttpRequestException
{
    public HumeAccessTokenException()
    {
    }

    public HumeAccessTokenException(string message)
        : base(message)
    {
    }

    public HumeAccessTokenException(string message, Exception innerException)
        : base(message, innerException)
    {
    }

    public HumeAccessTokenException(
        HttpStatusCode statusCode,
        string? responseBody,
        string? message = null,
        Exception? innerException = null)
        : base(message ?? $"Hume access-token request failed with HTTP {(int)statusCode}.", innerException, statusCode)
    {
        ResponseBody = responseBody;
    }

    public string? ResponseBody { get; }
}
