#nullable enable

namespace HumeAI
{
    public partial interface IEviToolsClient
    {
        /// <summary>
        /// Update EVI tool name
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HumeAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateEviToolNameAsync(
            string id,

            global::HumeAI.PostedUserDefinedToolName request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update EVI tool name
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateEviToolNameAsync(
            string id,
            string name,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}