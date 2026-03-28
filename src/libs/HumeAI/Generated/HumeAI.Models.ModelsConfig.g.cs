
#nullable enable

namespace HumeAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelsConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("face")]
        public global::HumeAI.FaceModelConfig? Face { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prosody")]
        public global::HumeAI.ProsodyModelConfig? Prosody { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public global::HumeAI.LanguageModelConfig? Language { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("burst")]
        public object? Burst { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ner")]
        public global::HumeAI.NerModelConfig? Ner { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsConfig" /> class.
        /// </summary>
        /// <param name="face"></param>
        /// <param name="prosody"></param>
        /// <param name="language"></param>
        /// <param name="burst"></param>
        /// <param name="ner"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelsConfig(
            global::HumeAI.FaceModelConfig? face,
            global::HumeAI.ProsodyModelConfig? prosody,
            global::HumeAI.LanguageModelConfig? language,
            object? burst,
            global::HumeAI.NerModelConfig? ner)
        {
            this.Face = face;
            this.Prosody = prosody;
            this.Language = language;
            this.Burst = burst;
            this.Ner = ner;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsConfig" /> class.
        /// </summary>
        public ModelsConfig()
        {
        }
    }
}