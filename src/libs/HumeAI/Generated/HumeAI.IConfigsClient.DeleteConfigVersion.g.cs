#nullable enable

namespace HumeAI
{
    public partial interface IConfigsClient
    {
        /// <summary>
        /// Delete a config version
        /// </summary>
        /// <param name="id"></param>
        /// <param name="version"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HumeAI.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteConfigVersionAsync(
            string id,
            int version,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}