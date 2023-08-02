using PodcastIndex.Net.Contracts.Enums;
using PodcastIndex.Net.JsonConverters;

namespace PodcastIndex.Net.Contracts.Responses.Recent;

public record RecentNewFeedsResponse(
    [property: JsonConverter(typeof(JsonStringEnumConverter))]
    Status Status,
    IReadOnlyList<RecentNewFeed> Feeds,
    int? Count,
    [property: JsonConverter(typeof(EnsureToIntConverter))]
    int? Max,
    string Description
);

public record RecentNewFeed(
    long? Id,
    [property: JsonConverter(typeof(EnsureNullIfEmptyUriPathConverter))]
    Uri? Url,
    [property: JsonConverter(typeof(EnsureNullIfEmptyUriPathConverter))]
    Uri? Image,
    [property: JsonConverter(typeof(UnixTimestampConverter))]
    DateTime? TimeAdded,
    [property: JsonConverter(typeof(JsonStringEnumConverter))]
    FeedStatus? Status,
    string ContentHash,
    string Language
);