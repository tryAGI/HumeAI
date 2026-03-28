namespace HumeAI.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static HumeAIClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("HUMEAI_API_KEY") is { Length: > 0 } apiKeyValue ? apiKeyValue :
            Environment.GetEnvironmentVariable("HUME_API_KEY") is { Length: > 0 } humeKeyValue ? humeKeyValue :
            throw new AssertInconclusiveException("HUMEAI_API_KEY environment variable is not found.");

        var client = new HumeAIClient(apiKey);

        return client;
    }
}
