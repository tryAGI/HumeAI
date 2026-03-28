/*
order: 20
title: Text-to-Speech
slug: text-to-speech

Synthesize speech from text using the Hume TTS API.
*/

namespace HumeAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_TextToSpeech()
    {
        //// Create an authenticated client
        using var client = GetAuthenticatedClient();

        //// Synthesize speech from text
        var result = await client.Tts.SynthesizeJsonAsync(
            request: new PostedTts
            {
                Utterances =
                [
                    new PostedUtterance
                    {
                        Text = "Hello! I am excited to demonstrate Hume's text-to-speech capabilities.",
                        Speed = 1.0,
                    },
                ],
            });

        //// The result contains generation metadata and audio data
        result.GenerationId.Should().NotBeNullOrEmpty();
    }
}
