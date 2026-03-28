#nullable enable

namespace HumeAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class ReturnVoiceProviderNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::HumeAI.ReturnVoiceProvider?>
    {
        /// <inheritdoc />
        public override global::HumeAI.ReturnVoiceProvider? Read(
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
                        return global::HumeAI.ReturnVoiceProviderExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::HumeAI.ReturnVoiceProvider)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::HumeAI.ReturnVoiceProvider?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::HumeAI.ReturnVoiceProvider? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::HumeAI.ReturnVoiceProviderExtensions.ToValueString(value.Value));
            }
        }
    }
}
