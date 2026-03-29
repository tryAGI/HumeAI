# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The HumeAI SDK provides `AIFunction` tool wrappers compatible with [Microsoft.Extensions.AI](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai). These tools can be used with any `IChatClient` to give AI models access to Hume AI's emotion analysis, speech synthesis, and conversational AI capabilities.

## Available Tools

| Tool | Description |
|------|-------------|
| `AsStartBatchJobTool()` | Start a batch emotion analysis job on media URLs or text |
| `AsGetJobStatusTool()` | Get the status and details of a batch job |
| `AsListJobsTool()` | List batch jobs with optional status filtering |
| `AsSynthesizeSpeechTool()` | Synthesize speech from text using Hume TTS |
| `AsListVoicesTool()` | List available TTS voices |
| `AsListChatsTool()` | List EVI chat sessions |

## Usage Example

```csharp
using HumeAI;
using Microsoft.Extensions.AI;

// Create the Hume AI client
using var humeClient = new HumeAIClient(apiKey: "your-api-key");

// Create tools for use with any IChatClient
var tools = new[]
{
    humeClient.AsStartBatchJobTool(),
    humeClient.AsGetJobStatusTool(),
    humeClient.AsListJobsTool(),
    humeClient.AsSynthesizeSpeechTool(),
    humeClient.AsListVoicesTool(),
    humeClient.AsListChatsTool(),
};

// Use with any IChatClient (e.g., OpenAI, Anthropic, etc.)
// var response = await chatClient.GetResponseAsync(
//     "Analyze the emotions in this text: I am thrilled\!",
//     new ChatOptions { Tools = tools.Select(t => t as AITool).ToList() });
```

## Installation

```bash
dotnet add package HumeAI
dotnet add package Microsoft.Extensions.AI
```
