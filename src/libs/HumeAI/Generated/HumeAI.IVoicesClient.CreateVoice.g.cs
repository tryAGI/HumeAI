#nullable enable

namespace HumeAI
{
    public partial interface IVoicesClient
    {
        /// <summary>
        /// Create a custom voice
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HumeAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HumeAI.ReturnVoice> CreateVoiceAsync(

            global::HumeAI.PostedVoice request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a custom voice
        /// </summary>
        /// <param name="generationId"></param>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HumeAI.ReturnVoice> CreateVoiceAsync(
            string generationId,
            string name,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}