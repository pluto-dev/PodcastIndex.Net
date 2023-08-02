using PodcastIndex.Net.Contracts.Enums;
using PodcastIndex.Net.JsonConverters;

namespace PodcastIndex.Net.Contracts.Responses.Recent;

public record RecentFeedsResponse(
    [property: JsonConverter(typeof(JsonStringEnumConverter))]
    Status Status,
    IReadOnlyList<RecentFeed> Feeds,
    int? Count,
    [property: JsonConverter(typeof(EnsureToIntConverter))]
    int? Max,
    long? Since,
    string Description
);

public record RecentFeed(
    long? Id,
    [property: JsonConverter(typeof(EnsureNullIfEmptyUriPathConverter))]
    Uri? Url,
    string Title,
    [property: JsonConverter(typeof(UnixTimestampConverter))]
    DateTime? NewestItemPublishTime,
    [property: JsonConverter(typeof(UnixTimestampConverter))]
    DateTime? OldestItemPublishTime,
    int? ItunesId,
    string Language,
    IReadOnlyDictionary<int, string> Categories
);