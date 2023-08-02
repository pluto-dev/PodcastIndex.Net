namespace PodcastIndex.Net.JsonConverters;

public class EnsureToIntConverter : JsonConverter<int?>
{
    public override int? Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        if (reader.TokenType == JsonTokenType.String)
        {
            var stringToken = reader.GetString();
            if (stringToken is null)
                return null;

            return int.Parse(stringToken);
        }

        if (reader.TokenType == JsonTokenType.Number)
            return reader.GetInt32();

        throw new JsonException(
            $"Token type is of type {reader.TokenType}. Open a new issue to fix this error."
        );
    }
    
    public override void Write(Utf8JsonWriter writer, int? value, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }
}
