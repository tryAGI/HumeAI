#nullable enable

using System.Net;
using System.Net.Http.Headers;

namespace HumeAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task AccessTokenProvider_UsesClientCredentialsAndCachesToken()
    {
        var handler = new TokenResponseHandler(
            """{"access_token":"token-one","expires_in":1800}""");
        using var httpClient = new HttpClient(handler);
        using var provider = new HumeAccessTokenProvider(httpClient, disposeHttpClient: false);

        var first = await provider.GetAccessTokenAsync("api-key", "secret-key");
        var second = await provider.GetAccessTokenAsync("api-key", "secret-key");

        first.Should().Be("token-one");
        second.Should().Be("token-one");
        handler.RequestCount.Should().Be(1);
        handler.LastRequestUri.Should().Be(HumeAccessTokenProvider.DefaultTokenEndpoint);
        handler.LastAuthorization.Should().Be(
            new AuthenticationHeaderValue(
                "Basic",
                Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes("api-key:secret-key"))));
        handler.LastRequestBody.Should().Be("grant_type=client_credentials");
    }

    [TestMethod]
    public async Task AccessTokenProvider_RefreshesInsideSkew()
    {
        var timeProvider = new ManualTimeProvider(new DateTimeOffset(2026, 9, 2, 0, 0, 0, TimeSpan.Zero));
        var handler = new TokenResponseHandler(
            """{"access_token":"token-one","expires_in":180}""",
            """{"access_token":"token-two","expires_in":180}""");
        using var httpClient = new HttpClient(handler);
        using var provider = new HumeAccessTokenProvider(
            httpClient,
            timeProvider: timeProvider,
            disposeHttpClient: false);

        (await provider.GetAccessTokenAsync("api-key", "secret-key")).Should().Be("token-one");
        timeProvider.Advance(TimeSpan.FromSeconds(61));
        (await provider.GetAccessTokenAsync("api-key", "secret-key")).Should().Be("token-two");
        handler.RequestCount.Should().Be(2);
    }

    [TestMethod]
    public async Task AccessTokenProvider_ThrowsTypedExceptionWithoutCredentialsInMessage()
    {
        var handler = new TokenResponseHandler(HttpStatusCode.Unauthorized, """{"error":"invalid_client"}""");
        using var httpClient = new HttpClient(handler);
        using var provider = new HumeAccessTokenProvider(httpClient, disposeHttpClient: false);

        var exception = await Assert.ThrowsExactlyAsync<HumeAccessTokenException>(
            () => provider.GetAccessTokenAsync("api-key", "secret-key"));

        exception.StatusCode.Should().Be(HttpStatusCode.Unauthorized);
        exception.ResponseBody.Should().Be("""{"error":"invalid_client"}""");
        exception.Message.Should().NotContain("api-key").And.NotContain("secret-key");
    }

    private sealed class TokenResponseHandler : HttpMessageHandler
    {
        private readonly Queue<(HttpStatusCode StatusCode, string Body)> _responses;

        public TokenResponseHandler(params string[] responseBodies)
            : this(responseBodies.Select(static body => (HttpStatusCode.OK, body)).ToArray())
        {
        }

        public TokenResponseHandler(HttpStatusCode statusCode, string responseBody)
            : this([(statusCode, responseBody)])
        {
        }

        private TokenResponseHandler(params (HttpStatusCode StatusCode, string Body)[] responses)
        {
            _responses = new Queue<(HttpStatusCode StatusCode, string Body)>(responses);
        }

        public int RequestCount { get; private set; }
        public Uri? LastRequestUri { get; private set; }
        public AuthenticationHeaderValue? LastAuthorization { get; private set; }
        public string? LastRequestBody { get; private set; }

        protected override async Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            RequestCount++;
            LastRequestUri = request.RequestUri;
            LastAuthorization = request.Headers.Authorization;
            LastRequestBody = request.Content is null
                ? null
                : await request.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            var response = _responses.Dequeue();
            return new HttpResponseMessage(response.StatusCode)
            {
                Content = new StringContent(response.Body),
                RequestMessage = request,
            };
        }
    }

    private sealed class ManualTimeProvider(DateTimeOffset now) : TimeProvider
    {
        private DateTimeOffset _now = now;

        public override DateTimeOffset GetUtcNow() => _now;

        public void Advance(TimeSpan duration) => _now += duration;
    }
}
