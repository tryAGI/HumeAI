
#nullable enable

namespace HumeAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FaceModelPredictions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("grouped_predictions")]
        public global::System.Collections.Generic.IList<global::HumeAI.GroupedFacePredictions>? GroupedPredictions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FaceModelPredictions" /> class.
        /// </summary>
        /// <param name="groupedPredictions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FaceModelPredictions(
            global::System.Collections.Generic.IList<global::HumeAI.GroupedFacePredictions>? groupedPredictions)
        {
            this.GroupedPredictions = groupedPredictions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FaceModelPredictions" /> class.
        /// </summary>
        public FaceModelPredictions()
        {
        }
    }
}