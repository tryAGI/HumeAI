#nullable enable

namespace HumeAI
{
    public partial interface IEviToolsClient
    {
        /// <summary>
        /// Create an EVI tool version
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HumeAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HumeAI.ReturnUserDefinedTool> CreateEviToolVersionAsync(
            string id,

            global::HumeAI.PostedUserDefinedToolVersion request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an EVI tool version
        /// </summary>
        /// <param name="id"></param>
        /// <param name="versionDescription"></param>
        /// <param name="description"></param>
        /// <param name="parameters"></param>
        /// <param name="fallbackContent"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HumeAI.ReturnUserDefinedTool> CreateEviToolVersionAsync(
            string id,
            string parameters,
            string? versionDescription = default,
            string? description = default,
            string? fallbackContent = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}