#nullable enable

namespace HumeAI
{
    public partial interface IEviToolsClient
    {
        /// <summary>
        /// Get an EVI tool version
        /// </summary>
        /// <param name="id"></param>
        /// <param name="version"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HumeAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HumeAI.ReturnUserDefinedTool> GetEviToolVersionAsync(
            string id,
            int version,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}