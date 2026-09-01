#nullable enable

namespace HumeAI
{
    public partial interface ITtsClient
    {
        /// <summary>
        /// Synthesize speech (file)
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HumeAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> SynthesizeFileAsync(

            global::HumeAI.PostedTts request,
            global::HumeAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Synthesize speech (file)
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HumeAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> SynthesizeFileAsStreamAsync(

            global::HumeAI.PostedTts request,
            global::HumeAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Synthesize speech (file)
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HumeAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HumeAI.AutoSDKHttpResponse<byte[]>> SynthesizeFileAsResponseAsync(

            global::HumeAI.PostedTts request,
            global::HumeAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Synthesize speech (file)
        /// </summary>
        /// <param name="version">
        /// Octave model version. Use "2" to opt into Octave 2; a voice is required.
        /// </param>
        /// <param name="format"></param>
        /// <param name="numGenerations"></param>
        /// <param name="utterances"></param>
        /// <param name="context"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<byte[]> SynthesizeFileAsync(
            global::System.Collections.Generic.IList<global::HumeAI.PostedUtterance> utterances,
            string? version = default,
            global::HumeAI.AudioFormat? format = default,
            int? numGenerations = default,
            global::HumeAI.PostedContext? context = default,
            global::HumeAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}