using PodcastIndex.Net.Contracts.Enums;

namespace PodcastIndex.Net.Contracts.Responses.Recent;

public record RecentNewValueFeedsResponse(
    [property: JsonConverter(typeof(JsonStringEnumConverter))]
    Status Status,
    IReadOnlyList<RecentNewValueFeed> Feeds,
    int? Count,
    int? Max,
    int? Since,
    string Description
);

public record RecentNewValueFeed(
    int? Id,
    Uri? Url,
    string Title,
    string Author,
    Uri? Image,
    int? NewestItemPublishTime,
    int? ItunesId,
    int? TrendScore,
    string Language,
    IReadOnlyDictionary<int, string> Categories
);