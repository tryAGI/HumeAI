using System.ComponentModel;
using Microsoft.Extensions.AI;

namespace HumeAI;

public static class HumeAIClientToolExtensions
{
    /// <summary>
    /// Creates an AIFunction tool that starts a batch emotion analysis job on URLs or text.
    /// </summary>
    public static AIFunction AsStartBatchJobTool(this HumeAIClient client)
    {
        return AIFunctionFactory.Create(
            async (
                [Description("Comma-separated URLs of media files (audio, video, image) to analyze for emotions")]
                string? urls,
                [Description("Comma-separated text strings to analyze for emotions")]
                string? text,
                [Description("Whether to analyze face emotions")] bool? analyzeFace,
                [Description("Whether to analyze prosody (vocal) emotions")] bool? analyzeProsody,
                [Description("Whether to analyze language (text) emotions")] bool? analyzeLanguage,
                CancellationToken cancellationToken) =>
            {
                var request = new InferenceBaseRequest();

                if (urls is { Length: > 0 })
                {
                    request.Urls = urls.Split(',', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries)
                        .ToList();
                }

                if (text is { Length: > 0 })
                {
                    request.Text = text.Split(',', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries)
                        .ToList();
                }

                if (analyzeFace == true || analyzeProsody == true || analyzeLanguage == true)
                {
                    request.Models = new ModelsConfig
                    {
                        Face = analyzeFace == true ? new FaceModelConfig() : null,
                        Prosody = analyzeProsody == true ? new ProsodyModelConfig() : null,
                        Language = analyzeLanguage == true ? new LanguageModelConfig() : null,
                    };
                }

                var result = await client.Batch.StartBatchInferenceJobAsync(
                    request: request,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return result.JobId1 ?? "Job started (no ID returned)";
            },
            name: "hume_start_batch_job",
            description: "Start a Hume AI batch emotion analysis job on media URLs or text. Returns a job ID for tracking.");
    }

    /// <summary>
    /// Creates an AIFunction tool that gets the status and details of a batch job.
    /// </summary>
    public static AIFunction AsGetJobStatusTool(this HumeAIClient client)
    {
        return AIFunctionFactory.Create(
            async (
                [Description("The batch job ID to check status for")] string jobId,
                CancellationToken cancellationToken) =>
            {
                var job = await client.Batch.GetBatchJobDetailsAsync(
                    id: jobId,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return new
                {
                    JobId = job.JobId,
                    Status = job.State?.Status?.ToString() ?? "Unknown",
                    Type = job.Type?.ToString(),
                    Message = job.State?.Message,
                    CreatedAt = job.CreatedTimestampMs,
                    StartedAt = job.StartedTimestampMs,
                    EndedAt = job.EndedTimestampMs,
                };
            },
            name: "hume_get_job_status",
            description: "Get the status and details of a Hume AI batch emotion analysis job.");
    }

    /// <summary>
    /// Creates an AIFunction tool that lists batch jobs with optional filtering.
    /// </summary>
    public static AIFunction AsListJobsTool(this HumeAIClient client)
    {
        return AIFunctionFactory.Create(
            async (
                [Description("Maximum number of jobs to return")] int? limit,
                [Description("Filter by status: QUEUED, IN_PROGRESS, COMPLETED, FAILED")] string? status,
                CancellationToken cancellationToken) =>
            {
                ListBatchJobsStatus? statusEnum = status?.ToUpperInvariant() switch
                {
                    "QUEUED" => ListBatchJobsStatus.Queued,
                    "IN_PROGRESS" => ListBatchJobsStatus.InProgress,
                    "COMPLETED" => ListBatchJobsStatus.Completed,
                    "FAILED" => ListBatchJobsStatus.Failed,
                    _ => null,
                };

                var jobs = await client.Batch.ListBatchJobsAsync(
                    limit: limit,
                    status: statusEnum,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return jobs.Select(j => new
                {
                    JobId = j.JobId,
                    Status = j.State?.Status?.ToString() ?? "Unknown",
                    Type = j.Type?.ToString(),
                    CreatedAt = j.CreatedTimestampMs,
                }).ToList();
            },
            name: "hume_list_jobs",
            description: "List Hume AI batch emotion analysis jobs with optional status filtering.");
    }

    /// <summary>
    /// Creates an AIFunction tool that synthesizes speech from text using Hume TTS.
    /// </summary>
    public static AIFunction AsSynthesizeSpeechTool(this HumeAIClient client)
    {
        return AIFunctionFactory.Create(
            async (
                [Description("The text to synthesize into speech")] string text,
                [Description("Optional voice name to use")] string? voiceName,
                [Description("Optional voice ID to use")] string? voiceId,
                [Description("Optional description of the desired voice characteristics")] string? voiceDescription,
                [Description("Speech speed multiplier (0.5 to 2.0)")] double? speed,
                CancellationToken cancellationToken) =>
            {
                var utterance = new PostedUtterance
                {
                    Text = text,
                    Description = voiceDescription,
                    Speed = speed,
                };

                if (voiceName is { Length: > 0 } || voiceId is { Length: > 0 })
                {
                    utterance.Voice = new PostedUtteranceVoice
                    {
                        Name = voiceName,
                        Id = voiceId,
                    };
                }

                var result = await client.Tts.SynthesizeJsonAsync(
                    request: new PostedTts
                    {
                        Utterances = [utterance],
                    },
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return new
                {
                    GenerationId = result.GenerationId,
                    GenerationCount = result.Generations?.Count ?? 0,
                    SnippetCount = result.Snippets?.Count ?? 0,
                    TotalDuration = result.Generations?.Sum(g => g.Duration) ?? 0,
                };
            },
            name: "hume_synthesize_speech",
            description: "Synthesize speech from text using Hume AI TTS. Returns generation metadata (use file endpoint for actual audio).");
    }

    /// <summary>
    /// Creates an AIFunction tool that lists available TTS voices.
    /// </summary>
    public static AIFunction AsListVoicesTool(this HumeAIClient client)
    {
        return AIFunctionFactory.Create(
            async (
                [Description("Filter by voice provider: HUME_AI or CUSTOM")] string? provider,
                [Description("Filter by voice name")] string? name,
                CancellationToken cancellationToken) =>
            {
                ListVoicesProvider? providerEnum = provider?.ToUpperInvariant() switch
                {
                    "HUME_AI" => ListVoicesProvider.HumeAi,
                    "CUSTOM" => ListVoicesProvider.Custom,
                    _ => null,
                };

                var result = await client.Voices.ListVoicesAsync(
                    provider: providerEnum,
                    name: name,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return result.VoicesPage?.Select(v => new
                {
                    v.Id,
                    v.Name,
                    Provider = v.Provider?.ToString(),
                }).ToList() ?? [];
            },
            name: "hume_list_voices",
            description: "List available Hume AI TTS voices with optional filtering by provider or name.");
    }

    /// <summary>
    /// Creates an AIFunction tool that lists EVI chat sessions.
    /// </summary>
    public static AIFunction AsListChatsTool(this HumeAIClient client)
    {
        return AIFunctionFactory.Create(
            async (
                [Description("Page number (0-based)")] int? pageNumber,
                [Description("Page size")] int? pageSize,
                CancellationToken cancellationToken) =>
            {
                var result = await client.Chats.ListChatsAsync(
                    pageNumber: pageNumber,
                    pageSize: pageSize,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return result.ChatsPage?.Select(c => new
                {
                    c.Id,
                    c.ChatGroupId,
                    Status = c.Status?.ToString(),
                    c.StartTimestamp,
                    c.EndTimestamp,
                    c.EventCount,
                }).ToList() ?? [];
            },
            name: "hume_list_chats",
            description: "List Hume AI EVI (Empathic Voice Interface) chat sessions.");
    }
}
