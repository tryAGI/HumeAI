
#nullable enable

namespace HumeAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostedPromptVersion
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_description")]
        public string? VersionDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostedPromptVersion" /> class.
        /// </summary>
        /// <param name="versionDescription"></param>
        /// <param name="text"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostedPromptVersion(
            string text,
            string? versionDescription)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.VersionDescription = versionDescription;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostedPromptVersion" /> class.
        /// </summary>
        public PostedPromptVersion()
        {
        }
    }
}