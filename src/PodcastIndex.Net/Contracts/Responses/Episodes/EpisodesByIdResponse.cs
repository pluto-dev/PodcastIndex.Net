using PodcastIndex.Net.Contracts.Enums;
using PodcastIndex.Net.JsonConverters;

namespace PodcastIndex.Net.Contracts.Responses.Episodes;

public record EpisodesByIdResponse(
    [property: JsonConverter(typeof(JsonStringEnumConverter))]
    Status Status,
    [property: JsonConverter(typeof(EnsureToIntConverter))]
    int? Id,
    EpisodesEpisodeItem? Episode,
    string Description
);