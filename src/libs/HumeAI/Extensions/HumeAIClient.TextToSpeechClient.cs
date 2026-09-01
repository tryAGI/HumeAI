#nullable enable
#pragma warning disable MEAI001

using System.Globalization;
using System.Runtime.CompilerServices;
using Microsoft.Extensions.AI;

namespace HumeAI;

public sealed partial class HumeAIClient : ITextToSpeechClient
{
    private const string DefaultTextToSpeechModel = "octave";
    private TextToSpeechClientMetadata? _textToSpeechMetadata;

    object? ITextToSpeechClient.GetService(Type serviceType, object? serviceKey)
    {
        ArgumentNullException.ThrowIfNull(serviceType);

        return serviceKey is not null ? null :
            serviceType == typeof(TextToSpeechClientMetadata) ? (_textToSpeechMetadata ??= new("hume-ai", new Uri(DefaultBaseUrl), DefaultTextToSpeechModel)) :
            serviceType.IsInstanceOfType(this) ? this :
            null;
    }

    async Task<TextToSpeechResponse> ITextToSpeechClient.GetAudioAsync(
        string text,
        TextToSpeechOptions? options,
        CancellationToken cancellationToken)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(text);

        var resolved = ResolveTextToSpeechOptions(options);
        var request = CreateTtsRequest(text, options, resolved);
        var response = await Tts.SynthesizeFileAsResponseAsync(
            request,
            cancellationToken: cancellationToken).ConfigureAwait(false);

