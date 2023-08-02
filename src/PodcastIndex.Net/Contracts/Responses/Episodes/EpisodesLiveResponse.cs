using PodcastIndex.Net.Contracts.Enums;
using PodcastIndex.Net.JsonConverters;

namespace PodcastIndex.Net.Contracts.Responses.Episodes;

public record EpisodesLiveResponse(
    [property: JsonConverter(typeof(JsonStringEnumConverter))]
    Status Status,
    IReadOnlyList<EpisodesLiveItem> Items,
    int? Count,
    // the schema is saying that max is of type integer, but it also can be of type string, so we make it's of type int
    [property: JsonConverter(typeof(EnsureToIntConverter))]
    int? Max,
    string Description
);

public record EpisodesLiveItem(
    long? Id,
    string Title,
    [property: JsonConverter(typeof(EnsureNullIfEmptyUriPathConverter))]
    Uri? Link,
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
    Explicit? Explicit,
    [property: JsonConverter(typeof(EnsureNullIfEmptyUriPathConverter))]
    Uri? Image,
    int? FeedItunesId,
    [property: JsonConverter(typeof(EnsureNullIfEmptyUriPathConverter))]
    Uri? FeedImage,
    int? FeedId,
    string FeedTitle,
    string FeedLanguage,
    IReadOnlyDictionary<int, string> Categories
);