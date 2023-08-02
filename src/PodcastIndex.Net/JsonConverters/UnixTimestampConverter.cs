using System;

namespace PodcastIndex.Net.JsonConverters;

public class UnixTimestampConverter : JsonConverter<DateTime>
{
    public override DateTime Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return DateTimeOffset.FromUnixTimeSeconds(reader.GetInt32()).LocalDateTime;
    }

    public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }
}