using System;

namespace PodcastIndex.Net.JsonConverters;

public class EnsureNullIfEmptyUriPathConverter : JsonConverter<Uri>
{
    public override Uri? Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        if (reader.TokenType != JsonTokenType.String)
            return null;
        var urlString = reader.GetString();
        if (string.IsNullOrEmpty(urlString))
            return null;

        return !Uri.TryCreate(urlString, UriKind.Absolute, out var result) ? null : result;
    }

    public override void Write(Utf8JsonWriter writer, Uri value, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }
}