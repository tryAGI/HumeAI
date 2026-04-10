#nullable enable

namespace HumeAI
{
    public partial interface IEviToolsClient
    {
        /// <summary>
        /// Update EVI tool description
        /// </summary>
        /// <param name="id"></param>
        /// <param name="version"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HumeAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HumeAI.ReturnUserDefinedTool> UpdateEviToolDescriptionAsync(
            string id,
            int version,

            global::HumeAI.PostedUserDefinedToolVersionDescription request,
            global::HumeAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update EVI tool description
        /// </summary>
        /// <param name="id"></param>
        /// <param name="version"></param>
        /// <param name="versionDescription"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HumeAI.ReturnUserDefinedTool> UpdateEviToolDescriptionAsync(
            string id,
            int version,
            string? versionDescription = default,
            global::HumeAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}