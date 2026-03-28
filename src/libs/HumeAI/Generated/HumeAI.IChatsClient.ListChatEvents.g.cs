#nullable enable

namespace HumeAI
{
    public partial interface IChatsClient
    {
        /// <summary>
        /// List chat events
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pageNumber"></param>
        /// <param name="pageSize"></param>
        /// <param name="ascendingOrder"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HumeAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HumeAI.ReturnChatPagedEvents> ListChatEventsAsync(
            string id,
            int? pageNumber = default,
            int? pageSize = default,
            bool? ascendingOrder = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}