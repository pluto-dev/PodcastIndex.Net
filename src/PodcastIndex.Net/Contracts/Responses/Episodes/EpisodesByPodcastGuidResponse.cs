using PodcastIndex.Net.Contracts.Enums;

namespace PodcastIndex.Net.Contracts.Responses.Episodes;

public record EpisodesByPodcastGuidResponse(
    [property: JsonConverter(typeof(JsonStringEnumConverter))]
    Status Status,
    IReadOnlyList<EpisodesItem> Items,
    int? Count,
    // The schema says it's an URL but we get back an int
    // int? Query,
    string Description
);