
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace HumeAI
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::HumeAI.JsonConverters.ProsodyModelConfigGranularityJsonConverter),

            typeof(global::HumeAI.JsonConverters.ProsodyModelConfigGranularityNullableJsonConverter),

            typeof(global::HumeAI.JsonConverters.LanguageModelConfigGranularityJsonConverter),

            typeof(global::HumeAI.JsonConverters.LanguageModelConfigGranularityNullableJsonConverter),

            typeof(global::HumeAI.JsonConverters.InferenceJobTypeJsonConverter),

            typeof(global::HumeAI.JsonConverters.InferenceJobTypeNullableJsonConverter),

            typeof(global::HumeAI.JsonConverters.JobStateStatusJsonConverter),

            typeof(global::HumeAI.JsonConverters.JobStateStatusNullableJsonConverter),

            typeof(global::HumeAI.JsonConverters.SourceTypeJsonConverter),

            typeof(global::HumeAI.JsonConverters.SourceTypeNullableJsonConverter),

            typeof(global::HumeAI.JsonConverters.PostedUtteranceVoiceProviderJsonConverter),

            typeof(global::HumeAI.JsonConverters.PostedUtteranceVoiceProviderNullableJsonConverter),

            typeof(global::HumeAI.JsonConverters.AudioFormatTypeJsonConverter),

            typeof(global::HumeAI.JsonConverters.AudioFormatTypeNullableJsonConverter),

            typeof(global::HumeAI.JsonConverters.ReturnVoiceProviderJsonConverter),

            typeof(global::HumeAI.JsonConverters.ReturnVoiceProviderNullableJsonConverter),

            typeof(global::HumeAI.JsonConverters.PostedLanguageModelModelProviderJsonConverter),

            typeof(global::HumeAI.JsonConverters.PostedLanguageModelModelProviderNullableJsonConverter),

            typeof(global::HumeAI.JsonConverters.PostedBuiltinToolNameJsonConverter),

            typeof(global::HumeAI.JsonConverters.PostedBuiltinToolNameNullableJsonConverter),

            typeof(global::HumeAI.JsonConverters.ReturnToolItemToolTypeJsonConverter),

            typeof(global::HumeAI.JsonConverters.ReturnToolItemToolTypeNullableJsonConverter),

            typeof(global::HumeAI.JsonConverters.ReturnUserDefinedToolToolTypeJsonConverter),

            typeof(global::HumeAI.JsonConverters.ReturnUserDefinedToolToolTypeNullableJsonConverter),

            typeof(global::HumeAI.JsonConverters.ReturnChatStatusJsonConverter),

            typeof(global::HumeAI.JsonConverters.ReturnChatStatusNullableJsonConverter),

            typeof(global::HumeAI.JsonConverters.ReturnPagedChatsPaginationDirectionJsonConverter),

            typeof(global::HumeAI.JsonConverters.ReturnPagedChatsPaginationDirectionNullableJsonConverter),

            typeof(global::HumeAI.JsonConverters.ReturnChatEventRoleJsonConverter),

            typeof(global::HumeAI.JsonConverters.ReturnChatEventRoleNullableJsonConverter),

            typeof(global::HumeAI.JsonConverters.ReturnChatEventTypeJsonConverter),

            typeof(global::HumeAI.JsonConverters.ReturnChatEventTypeNullableJsonConverter),

            typeof(global::HumeAI.JsonConverters.ReturnChatPagedEventsPaginationDirectionJsonConverter),

            typeof(global::HumeAI.JsonConverters.ReturnChatPagedEventsPaginationDirectionNullableJsonConverter),

            typeof(global::HumeAI.JsonConverters.ReturnChatAudioReconstructionStatusJsonConverter),

            typeof(global::HumeAI.JsonConverters.ReturnChatAudioReconstructionStatusNullableJsonConverter),

            typeof(global::HumeAI.JsonConverters.ReturnPagedChatGroupsPaginationDirectionJsonConverter),

            typeof(global::HumeAI.JsonConverters.ReturnPagedChatGroupsPaginationDirectionNullableJsonConverter),

            typeof(global::HumeAI.JsonConverters.ReturnChatGroupPagedChatsPaginationDirectionJsonConverter),

            typeof(global::HumeAI.JsonConverters.ReturnChatGroupPagedChatsPaginationDirectionNullableJsonConverter),

            typeof(global::HumeAI.JsonConverters.ReturnChatGroupPagedEventsPaginationDirectionJsonConverter),

            typeof(global::HumeAI.JsonConverters.ReturnChatGroupPagedEventsPaginationDirectionNullableJsonConverter),

            typeof(global::HumeAI.JsonConverters.ReturnChatGroupPagedAudioReconstructionsPaginationDirectionJsonConverter),

            typeof(global::HumeAI.JsonConverters.ReturnChatGroupPagedAudioReconstructionsPaginationDirectionNullableJsonConverter),

            typeof(global::HumeAI.JsonConverters.ListBatchJobsStatusJsonConverter),

            typeof(global::HumeAI.JsonConverters.ListBatchJobsStatusNullableJsonConverter),

            typeof(global::HumeAI.JsonConverters.ListBatchJobsSortByJsonConverter),

            typeof(global::HumeAI.JsonConverters.ListBatchJobsSortByNullableJsonConverter),

            typeof(global::HumeAI.JsonConverters.ListBatchJobsDirectionJsonConverter),

            typeof(global::HumeAI.JsonConverters.ListBatchJobsDirectionNullableJsonConverter),

            typeof(global::HumeAI.JsonConverters.ListVoicesProviderJsonConverter),

            typeof(global::HumeAI.JsonConverters.ListVoicesProviderNullableJsonConverter),

            typeof(global::HumeAI.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.EmotionScore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.BoundingBox))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.TimeInterval))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.FacePrediction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HumeAI.EmotionScore>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HumeAI.FacsScore>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.FacsScore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HumeAI.DescriptionsScore>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.DescriptionsScore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.ProsodyPrediction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.LanguagePrediction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.PositionInterval))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HumeAI.SentimentScore>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.SentimentScore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HumeAI.ToxicityScore>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.ToxicityScore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.BurstPrediction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.NerPrediction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.FaceModelConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.ProsodyModelConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.ProsodyModelConfigGranularity), TypeInfoPropertyName = "ProsodyModelConfigGranularity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.LanguageModelConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.LanguageModelConfigGranularity), TypeInfoPropertyName = "LanguageModelConfigGranularity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.BurstModelConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.NerModelConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.ModelsConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.TranscriptionConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.InferenceBaseRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.JobId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.InferenceJob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.InferenceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.JobState))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.InferenceJobType), TypeInfoPropertyName = "InferenceJobType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HumeAI.SourceFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.SourceFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.JobStateStatus), TypeInfoPropertyName = "JobStateStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.InferenceSourcePredictResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.Source))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.InferenceResults))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.SourceType), TypeInfoPropertyName = "SourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HumeAI.InferencePrediction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.InferencePrediction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HumeAI.InferenceError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.InferenceError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.ModelsPredictions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.FaceModelPredictions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.ProsodyModelPredictions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.LanguageModelPredictions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.BurstModelPredictions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.NerModelPredictions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HumeAI.GroupedFacePredictions>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.GroupedFacePredictions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HumeAI.GroupedProsodyPredictions>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.GroupedProsodyPredictions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HumeAI.GroupedLanguagePredictions>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.GroupedLanguagePredictions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HumeAI.GroupedBurstPredictions>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.GroupedBurstPredictions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HumeAI.GroupedNerPredictions>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.GroupedNerPredictions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HumeAI.FacePrediction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HumeAI.ProsodyPrediction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HumeAI.LanguagePrediction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HumeAI.BurstPrediction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HumeAI.NerPrediction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.PostedTts))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.AudioFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HumeAI.PostedUtterance>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.PostedUtterance))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.PostedContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.PostedUtteranceVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.PostedUtteranceVoiceProvider), TypeInfoPropertyName = "PostedUtteranceVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.AudioFormatType), TypeInfoPropertyName = "AudioFormatType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.ReturnTts))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HumeAI.ReturnGeneration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.ReturnGeneration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HumeAI.Snippet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.Snippet))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.PostedVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.ReturnVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.ReturnVoiceProvider), TypeInfoPropertyName = "ReturnVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.ReturnPagedVoices))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HumeAI.ReturnVoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.ConvertVoiceJsonRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.PostedConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.PostedConfigPromptSpec))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.PostedLanguageModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.PostedEllmModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HumeAI.PostedUserDefinedToolSpec>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.PostedUserDefinedToolSpec))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HumeAI.PostedBuiltinTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.PostedBuiltinTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.PostedEventMessageSpecs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.PostedTimeoutSpecs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.PostedLanguageModelModelProvider), TypeInfoPropertyName = "PostedLanguageModelModelProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.PostedBuiltinToolName), TypeInfoPropertyName = "PostedBuiltinToolName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.PostedEventMessageSpec))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.PostedTimeoutSpecsInactivity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.PostedTimeoutSpecsMaxDuration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.PostedConfigVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.PostedConfigName))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.PostedConfigVersionDescription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.ReturnConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.ReturnConfigPromptSpec))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.ReturnLanguageModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.ReturnEllmModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HumeAI.ReturnToolItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.ReturnToolItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HumeAI.ReturnBuiltinTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.ReturnBuiltinTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.ReturnEventMessageSpecs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.ReturnTimeoutSpecs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.ReturnToolItemToolType), TypeInfoPropertyName = "ReturnToolItemToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.ReturnEventMessageSpec))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.ReturnTimeoutSpec))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.ReturnPagedConfigs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HumeAI.ReturnConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.PostedPrompt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.PostedPromptVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.PostedPromptName))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.PostedPromptVersionDescription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.ReturnPrompt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.ReturnPagedPrompts))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HumeAI.ReturnPrompt>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.PostedUserDefinedTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.PostedUserDefinedToolVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.PostedUserDefinedToolName))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.PostedUserDefinedToolVersionDescription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.ReturnUserDefinedTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.ReturnUserDefinedToolToolType), TypeInfoPropertyName = "ReturnUserDefinedToolToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.ReturnPagedUserDefinedTools))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HumeAI.ReturnUserDefinedTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.ReturnChat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.ReturnChatStatus), TypeInfoPropertyName = "ReturnChatStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.ReturnPagedChats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.ReturnPagedChatsPaginationDirection), TypeInfoPropertyName = "ReturnPagedChatsPaginationDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HumeAI.ReturnChat>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.ReturnChatEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.ReturnChatEventRole), TypeInfoPropertyName = "ReturnChatEventRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.ReturnChatEventType), TypeInfoPropertyName = "ReturnChatEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.ReturnChatPagedEvents))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.ReturnChatPagedEventsPaginationDirection), TypeInfoPropertyName = "ReturnChatPagedEventsPaginationDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HumeAI.ReturnChatEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.ReturnChatAudioReconstruction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.ReturnChatAudioReconstructionStatus), TypeInfoPropertyName = "ReturnChatAudioReconstructionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.ReturnChatGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.ReturnPagedChatGroups))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.ReturnPagedChatGroupsPaginationDirection), TypeInfoPropertyName = "ReturnPagedChatGroupsPaginationDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HumeAI.ReturnChatGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.ReturnChatGroupPagedChats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.ReturnChatGroupPagedChatsPaginationDirection), TypeInfoPropertyName = "ReturnChatGroupPagedChatsPaginationDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.ReturnChatGroupPagedEvents))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.ReturnChatGroupPagedEventsPaginationDirection), TypeInfoPropertyName = "ReturnChatGroupPagedEventsPaginationDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.ReturnChatGroupPagedAudioReconstructions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.ReturnChatGroupPagedAudioReconstructionsPaginationDirection), TypeInfoPropertyName = "ReturnChatGroupPagedAudioReconstructionsPaginationDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HumeAI.ReturnChatAudioReconstruction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.ListBatchJobsStatus), TypeInfoPropertyName = "ListBatchJobsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.ListBatchJobsSortBy), TypeInfoPropertyName = "ListBatchJobsSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.ListBatchJobsDirection), TypeInfoPropertyName = "ListBatchJobsDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.ListVoicesProvider), TypeInfoPropertyName = "ListVoicesProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HumeAI.InferenceJob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HumeAI.InferenceSourcePredictResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HumeAI.EmotionScore>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HumeAI.FacsScore>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HumeAI.DescriptionsScore>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HumeAI.SentimentScore>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HumeAI.ToxicityScore>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HumeAI.SourceFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HumeAI.InferencePrediction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HumeAI.InferenceError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HumeAI.GroupedFacePredictions>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HumeAI.GroupedProsodyPredictions>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HumeAI.GroupedLanguagePredictions>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HumeAI.GroupedBurstPredictions>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HumeAI.GroupedNerPredictions>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HumeAI.FacePrediction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HumeAI.ProsodyPrediction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HumeAI.LanguagePrediction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HumeAI.BurstPrediction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HumeAI.NerPrediction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HumeAI.PostedUtterance>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HumeAI.ReturnGeneration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HumeAI.Snippet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HumeAI.ReturnVoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HumeAI.PostedUserDefinedToolSpec>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HumeAI.PostedBuiltinTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HumeAI.ReturnToolItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HumeAI.ReturnBuiltinTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HumeAI.ReturnConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HumeAI.ReturnPrompt>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HumeAI.ReturnUserDefinedTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HumeAI.ReturnChat>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HumeAI.ReturnChatEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HumeAI.ReturnChatGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HumeAI.ReturnChatAudioReconstruction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HumeAI.InferenceJob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HumeAI.InferenceSourcePredictResult>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}