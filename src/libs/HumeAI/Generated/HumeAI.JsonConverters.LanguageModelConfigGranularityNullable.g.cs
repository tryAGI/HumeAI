#nullable enable

namespace HumeAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class LanguageModelConfigGranularityNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::HumeAI.LanguageModelConfigGranularity?>
    {
        /// <inheritdoc />
        public override global::HumeAI.LanguageModelConfigGranularity? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::HumeAI.LanguageModelConfigGranularityExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::HumeAI.LanguageModelConfigGranularity)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::HumeAI.LanguageModelConfigGranularity?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::HumeAI.LanguageModelConfigGranularity? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::HumeAI.LanguageModelConfigGranularityExtensions.ToValueString(value.Value));
            }
        }
    }
}
