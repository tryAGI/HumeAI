#nullable enable

namespace HumeAI
{
    public partial interface IVoicesClient
    {
        /// <summary>
        /// Delete a custom voice
        /// </summary>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HumeAI.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteVoiceAsync(
            string name,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}