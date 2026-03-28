#nullable enable

namespace HumeAI
{
    public partial interface ITtsClient
    {
        /// <summary>
        /// Synthesize speech (file)
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HumeAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> SynthesizeFileAsync(

            global::HumeAI.PostedTts request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Synthesize speech (file)
        /// </summary>
        /// <param name="format"></param>
        /// <param name="numGenerations"></param>
        /// <param name="utterances"></param>
        /// <param name="context"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<byte[]> SynthesizeFileAsync(
            global::System.Collections.Generic.IList<global::HumeAI.PostedUtterance> utterances,
            global::HumeAI.AudioFormat? format = default,
            int? numGenerations = default,
            global::HumeAI.PostedContext? context = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}