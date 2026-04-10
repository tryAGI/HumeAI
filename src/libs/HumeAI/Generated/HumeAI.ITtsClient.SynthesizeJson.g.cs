#nullable enable

namespace HumeAI
{
    public partial interface ITtsClient
    {
        /// <summary>
        /// Synthesize speech (JSON)
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HumeAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HumeAI.ReturnTts> SynthesizeJsonAsync(

            global::HumeAI.PostedTts request,
            global::HumeAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Synthesize speech (JSON)
        /// </summary>
        /// <param name="format"></param>
        /// <param name="numGenerations"></param>
        /// <param name="utterances"></param>
        /// <param name="context"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HumeAI.ReturnTts> SynthesizeJsonAsync(
            global::System.Collections.Generic.IList<global::HumeAI.PostedUtterance> utterances,
            global::HumeAI.AudioFormat? format = default,
            int? numGenerations = default,
            global::HumeAI.PostedContext? context = default,
            global::HumeAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}