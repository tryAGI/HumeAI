/*
order: 10
title: Emotion Analysis
slug: emotion-analysis

Submit text for batch emotion analysis using the Expression Measurement API.
*/

namespace HumeAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_EmotionAnalysis()
    {
        //// Create an authenticated client
        using var client = GetAuthenticatedClient();

        //// Start a batch inference job with text analysis
        var jobResult = await client.Batch.StartBatchInferenceJobAsync(
            request: new InferenceBaseRequest
            {
                Text = ["I am so happy to see you! This is wonderful news."],
                Models = new ModelsConfig
                {
                    Language = new LanguageModelConfig(),
                },
            });

        //// The job ID can be used to check status and retrieve predictions
        jobResult.JobId1.Should().NotBeNullOrEmpty();
    }
}
