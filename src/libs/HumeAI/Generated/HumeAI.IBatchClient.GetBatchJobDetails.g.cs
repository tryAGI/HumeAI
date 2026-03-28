#nullable enable

namespace HumeAI
{
    public partial interface IBatchClient
    {
        /// <summary>
        /// Get batch job details
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HumeAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HumeAI.InferenceJob> GetBatchJobDetailsAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}