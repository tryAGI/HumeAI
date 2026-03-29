
#nullable enable

namespace HumeAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostedTts
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        public global::HumeAI.AudioFormat? Format { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_generations")]
        public int? NumGenerations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("utterances")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HumeAI.PostedUtterance> Utterances { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        public global::HumeAI.PostedContext? Context { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostedTts" /> class.
        /// </summary>
        /// <param name="utterances"></param>
        /// <param name="format"></param>
        /// <param name="numGenerations"></param>
        /// <param name="context"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostedTts(
            global::System.Collections.Generic.IList<global::HumeAI.PostedUtterance> utterances,
            global::HumeAI.AudioFormat? format,
            int? numGenerations,
            global::HumeAI.PostedContext? context)
        {
            this.Format = format;
            this.NumGenerations = numGenerations;
            this.Utterances = utterances ?? throw new global::System.ArgumentNullException(nameof(utterances));
            this.Context = context;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostedTts" /> class.
        /// </summary>
        public PostedTts()
        {
        }
    }
}