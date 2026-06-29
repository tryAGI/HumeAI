#nullable enable

namespace HumeAI;

/// <summary>
/// Hume AI-specific <see cref="Microsoft.Extensions.AI.TextToSpeechOptions.AdditionalProperties" /> keys.
/// </summary>
public static class HumeAITextToSpeechPropertyNames
{
    /// <summary>Octave version to request, such as <c>1</c> or <c>2</c>. Version 2 requires a voice.</summary>
    public const string Version = "hume:version";

    /// <summary>Voice name for Hume TTS requests.</summary>
    public const string VoiceName = "hume:voice_name";

    /// <summary>Voice provider, such as <c>HUME_AI</c> or <c>CUSTOM</c>.</summary>
    public const string VoiceProvider = "hume:voice_provider";

    /// <summary>Natural-language description of how the utterance should sound.</summary>
    public const string Description = "hume:description";

    /// <summary>Trailing silence after the utterance, in seconds.</summary>
    public const string TrailingSilence = "hume:trailing_silence";

    /// <summary>Enable Hume instant mode for lower latency.</summary>
    public const string InstantMode = "hume:instant_mode";

    /// <summary>Number of generations to request.</summary>
    public const string NumGenerations = "hume:num_generations";

    /// <summary>Output sample rate in Hz.</summary>
    public const string SampleRate = "hume:sample_rate";

    /// <summary>Output bit depth for PCM/WAV formats.</summary>
    public const string BitDepth = "hume:bit_depth";

    /// <summary>Optional <see cref="PostedContext" /> used to continue a prior TTS generation.</summary>
    public const string Context = "hume:context";

    /// <summary>Timestamp detail values to include when the API supports timestamped output.</summary>
    public const string IncludeTimestampTypes = "hume:include_timestamp_types";
}
