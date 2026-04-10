#nullable enable

namespace HumeAI
{
    public partial interface IBatchClient
    {
        /// <summary>
        /// List batch jobs<br/>
        /// List all batch inference jobs
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="status"></param>
        /// <param name="when"></param>
        /// <param name="timestampMs"></param>
        /// <param name="sortBy"></param>
        /// <param name="direction"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HumeAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::HumeAI.InferenceJob>> ListBatchJobsAsync(
            int? limit = default,
            global::HumeAI.ListBatchJobsStatus? status = default,
            long? when = default,
            long? timestampMs = default,
            global::HumeAI.ListBatchJobsSortBy? sortBy = default,
            global::HumeAI.ListBatchJobsDirection? direction = default,
            global::HumeAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}