#nullable enable

namespace HumeAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class ListBatchJobsStatusJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::HumeAI.ListBatchJobsStatus>
    {
        /// <inheritdoc />
        public override global::HumeAI.ListBatchJobsStatus Read(
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
                        return global::HumeAI.ListBatchJobsStatusExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::HumeAI.ListBatchJobsStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::HumeAI.ListBatchJobsStatus);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::HumeAI.ListBatchJobsStatus value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::HumeAI.ListBatchJobsStatusExtensions.ToValueString(value));
        }
    }
}
