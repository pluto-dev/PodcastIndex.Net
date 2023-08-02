using PodcastIndex.Net.Contracts.Enums;
using PodcastIndex.Net.JsonConverters;

namespace PodcastIndex.Net.Contracts.Responses.Episodes;

public record EpisodesByFeedIdResponse(
    [property: JsonConverter(typeof(JsonStringEnumConverter))]
    Status Status,
    IReadOnlyList<EpisodesByFeedIdLiveItem> LiveItems,
    IReadOnlyList<EpisodesItem> Items,
    int? Count,
    [property: JsonConverter(typeof(EnsureToListStringConverter))]
    IReadOnlyList<string> Query,
    string Description
);

public record EpisodesByFeedIdLiveItem(
    long? Id,
    string Title,
    [property: JsonConverter(typeof(EnsureNullIfEmptyUriPathConverter))]
    Uri? Link,
    string Description,
    string Guid,
    [property: JsonConverter(typeof(UnixTimestampConverter))]
    DateTime? DatePublished,
    string DatePublishedPretty,
    [property: JsonConverter(typeof(UnixTimestampConverter))]
    DateTime? DateCrawled,
    [property: JsonConverter(typeof(EnsureNullIfEmptyUriPathConverter))]
    Uri? EnclosureUrl,
    string EnclosureType,
    int? EnclosureLength,
    [property: JsonConverter(typeof(UnixTimestampConverter))]
    DateTime? StartTime,
    [property: JsonConverter(typeof(UnixTimestampConverter))]
    DateTime? EndTime,
    [property: JsonConverter(typeof(JsonStringEnumConverter))]
    LiveStatus? Status,
    [property: JsonConverter(typeof(EnsureNullIfEmptyUriPathConverter))]
    Uri? ContentLink,
    int? Duration,
    Explicit? Explicit,
    int? Episode,
    [property: JsonConverter(typeof(JsonStringEnumConverter))]
    EpisodeType? EpisodeType,
    int? Season,
    [property: JsonConverter(typeof(EnsureNullIfEmptyUriPathConverter))]
    Uri? Image,
    int? FeedItunesId,
    [property: JsonConverter(typeof(EnsureNullIfEmptyUriPathConverter))]
    Uri? FeedImage,
    int? FeedId,
    string FeedLanguage,
    int? FeedDead,
    int? FeedDuplicateOf,
    [property: JsonConverter(typeof(EnsureNullIfEmptyUriPathConverter))]
    Uri? ChaptersUrl,
    [property: JsonConverter(typeof(EnsureNullIfEmptyUriPathConverter))]
    Uri? TranscriptUrl
);