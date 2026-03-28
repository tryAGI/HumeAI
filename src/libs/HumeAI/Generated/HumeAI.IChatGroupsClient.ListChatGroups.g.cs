#nullable enable

namespace HumeAI
{
    public partial interface IChatGroupsClient
    {
        /// <summary>
        /// List chat groups
        /// </summary>
        /// <param name="pageNumber"></param>
        /// <param name="pageSize"></param>
        /// <param name="ascendingOrder"></param>
        /// <param name="configId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HumeAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HumeAI.ReturnPagedChatGroups> ListChatGroupsAsync(
            int? pageNumber = default,
            int? pageSize = default,
            bool? ascendingOrder = default,
            string? configId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}