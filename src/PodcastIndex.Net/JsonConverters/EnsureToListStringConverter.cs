using System;
using System.Collections.Generic;

namespace PodcastIndex.Net.JsonConverters;

public class EnsureToListStringConverter : JsonConverter<IReadOnlyList<string>>
{
    public override IReadOnlyList<string> Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        List<string> list = new();
        if (reader.TokenType == JsonTokenType.String)
        {
            var str = reader.GetString();

            if (str is null)
                return list;

            list.Add(str);

            return list.AsReadOnly();
        }

        if (reader.TokenType == JsonTokenType.StartArray)
            while (reader.Read())
            {
                if (reader.TokenType == JsonTokenType.EndArray)
                    return list.AsReadOnly();

                var str = reader.GetString();
                if (str is null)
                    continue;
                list.Add(str);
            }

        throw new JsonException("JSON token is neither of type string nor array");
    }

    public override void Write(
        Utf8JsonWriter writer,
        IReadOnlyList<string> value,
        JsonSerializerOptions options
    )
    {
        throw new NotImplementedException();
    }
}