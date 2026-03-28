#nullable enable

namespace HumeAI
{
    public partial interface IEviToolsClient
    {
        /// <summary>
        /// Create an EVI tool
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HumeAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HumeAI.ReturnUserDefinedTool> CreateEviToolAsync(

            global::HumeAI.PostedUserDefinedTool request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an EVI tool
        /// </summary>
        /// <param name="name"></param>
        /// <param name="versionDescription"></param>
        /// <param name="description"></param>
        /// <param name="parameters"></param>
        /// <param name="fallbackContent"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HumeAI.ReturnUserDefinedTool> CreateEviToolAsync(
            string name,
            string parameters,
            string? versionDescription = default,
            string? description = default,
            string? fallbackContent = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}