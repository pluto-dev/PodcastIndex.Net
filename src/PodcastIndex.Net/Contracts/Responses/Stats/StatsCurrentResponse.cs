using PodcastIndex.Net.Contracts.Enums;

namespace PodcastIndex.Net.Contracts.Responses.Stats;

public record StatsCurrentResponse(
    [property: JsonConverter(typeof(JsonStringEnumConverter))]
    Status Status,
    Stats Stats,
    string Description
);

public record Stats(
    int? FeedCountTotal,
    int? EpisodeCountTotal,
    int? FeedsWithNewEpisodes3days,
    int? FeedsWithNewEpisodes10days,
    int? FeedsWithNewEpisodes30days,
    int? FeedsWithNewEpisodes90days,
    int? FeedsWithValueBlocks
);