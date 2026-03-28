/*
order: 30
title: MEAI Tools
slug: meai-tools

Use AIFunction tools with Microsoft.Extensions.AI for integration with any IChatClient.
*/

using Microsoft.Extensions.AI;

namespace HumeAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void Example_MeaiTools()
    {
        //// Create an authenticated client
        using var client = GetAuthenticatedClient();

        //// Create AIFunction tools for use with any IChatClient
        var startJobTool = client.AsStartBatchJobTool();
        var getStatusTool = client.AsGetJobStatusTool();
        var listJobsTool = client.AsListJobsTool();
        var synthesizeTool = client.AsSynthesizeSpeechTool();
        var listVoicesTool = client.AsListVoicesTool();
        var listChatsTool = client.AsListChatsTool();

        //// Verify tools are created with proper metadata
        startJobTool.Name.Should().Be("hume_start_batch_job");
        getStatusTool.Name.Should().Be("hume_get_job_status");
        listJobsTool.Name.Should().Be("hume_list_jobs");
        synthesizeTool.Name.Should().Be("hume_synthesize_speech");
        listVoicesTool.Name.Should().Be("hume_list_voices");
        listChatsTool.Name.Should().Be("hume_list_chats");
    }
}
