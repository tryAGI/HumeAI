#nullable enable

namespace HumeAI
{
    public partial interface IChatGroupsClient
    {
        /// <summary>
        /// Get chat group audio
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pageNumber"></param>
        /// <param name="pageSize"></param>
        /// <param name="ascendingOrder"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HumeAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HumeAI.ReturnChatGroupPagedAudioReconstructions> GetChatGroupAudioAsync(
            string id,
            int? pageNumber = default,
            int? pageSize = default,
            bool? ascendingOrder = default,
            global::HumeAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}