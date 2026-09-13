
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
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.PostedUtteranceVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.PostedUtteranceVoiceProvider), TypeInfoPropertyName = "PostedUtteranceVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.ReturnVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.ReturnVoiceProvider), TypeInfoPropertyName = "ReturnVoiceProvider2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.PostedUtteranceVoiceProvider?), TypeInfoPropertyName = "NullablePostedUtteranceVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.ReturnVoiceProvider?), TypeInfoPropertyName = "NullableReturnVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.PostedLanguageModelModelProvider?), TypeInfoPropertyName = "NullablePostedLanguageModelModelProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.PostedBuiltinToolName?), TypeInfoPropertyName = "NullablePostedBuiltinToolName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HumeAI.ReturnToolItemToolType?), TypeInfoPropertyName = "NullableReturnToolItemToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HumeAI.PostedUserDefinedToolSpec>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HumeAI.PostedBuiltinTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HumeAI.ReturnToolItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HumeAI.ReturnBuiltinTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HumeAI.ReturnConfig>))]
    internal sealed partial class ConfigsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ConfigsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ConfigsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ConfigsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::HumeAI.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::HumeAI.PostedUtteranceVoiceProvider)

                    || typeToConvert == typeof(global::HumeAI.PostedUtteranceVoiceProvider?)

                    || typeToConvert == typeof(global::HumeAI.ReturnVoiceProvider)

                    || typeToConvert == typeof(global::HumeAI.ReturnVoiceProvider?)

                    || typeToConvert == typeof(global::HumeAI.PostedLanguageModelModelProvider)

                    || typeToConvert == typeof(global::HumeAI.PostedLanguageModelModelProvider?)

                    || typeToConvert == typeof(global::HumeAI.PostedBuiltinToolName)

                    || typeToConvert == typeof(global::HumeAI.PostedBuiltinToolName?)

                    || typeToConvert == typeof(global::HumeAI.ReturnToolItemToolType)

                    || typeToConvert == typeof(global::HumeAI.ReturnToolItemToolType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::HumeAI.PostedUtteranceVoiceProvider))
                {
                    return new global::HumeAI.JsonConverters.PostedUtteranceVoiceProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::HumeAI.PostedUtteranceVoiceProvider?))
                {
                    return new global::HumeAI.JsonConverters.PostedUtteranceVoiceProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HumeAI.ReturnVoiceProvider))
                {
                    return new global::HumeAI.JsonConverters.ReturnVoiceProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::HumeAI.ReturnVoiceProvider?))
                {
                    return new global::HumeAI.JsonConverters.ReturnVoiceProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HumeAI.PostedLanguageModelModelProvider))
                {
                    return new global::HumeAI.JsonConverters.PostedLanguageModelModelProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::HumeAI.PostedLanguageModelModelProvider?))
                {
                    return new global::HumeAI.JsonConverters.PostedLanguageModelModelProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HumeAI.PostedBuiltinToolName))
                {
                    return new global::HumeAI.JsonConverters.PostedBuiltinToolNameJsonConverter();
                }

                if (typeToConvert == typeof(global::HumeAI.PostedBuiltinToolName?))
                {
                    return new global::HumeAI.JsonConverters.PostedBuiltinToolNameNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HumeAI.ReturnToolItemToolType))
                {
                    return new global::HumeAI.JsonConverters.ReturnToolItemToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::HumeAI.ReturnToolItemToolType?))
                {
                    return new global::HumeAI.JsonConverters.ReturnToolItemToolTypeNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new ConfigsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}