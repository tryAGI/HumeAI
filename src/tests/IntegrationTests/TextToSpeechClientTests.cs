#nullable enable
#pragma warning disable MEAI001

using System.Net;
using System.Text.Json;
using Microsoft.Extensions.AI;

namespace HumeAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void TextToSpeechClient_GetService_Metadata()
    {
        using var client = new HumeAIClient("test-api-key");
        ITextToSpeechClient ttsClient = client;

        var metadata = ttsClient.GetService<TextToSpeechClientMetadata>();

        metadata.Should().NotBeNull();
        metadata!.ProviderName.Should().Be("hume-ai");
        metadata.DefaultModelId.Should().Be("octave");
        metadata.ProviderUri.Should().NotBeNull();
        ttsClient.GetService<HumeAIClient>().Should().BeSameAs(client);
    }

    [TestMethod]
    public async Task TextToSpeechClient_MapsOptionsToPostedTts()
    {
        var handler = new StaticResponseHandler(HttpStatusCode.OK, [1, 2, 3], "audio/wav");
        using var client = new HumeAIClient(
            "test-api-key",
            new HttpClient(handler)
            {
                BaseAddress = new Uri(HumeAIClient.DefaultBaseUrl),
            });
        ITextToSpeechClient ttsClient = client;
        PostedTts? capturedRequest = null;

        var response = await ttsClient.GetAudioAsync(
            "Hello from Hume Octave.",
            new TextToSpeechOptions
            {
                ModelId = "octave-2",
                VoiceId = "voice-id-123",
                AudioFormat = "wav",
                Speed = 1.15f,
                AdditionalProperties = new()
                {
                    [HumeAITextToSpeechPropertyNames.VoiceName] = "Ava",
                    [HumeAITextToSpeechPropertyNames.VoiceProvider] = "HUME_AI",
                    [HumeAITextToSpeechPropertyNames.Description] = "Warm and expressive",
                    [HumeAITextToSpeechPropertyNames.TrailingSilence] = 0.25,
                    [HumeAITextToSpeechPropertyNames.InstantMode] = true,
                    [HumeAITextToSpeechPropertyNames.NumGenerations] = 1,
                    [HumeAITextToSpeechPropertyNames.SampleRate] = 24000,
                    [HumeAITextToSpeechPropertyNames.BitDepth] = 16,
                    [HumeAITextToSpeechPropertyNames.IncludeTimestampTypes] = new[] { "word" },
                },
                RawRepresentationFactory = _ =>
                {
                    capturedRequest = new PostedTts
                    {
                        Utterances =
                        [
                            new PostedUtterance
                            {
                                Text = string.Empty,
                            },
                        ],
                    };

                    return capturedRequest;
                },
            });

        capturedRequest.Should().NotBeNull();
        capturedRequest!.Utterances.Should().ContainSingle();
        var utterance = capturedRequest.Utterances.Single();
        utterance.Text.Should().Be("Hello from Hume Octave.");
        utterance.Speed.Should().BeApproximately(1.15, 0.00001);
        utterance.Description.Should().Be("Warm and expressive");
        utterance.TrailingSilence.Should().Be(0.25);
        utterance.InstantMode.Should().BeTrue();
        utterance.Voice.Should().NotBeNull();
        utterance.Voice!.Id.Should().Be("voice-id-123");
        utterance.Voice.Name.Should().Be("Ava");
        utterance.Voice.Provider.Should().Be(PostedUtteranceVoiceProvider.HumeAi);
        capturedRequest.Format!.Type.Should().Be(AudioFormatType.Wav);
        capturedRequest.Format.SampleRate.Should().Be(24000);
        capturedRequest.Format.BitDepth.Should().Be(16);
        capturedRequest.NumGenerations.Should().Be(1);
        capturedRequest.AdditionalProperties["version"].Should().Be("2");

        handler.LastRequest.Should().NotBeNull();
        handler.LastRequest!.RequestUri!.AbsolutePath.Should().Be("/v0/tts/file");
        handler.LastRequest.Headers.Authorization!.Scheme.Should().Be("Bearer");
        handler.LastRequest.Headers.Authorization.Parameter.Should().Be("test-api-key");

        response.Contents.OfType<DataContent>().Single().Data.ToArray().Should().Equal([1, 2, 3]);
        response.ModelId.Should().Be("octave-2");
        response.AdditionalProperties!["version"].Should().Be("2");

        using var document = JsonDocument.Parse(handler.LastRequestBody!);
        document.RootElement.GetProperty("version").GetString().Should().Be("2");
        document.RootElement.GetProperty("format").GetProperty("type").GetString().Should().Be("wav");
        document.RootElement.GetProperty("format").GetProperty("sample_rate").GetInt32().Should().Be(24000);
        document.RootElement.GetProperty("utterances")[0].GetProperty("text").GetString().Should().Be("Hello from Hume Octave.");
        document.RootElement.GetProperty("utterances")[0].GetProperty("voice").GetProperty("id").GetString().Should().Be("voice-id-123");
        document.RootElement.GetProperty("utterances")[0].GetProperty("voice").GetProperty("provider").GetString().Should().Be("HUME_AI");
    }

    [TestMethod]
    public async Task TextToSpeechClient_StreamsAudioChunks()
    {
        var handler = new StaticResponseHandler(HttpStatusCode.OK, [1, 2, 3, 4], "audio/mpeg");
        using var client = new HumeAIClient(
            "test-api-key",
            new HttpClient(handler)
            {
                BaseAddress = new Uri(HumeAIClient.DefaultBaseUrl),
            });
        ITextToSpeechClient ttsClient = client;

        var updates = new List<TextToSpeechResponseUpdate>();
        await foreach (var update in ttsClient.GetStreamingAudioAsync(
            "Streaming Hume speech.",
            new TextToSpeechOptions
            {
                AudioFormat = "mp3",
            }))
        {
            updates.Add(update);
        }

        handler.LastRequest.Should().NotBeNull();
        handler.LastRequest!.RequestUri!.AbsolutePath.Should().Be("/v0/tts/stream/file");
        updates.First().Kind.Should().Be(TextToSpeechResponseUpdateKind.SessionOpen);
        updates.Should().Contain(static update => update.Kind == TextToSpeechResponseUpdateKind.AudioUpdating);
        updates.Should().Contain(static update => update.Kind == TextToSpeechResponseUpdateKind.AudioUpdated);
        updates.Last().Kind.Should().Be(TextToSpeechResponseUpdateKind.SessionClose);
    }

    private sealed class StaticResponseHandler(
        HttpStatusCode statusCode,
        byte[] responseBody,
        string mediaType) : HttpMessageHandler
    {
        public HttpRequestMessage? LastRequest { get; private set; }
        public string? LastRequestBody { get; private set; }

        protected override async Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            LastRequest = request;
            LastRequestBody = request.Content is null
                ? null
                : await request.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            return new HttpResponseMessage(statusCode)
            {
                RequestMessage = request,
                Content = new ByteArrayContent(responseBody)
                {
                    Headers =
                    {
                        ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue(mediaType),
                    },
                },
            };
        }
    }
}
