using PodcastIndex.Net.Contracts.Enums;
using PodcastIndex.Net.JsonConverters;

namespace PodcastIndex.Net.Contracts.Responses.Episodes;

public record EpisodesByItunesIdResponse(
    [property: JsonConverter(typeof(JsonStringEnumConverter))]
    Status Status,
    IReadOnlyList<EpisodesItem>? Items,
    int? Count,
    [property: JsonConverter(typeof(EnsureToStringConverter))]
    string Query,
    string Description
);