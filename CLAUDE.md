# CLAUDE.md

## Project Overview

This is the tryAGI Hume AI .NET SDK, auto-generated from a manually maintained OpenAPI spec using AutoSDK.

**Hume AI** provides emotion recognition and analysis APIs:
- **Expression Measurement (Batch)** -- Submit audio, video, text, or images for emotion analysis across 48+ dimensions
- **Empathic Voice Interface (EVI)** -- Conversational AI with emotion understanding (configs, prompts, tools, chats, chat groups)
- **Text-to-Speech (TTS)** -- Emotionally expressive speech synthesis with voice customization

## Key Files

- `src/libs/HumeAI/openapi.yaml` -- Manually maintained OpenAPI spec (no public spec exists)
- `src/libs/HumeAI/generate.sh` -- Regeneration script
- `src/libs/HumeAI/Generated/` -- Auto-generated code (NEVER edit)
- `src/libs/HumeAI/Extensions/HumeAIClient.Tools.cs` -- MEAI AIFunction tools

## Build & Test

```bash
dotnet build HumeAI.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

Set `HUMEAI_API_KEY` or `HUME_API_KEY` environment variable. Uses Bearer token auth.

## MEAI Integration

AIFunction tools for use with any `IChatClient`:
- `AsStartBatchJobTool()` -- Start emotion analysis batch job
- `AsGetJobStatusTool()` -- Check batch job status
- `AsListJobsTool()` -- List batch jobs
- `AsSynthesizeSpeechTool()` -- TTS synthesis
- `AsListVoicesTool()` -- List TTS voices
- `AsListChatsTool()` -- List EVI chat sessions
