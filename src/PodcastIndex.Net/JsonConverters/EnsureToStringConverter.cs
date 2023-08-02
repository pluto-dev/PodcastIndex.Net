using System;

namespace PodcastIndex.Net.JsonConverters;

public class EnsureToStringConverter : JsonConverter<string>
{
    public override string? Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        if (reader.TokenType == JsonTokenType.Number) return reader.GetInt32().ToString();

        if (reader.TokenType == JsonTokenType.String)
            return reader.GetString();

        throw new JsonException(
            $"Token type is of type {reader.TokenType}. Open a new issue to fix this error."
        );
    }

    public override void Write(Utf8JsonWriter writer, string value, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }
}