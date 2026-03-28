
#nullable enable

namespace HumeAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostedConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_description")]
        public string? VersionDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evi_version")]
        public string? EviVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public global::HumeAI.PostedConfigPromptSpec? Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        public global::HumeAI.PostedUtteranceVoice? Voice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_model")]
        public global::HumeAI.PostedLanguageModel? LanguageModel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ellm_model")]
        public global::HumeAI.PostedEllmModel? EllmModel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::HumeAI.PostedUserDefinedToolSpec>? Tools { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("builtin_tools")]
        public global::System.Collections.Generic.IList<global::HumeAI.PostedBuiltinTool>? BuiltinTools { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_messages")]
        public global::HumeAI.PostedEventMessageSpecs? EventMessages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeouts")]
        public global::HumeAI.PostedTimeoutSpecs? Timeouts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostedConfig" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="versionDescription"></param>
        /// <param name="eviVersion"></param>
        /// <param name="prompt"></param>
        /// <param name="voice"></param>
        /// <param name="languageModel"></param>
        /// <param name="ellmModel"></param>
        /// <param name="tools"></param>
        /// <param name="builtinTools"></param>
        /// <param name="eventMessages"></param>
        /// <param name="timeouts"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostedConfig(
            string name,
            string? versionDescription,
            string? eviVersion,
            global::HumeAI.PostedConfigPromptSpec? prompt,
            global::HumeAI.PostedUtteranceVoice? voice,
            global::HumeAI.PostedLanguageModel? languageModel,
            global::HumeAI.PostedEllmModel? ellmModel,
            global::System.Collections.Generic.IList<global::HumeAI.PostedUserDefinedToolSpec>? tools,
            global::System.Collections.Generic.IList<global::HumeAI.PostedBuiltinTool>? builtinTools,
            global::HumeAI.PostedEventMessageSpecs? eventMessages,
            global::HumeAI.PostedTimeoutSpecs? timeouts)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.VersionDescription = versionDescription;
            this.EviVersion = eviVersion;
            this.Prompt = prompt;
            this.Voice = voice;
            this.LanguageModel = languageModel;
            this.EllmModel = ellmModel;
            this.Tools = tools;
            this.BuiltinTools = builtinTools;
            this.EventMessages = eventMessages;
            this.Timeouts = timeouts;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostedConfig" /> class.
        /// </summary>
        public PostedConfig()
        {
        }
    }
}