
#nullable enable

namespace HumeAI
{
    public sealed partial class HumeAIClient
    {

        /// <inheritdoc/>
        public void AuthorizeUsingApiKeyInHeader(
            string apiKey)
        {
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            for (var i = Authorizations.Count - 1; i >= 0; i--)
            {
                var __authorization = Authorizations[i];
                if (__authorization.Type == "ApiKey" &&
                    __authorization.Location == "Header" &&
                    __authorization.Name == "X-Hume-Api-Key")
                {
                    Authorizations.RemoveAt(i);
                }
            }

            Authorizations.Add(new global::HumeAI.EndPointAuthorization
            {
                Type = "ApiKey",
                SchemeId = "HumeApiKey",
                Location = "Header",
                Name = "X-Hume-Api-Key",
                Value = apiKey,
            });
        }
    }
}