        return new TextToSpeechResponse([
            new DataContent(response.Body, resolved.MediaType),
        ])
        {
            ModelId = resolved.ModelId,
            RawRepresentation = request,
            AdditionalProperties = CreateResponseProperties(request, resolved),
        };
    }

    async IAsyncEnumerable<TextToSpeechResponseUpdate> ITextToSpeechClient.GetStreamingAudioAsync(
        string text,
        TextToSpeechOptions? options,
        [EnumeratorCancellation] CancellationToken cancellationToken)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(text);

        var resolved = ResolveTextToSpeechOptions(options);
        var request = CreateTtsRequest(text, options, resolved);
        var responseId = Guid.NewGuid().ToString("N");

        yield return new TextToSpeechResponseUpdate
        {
            Kind = TextToSpeechResponseUpdateKind.SessionOpen,
            ResponseId = responseId,
            ModelId = resolved.ModelId,
            RawRepresentation = request,
            AdditionalProperties = CreateResponseProperties(request, resolved),
        };

        using var stream = await Tts.SynthesizeFileStreamingAsStreamAsync(
            request,
            cancellationToken: cancellationToken).ConfigureAwait(false);
        var buffer = new byte[16 * 1024];
        while (true)
        {
            var bytesRead = await stream.ReadAsync(buffer, cancellationToken).ConfigureAwait(false);
            if (bytesRead <= 0)
            {
                break;
            }

            yield return new TextToSpeechResponseUpdate([
                new DataContent(buffer.AsSpan(0, bytesRead).ToArray(), resolved.MediaType),
            ])
            {
                Kind = TextToSpeechResponseUpdateKind.AudioUpdating,
                ResponseId = responseId,
                ModelId = resolved.ModelId,
                AdditionalProperties = CreateResponseProperties(request, resolved),
            };
        }

        yield return new TextToSpeechResponseUpdate
        {
            Kind = TextToSpeechResponseUpdateKind.AudioUpdated,
            ResponseId = responseId,
            ModelId = resolved.ModelId,
            AdditionalProperties = CreateResponseProperties(request, resolved),
        };

        yield return new TextToSpeechResponseUpdate
        {
            Kind = TextToSpeechResponseUpdateKind.SessionClose,
            ResponseId = responseId,
            ModelId = resolved.ModelId,
        };
    }

    private PostedTts CreateTtsRequest(
        string text,
        TextToSpeechOptions? options,
        ResolvedHumeAITextToSpeechOptions resolved)
    {
        var request = options?.RawRepresentationFactory?.Invoke(this) as PostedTts
            ?? new PostedTts
            {
                Utterances =
                [
                    new PostedUtterance
                    {
                        Text = text,
                    },
                ],
            };

        if (request.Utterances is not { Count: > 0 })
        {
            request.Utterances =
            [
                new PostedUtterance
                {
                    Text = text,
                },
            ];
        }

        var utterance = request.Utterances[0];
        if (string.IsNullOrWhiteSpace(utterance.Text))
        {
            utterance.Text = text;
        }

        request.Format ??= new AudioFormat();
        request.Format.Type ??= resolved.FormatType;
        request.Format.SampleRate ??= options.GetInt(HumeAITextToSpeechPropertyNames.SampleRate);
        request.Format.BitDepth ??= options.GetInt(HumeAITextToSpeechPropertyNames.BitDepth);
        request.NumGenerations ??= options.GetInt(HumeAITextToSpeechPropertyNames.NumGenerations);
        request.Context ??= options.GetObject<PostedContext>(HumeAITextToSpeechPropertyNames.Context);

        if (resolved.Version is { Length: > 0 } version)
        {
            request.Version ??= version;
        }

        if (options.GetStringList(HumeAITextToSpeechPropertyNames.IncludeTimestampTypes) is { Count: > 0 } includeTimestampTypes)
        {
            request.AdditionalProperties.TryAdd("include_timestamp_types", includeTimestampTypes.ToArray());
        }

        utterance.Description ??= options.GetString(HumeAITextToSpeechPropertyNames.Description);
        utterance.Speed ??= options?.Speed;
        utterance.TrailingSilence ??= options.GetDouble(HumeAITextToSpeechPropertyNames.TrailingSilence);
        utterance.InstantMode ??= options.GetBool(HumeAITextToSpeechPropertyNames.InstantMode);
        ApplyVoiceOptions(utterance, options);

        return request;
    }

    private static void ApplyVoiceOptions(PostedUtterance utterance, TextToSpeechOptions? options)
    {
        var voiceId = options?.VoiceId;
        var voiceName = options.GetString(HumeAITextToSpeechPropertyNames.VoiceName);
        var voiceProvider = ResolveVoiceProvider(options.GetString(HumeAITextToSpeechPropertyNames.VoiceProvider));

        if (utterance.Voice is null && voiceId is not { Length: > 0 } && voiceName is not { Length: > 0 } && voiceProvider is null)
        {
            return;
        }

        utterance.Voice ??= new PostedUtteranceVoice();
        if (string.IsNullOrWhiteSpace(utterance.Voice.Id) && voiceId is { Length: > 0 })
        {
            utterance.Voice.Id = voiceId;
        }

        if (string.IsNullOrWhiteSpace(utterance.Voice.Name) && voiceName is { Length: > 0 })
        {
            utterance.Voice.Name = voiceName;
        }

        utterance.Voice.Provider ??= voiceProvider;
    }

    private static ResolvedHumeAITextToSpeechOptions ResolveTextToSpeechOptions(TextToSpeechOptions? options)
    {
        var (version, modelId) = ResolveModel(
            options?.ModelId,
            options.GetString(HumeAITextToSpeechPropertyNames.Version));
        var (formatType, mediaType) = ResolveAudioFormat(options?.AudioFormat);

        return new ResolvedHumeAITextToSpeechOptions(
            modelId,
            version,
            formatType,
            mediaType);
    }

    private static (string? Version, string ModelId) ResolveModel(string? modelId, string? explicitVersion)
    {
        if (explicitVersion is { Length: > 0 })
        {
            var normalizedVersion = NormalizeVersion(explicitVersion);
            return (normalizedVersion, CreateModelId(normalizedVersion));
        }

        if (modelId is not { Length: > 0 }
            || string.Equals(modelId, DefaultTextToSpeechModel, StringComparison.OrdinalIgnoreCase)
            || string.Equals(modelId, "octave-latest", StringComparison.OrdinalIgnoreCase))
        {
            return (null, DefaultTextToSpeechModel);
        }

        var version = NormalizeVersion(modelId);
        return (version, CreateModelId(version));
    }

    private static string NormalizeVersion(string value)
    {
        var normalized = value.Trim();
        if (normalized.StartsWith("octave-", StringComparison.OrdinalIgnoreCase))
        {
            normalized = normalized["octave-".Length..];
        }

        if (normalized.StartsWith('v'))
        {
            normalized = normalized[1..];
        }

        return normalized;
    }

    private static string CreateModelId(string version)
    {
        return string.Equals(version, "1", StringComparison.OrdinalIgnoreCase)
            ? "octave-1"
            : $"octave-{version}";
    }

    private static (AudioFormatType FormatType, string MediaType) ResolveAudioFormat(string? format)
    {
        if (format is not { Length: > 0 })
        {
            return (AudioFormatType.Mp3, "audio/mpeg");
        }

        if (string.Equals(format, "audio/mpeg", StringComparison.OrdinalIgnoreCase)
            || string.Equals(format, "audio/mp3", StringComparison.OrdinalIgnoreCase)
            || string.Equals(format, "mp3", StringComparison.OrdinalIgnoreCase))
        {
            return (AudioFormatType.Mp3, "audio/mpeg");
        }

        if (string.Equals(format, "audio/wav", StringComparison.OrdinalIgnoreCase)
            || string.Equals(format, "audio/wave", StringComparison.OrdinalIgnoreCase)
            || string.Equals(format, "wav", StringComparison.OrdinalIgnoreCase))
        {
            return (AudioFormatType.Wav, "audio/wav");
        }

        if (string.Equals(format, "audio/pcm", StringComparison.OrdinalIgnoreCase)
            || string.Equals(format, "pcm", StringComparison.OrdinalIgnoreCase)
            || string.Equals(format, "pcm_s16le", StringComparison.OrdinalIgnoreCase))
        {
            return (AudioFormatType.Pcm, "audio/pcm;codec=s16le");
        }

        throw new NotSupportedException($"Unsupported Hume AI TTS audio format '{format}'. Use 'mp3', 'wav', or 'pcm'.");
    }

    private static PostedUtteranceVoiceProvider? ResolveVoiceProvider(string? provider)
    {
        if (provider is not { Length: > 0 })
        {
            return null;
        }

        return PostedUtteranceVoiceProviderExtensions.ToEnum(provider)
            ?? PostedUtteranceVoiceProviderExtensions.ToEnum(provider.ToUpperInvariant().Replace('-', '_'))
            ?? (string.Equals(provider, "hume", StringComparison.OrdinalIgnoreCase)
                || string.Equals(provider, "hume_ai", StringComparison.OrdinalIgnoreCase)
                    ? PostedUtteranceVoiceProvider.HumeAi
                    : null);
    }

    private static AdditionalPropertiesDictionary CreateResponseProperties(
        PostedTts request,
        ResolvedHumeAITextToSpeechOptions resolved)
    {
        AdditionalPropertiesDictionary properties = new()
        {
            ["model_id"] = resolved.ModelId,
            ["media_type"] = resolved.MediaType,
            ["format"] = resolved.FormatType.ToValueString(),
        };

        if (resolved.Version is { Length: > 0 })
        {
            properties["version"] = resolved.Version;
        }

        if (request.Utterances is { Count: > 0 } && request.Utterances[0].Voice is { } voice)
        {
            if (voice.Id is { Length: > 0 })
            {
                properties["voice_id"] = voice.Id;
            }

            if (voice.Name is { Length: > 0 })
            {
                properties["voice_name"] = voice.Name;
            }
        }

        return properties;
    }

    private sealed record ResolvedHumeAITextToSpeechOptions(
        string ModelId,
        string? Version,
        AudioFormatType FormatType,
        string MediaType);
}

