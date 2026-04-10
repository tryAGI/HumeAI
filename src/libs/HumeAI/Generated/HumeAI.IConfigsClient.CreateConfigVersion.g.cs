#nullable enable

namespace HumeAI
{
    public partial interface IConfigsClient
    {
        /// <summary>
        /// Create a config version
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HumeAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HumeAI.ReturnConfig> CreateConfigVersionAsync(
            string id,

            global::HumeAI.PostedConfigVersion request,
            global::HumeAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a config version
        /// </summary>
        /// <param name="id"></param>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HumeAI.ReturnConfig> CreateConfigVersionAsync(
            string id,
            string? versionDescription = default,
            string? eviVersion = default,
            global::HumeAI.PostedConfigPromptSpec? prompt = default,
            global::HumeAI.PostedUtteranceVoice? voice = default,
            global::HumeAI.PostedLanguageModel? languageModel = default,
            global::HumeAI.PostedEllmModel? ellmModel = default,
            global::System.Collections.Generic.IList<global::HumeAI.PostedUserDefinedToolSpec>? tools = default,
            global::System.Collections.Generic.IList<global::HumeAI.PostedBuiltinTool>? builtinTools = default,
            global::HumeAI.PostedEventMessageSpecs? eventMessages = default,
            global::HumeAI.PostedTimeoutSpecs? timeouts = default,
            global::HumeAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}