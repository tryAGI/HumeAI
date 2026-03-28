#nullable enable

namespace HumeAI
{
    public partial interface ITtsClient
    {
        /// <summary>
        /// Convert voice (JSON)
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HumeAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HumeAI.ReturnTts> ConvertVoiceJsonAsync(

            global::HumeAI.ConvertVoiceJsonRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Convert voice (JSON)
        /// </summary>
        /// <param name="sourceAudio"></param>
        /// <param name="sourceVoiceId"></param>
        /// <param name="targetVoiceId"></param>
        /// <param name="targetVoiceName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HumeAI.ReturnTts> ConvertVoiceJsonAsync(
            string? sourceAudio = default,
            string? sourceVoiceId = default,
            string? targetVoiceId = default,
            string? targetVoiceName = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}