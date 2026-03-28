#nullable enable

namespace HumeAI
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// Update prompt version description
        /// </summary>
        /// <param name="id"></param>
        /// <param name="version"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HumeAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HumeAI.ReturnPrompt> UpdatePromptDescriptionAsync(
            string id,
            int version,

            global::HumeAI.PostedPromptVersionDescription request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update prompt version description
        /// </summary>
        /// <param name="id"></param>
        /// <param name="version"></param>
        /// <param name="versionDescription"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HumeAI.ReturnPrompt> UpdatePromptDescriptionAsync(
            string id,
            int version,
            string? versionDescription = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}