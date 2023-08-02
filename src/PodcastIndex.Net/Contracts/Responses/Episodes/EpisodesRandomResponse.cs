using PodcastIndex.Net.Contracts.Enums;
using PodcastIndex.Net.JsonConverters;

namespace PodcastIndex.Net.Contracts.Responses.Episodes;

public record EpisodesRandomResponse(
    [property: JsonConverter(typeof(JsonStringEnumConverter))]
    Status Status,
    IReadOnlyList<EpisodesEpisodeItem> Episodes,
    int? Count,
    // the schema is saying that max is of type integer, but it also can be of type string
    [property: JsonConverter(typeof(EnsureToIntConverter))]
    int? Max,
    string Description
);