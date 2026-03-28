
#nullable enable

namespace HumeAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReturnEventMessageSpecs
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("on_new_chat")]
        public global::HumeAI.ReturnEventMessageSpec? OnNewChat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("on_inactivity_timeout")]
        public global::HumeAI.ReturnEventMessageSpec? OnInactivityTimeout { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("on_max_duration_timeout")]
        public global::HumeAI.ReturnEventMessageSpec? OnMaxDurationTimeout { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnEventMessageSpecs" /> class.
        /// </summary>
        /// <param name="onNewChat"></param>
        /// <param name="onInactivityTimeout"></param>
        /// <param name="onMaxDurationTimeout"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReturnEventMessageSpecs(
            global::HumeAI.ReturnEventMessageSpec? onNewChat,
            global::HumeAI.ReturnEventMessageSpec? onInactivityTimeout,
            global::HumeAI.ReturnEventMessageSpec? onMaxDurationTimeout)
        {
            this.OnNewChat = onNewChat;
            this.OnInactivityTimeout = onInactivityTimeout;
            this.OnMaxDurationTimeout = onMaxDurationTimeout;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnEventMessageSpecs" /> class.
        /// </summary>
        public ReturnEventMessageSpecs()
        {
        }
    }
}