#nullable enable

namespace HumeAI
{
    public partial interface IVoicesClient
    {
        /// <summary>
        /// List TTS voices
        /// </summary>
        /// <param name="pageNumber"></param>
        /// <param name="pageSize"></param>
        /// <param name="provider"></param>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HumeAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HumeAI.ReturnPagedVoices> ListVoicesAsync(
            int? pageNumber = default,
            int? pageSize = default,
            global::HumeAI.ListVoicesProvider? provider = default,
            string? name = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}