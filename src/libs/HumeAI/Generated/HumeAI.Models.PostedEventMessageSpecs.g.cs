
#nullable enable

namespace HumeAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostedEventMessageSpecs
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("on_new_chat")]
        public global::HumeAI.PostedEventMessageSpec? OnNewChat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("on_inactivity_timeout")]
        public global::HumeAI.PostedEventMessageSpec? OnInactivityTimeout { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("on_max_duration_timeout")]
        public global::HumeAI.PostedEventMessageSpec? OnMaxDurationTimeout { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostedEventMessageSpecs" /> class.
        /// </summary>
        /// <param name="onNewChat"></param>
        /// <param name="onInactivityTimeout"></param>
        /// <param name="onMaxDurationTimeout"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostedEventMessageSpecs(
            global::HumeAI.PostedEventMessageSpec? onNewChat,
            global::HumeAI.PostedEventMessageSpec? onInactivityTimeout,
            global::HumeAI.PostedEventMessageSpec? onMaxDurationTimeout)
        {
            this.OnNewChat = onNewChat;
            this.OnInactivityTimeout = onInactivityTimeout;
            this.OnMaxDurationTimeout = onMaxDurationTimeout;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostedEventMessageSpecs" /> class.
        /// </summary>
        public PostedEventMessageSpecs()
        {
        }
    }
}