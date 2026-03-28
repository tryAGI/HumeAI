#nullable enable

namespace HumeAI
{
    public partial interface IConfigsClient
    {
        /// <summary>
        /// Update config name
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HumeAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateConfigNameAsync(
            string id,

            global::HumeAI.PostedConfigName request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update config name
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateConfigNameAsync(
            string id,
            string name,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}