internal static class HumeAITextToSpeechOptionsExtensions
{
    public static bool? GetBool(this TextToSpeechOptions? options, string key)
    {
        if (options?.AdditionalProperties is not { } properties || !properties.TryGetValue(key, out var value))
        {
            return null;
        }

        return value switch
        {
            bool boolValue => boolValue,
            string text when bool.TryParse(text, out var parsed) => parsed,
            _ => null,
        };
    }

    public static double? GetDouble(this TextToSpeechOptions? options, string key)
    {
        if (options?.AdditionalProperties is not { } properties || !properties.TryGetValue(key, out var value))
        {
            return null;
        }

        return value switch
        {
            double doubleValue => doubleValue,
            float floatValue => floatValue,
            int intValue => intValue,
            long longValue => longValue,
            string text when double.TryParse(text, NumberStyles.Float, CultureInfo.InvariantCulture, out var parsed) => parsed,
            _ => null,
        };
    }

    public static int? GetInt(this TextToSpeechOptions? options, string key)
    {
        if (options?.AdditionalProperties is not { } properties || !properties.TryGetValue(key, out var value))
        {
            return null;
        }

        return value switch
        {
            int intValue => intValue,
            long longValue when longValue is >= int.MinValue and <= int.MaxValue => (int)longValue,
            string text when int.TryParse(text, NumberStyles.Integer, CultureInfo.InvariantCulture, out var parsed) => parsed,
            _ => null,
        };
    }

    public static T? GetObject<T>(this TextToSpeechOptions? options, string key)
        where T : class
    {
        return options?.AdditionalProperties is { } properties
            && properties.TryGetValue(key, out var value)
                ? value as T
                : null;
    }

    public static string? GetString(this TextToSpeechOptions? options, string key)
    {
        return options?.AdditionalProperties is { } properties
            && properties.TryGetValue(key, out var value)
            && value is string text
            && text.Length > 0
                ? text
                : null;
    }

    public static IReadOnlyList<string>? GetStringList(this TextToSpeechOptions? options, string key)
    {
        if (options?.AdditionalProperties is not { } properties || !properties.TryGetValue(key, out var value))
        {
            return null;
        }

        return value switch
        {
            string text when text.Length > 0 => [text],
            IEnumerable<string> values => values.Where(static text => text.Length > 0).ToArray(),
            _ => null,
        };
    }
}
