
#nullable enable

namespace HumeAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BurstPrediction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time")]
        public global::HumeAI.TimeInterval? Time { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emotions")]
        public global::System.Collections.Generic.IList<global::HumeAI.EmotionScore>? Emotions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BurstPrediction" /> class.
        /// </summary>
        /// <param name="time"></param>
        /// <param name="emotions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BurstPrediction(
            global::HumeAI.TimeInterval? time,
            global::System.Collections.Generic.IList<global::HumeAI.EmotionScore>? emotions)
        {
            this.Time = time;
            this.Emotions = emotions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BurstPrediction" /> class.
        /// </summary>
        public BurstPrediction()
        {
        }
    }
}