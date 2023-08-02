using PodcastIndex.Net.Contracts.Enums;

namespace PodcastIndex.Net.Contracts.Responses.Episodes;

public record EpisodesByFeedUrlResponse(
    [property: JsonConverter(typeof(JsonStringEnumConverter))]
    Status Status,
    IReadOnlyList<EpisodesItem> Items,
    int? Count,
    QueryUrl Query,
    string Description
);