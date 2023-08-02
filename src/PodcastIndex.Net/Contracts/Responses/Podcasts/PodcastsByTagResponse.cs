using System.Net;
using PodcastIndex.Net.Contracts.Enums;
using PodcastIndex.Net.JsonConverters;

namespace PodcastIndex.Net.Contracts.Responses.Podcasts;

public record PodcastsByTagResponse(
    [property: JsonConverter(typeof(JsonStringEnumConverter))]
    Status Status,
    IReadOnlyList<PodcastsByTagFeed> Feeds,
    int? Count,
    string Description
);

public record PodcastsByTagFeed(
    long? Id,
    string PodcastGuid,
    string Title,
    [property: JsonConverter(typeof(EnsureNullIfEmptyUriPathConverter))]
    Uri? Url,
    [property: JsonConverter(typeof(EnsureNullIfEmptyUriPathConverter))]
    Uri? OriginalUrl,
    [property: JsonConverter(typeof(EnsureNullIfEmptyUriPathConverter))]
    Uri? Link,
    string Description,
    string Author,
    string OwnerName,
    [property: JsonConverter(typeof(EnsureNullIfEmptyUriPathConverter))]
    Uri? Image,
    [property: JsonConverter(typeof(EnsureNullIfEmptyUriPathConverter))]
    Uri? Artwork,
    [property: JsonConverter(typeof(UnixTimestampConverter))]
    DateTime? LastUpdateTime,
    [property: JsonConverter(typeof(UnixTimestampConverter))]
    DateTime? LastCrawlTime,
    [property: JsonConverter(typeof(UnixTimestampConverter))]
    DateTime? LastParseTime,
    [property: JsonConverter(typeof(UnixTimestampConverter))]
    DateTime? LastGoodHttpStatusTime,
    HttpStatusCode? LastHttpStatus,
    string ContentType,
    int? ItunesId,
    string Generator,
    string Language,
    SourceFeedType? Type,
    int? Dead,
    int? CrawlErrors,
    int? ParseErrors,
    IReadOnlyDictionary<int, string> Categories,
    FeedLocked? Locked,
    int? ImageUrlHash,
    Value4Value Value,
    Funding Funding,
    [property: JsonConverter(typeof(UnixTimestampConverter))]
    DateTime? ValueCreatedOn
);