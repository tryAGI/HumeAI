#nullable enable

namespace HumeAI
{
    public partial interface IChatsClient
    {
        /// <summary>
        /// List EVI chats
        /// </summary>
        /// <param name="pageNumber"></param>
        /// <param name="pageSize"></param>
        /// <param name="ascendingOrder"></param>
        /// <param name="configId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HumeAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HumeAI.ReturnPagedChats> ListChatsAsync(
            int? pageNumber = default,
            int? pageSize = default,
            bool? ascendingOrder = default,
            string? configId = default,
            global::HumeAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}