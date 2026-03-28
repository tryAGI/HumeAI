
#nullable enable

namespace HumeAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelsPredictions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("face")]
        public global::HumeAI.FaceModelPredictions? Face { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prosody")]
        public global::HumeAI.ProsodyModelPredictions? Prosody { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public global::HumeAI.LanguageModelPredictions? Language { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("burst")]
        public global::HumeAI.BurstModelPredictions? Burst { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ner")]
        public global::HumeAI.NerModelPredictions? Ner { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsPredictions" /> class.
        /// </summary>
        /// <param name="face"></param>
        /// <param name="prosody"></param>
        /// <param name="language"></param>
        /// <param name="burst"></param>
        /// <param name="ner"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelsPredictions(
            global::HumeAI.FaceModelPredictions? face,
            global::HumeAI.ProsodyModelPredictions? prosody,
            global::HumeAI.LanguageModelPredictions? language,
            global::HumeAI.BurstModelPredictions? burst,
            global::HumeAI.NerModelPredictions? ner)
        {
            this.Face = face;
            this.Prosody = prosody;
            this.Language = language;
            this.Burst = burst;
            this.Ner = ner;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsPredictions" /> class.
        /// </summary>
        public ModelsPredictions()
        {
        }
    }
}