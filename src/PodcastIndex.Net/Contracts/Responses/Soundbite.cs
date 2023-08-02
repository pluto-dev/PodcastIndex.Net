using PodcastIndex.Net.JsonConverters;

namespace PodcastIndex.Net.Contracts.Responses;

public record Soundbite(
    [property: JsonConverter(typeof(UnixTimestampConverter))]
    DateTime? StartTime,
    int? Duration,
    string Title
);