
#nullable enable

namespace HumeAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InferenceRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        public global::HumeAI.ModelsConfig? Models { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcription")]
        public global::HumeAI.TranscriptionConfig? Transcription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("urls")]
        public global::System.Collections.Generic.IList<string>? Urls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public global::System.Collections.Generic.IList<string>? Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        public global::System.Collections.Generic.IList<global::HumeAI.SourceFile>? Files { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InferenceRequest" /> class.
        /// </summary>
        /// <param name="models"></param>
        /// <param name="transcription"></param>
        /// <param name="urls"></param>
        /// <param name="text"></param>
        /// <param name="files"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InferenceRequest(
            global::HumeAI.ModelsConfig? models,
            global::HumeAI.TranscriptionConfig? transcription,
            global::System.Collections.Generic.IList<string>? urls,
            global::System.Collections.Generic.IList<string>? text,
            global::System.Collections.Generic.IList<global::HumeAI.SourceFile>? files)
        {
            this.Models = models;
            this.Transcription = transcription;
            this.Urls = urls;
            this.Text = text;
            this.Files = files;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InferenceRequest" /> class.
        /// </summary>
        public InferenceRequest()
        {
        }
    }
}