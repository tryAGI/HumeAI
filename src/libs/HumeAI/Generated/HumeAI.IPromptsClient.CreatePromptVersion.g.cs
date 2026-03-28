#nullable enable

namespace HumeAI
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// Create a prompt version
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HumeAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HumeAI.ReturnPrompt> CreatePromptVersionAsync(
            string id,

            global::HumeAI.PostedPromptVersion request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a prompt version
        /// </summary>
        /// <param name="id"></param>
        /// <param name="versionDescription"></param>
        /// <param name="text"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HumeAI.ReturnPrompt> CreatePromptVersionAsync(
            string id,
            string text,
            string? versionDescription = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}