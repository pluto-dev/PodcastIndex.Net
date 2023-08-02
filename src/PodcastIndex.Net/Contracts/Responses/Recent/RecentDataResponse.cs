using PodcastIndex.Net.Contracts.Enums;
using PodcastIndex.Net.JsonConverters;

namespace PodcastIndex.Net.Contracts.Responses.Recent;

public record RecentDataResponse(
    [property: JsonConverter(typeof(JsonStringEnumConverter))]
    Status Status,
    int? FeedCount,
    int? ItemCount,
    [property: JsonConverter(typeof(EnsureToIntConverter))]
    int? Max,
    long? Since,
    string Description,
    int? NextSince,
    RecentData Data
);

public record RecentData(
    long? Position,
    IReadOnlyList<RecentDataFeed> Feeds,
    IReadOnlyList<RecentDataEpisode> Items
);

public record RecentDataFeed(
    int? FeedId,
    [property: JsonConverter(typeof(EnsureNullIfEmptyUriPathConverter))]
    Uri? FeedUrl,
    string FeedTitle,
    string FeedDescription,
    [property: JsonConverter(typeof(EnsureNullIfEmptyUriPathConverter))]
    Uri? FeedImage,
    string FeedLanguage,
    int? FeedItunesId
);

public record RecentDataEpisode(
    long? EpisodeId,
    string EpisodeTitle,
    string EpisodeDescription,
    [property: JsonConverter(typeof(EnsureNullIfEmptyUriPathConverter))]
    Uri? EpisodeImage,
    [property: JsonConverter(typeof(UnixTimestampConverter))]
    DateTime? EpisodeTimestamp,
    int? EpisodeAdded,
    [property: JsonConverter(typeof(EnsureNullIfEmptyUriPathConverter))]
    Uri? EpisodeEnclosureUrl,
    int? EpisodeEnclosureLength,
    string EpisodeEnclosureType,
    int? EpisodeDuration,
    [property: JsonConverter(typeof(JsonStringEnumConverter))]
    EpisodeType? EpisodeType,
    int? FeedId
);