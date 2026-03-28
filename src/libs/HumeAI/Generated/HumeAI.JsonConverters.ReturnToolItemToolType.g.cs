#nullable enable

namespace HumeAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class ReturnToolItemToolTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::HumeAI.ReturnToolItemToolType>
    {
        /// <inheritdoc />
        public override global::HumeAI.ReturnToolItemToolType Read(
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
                        return global::HumeAI.ReturnToolItemToolTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::HumeAI.ReturnToolItemToolType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::HumeAI.ReturnToolItemToolType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::HumeAI.ReturnToolItemToolType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::HumeAI.ReturnToolItemToolTypeExtensions.ToValueString(value));
        }
    }
}
