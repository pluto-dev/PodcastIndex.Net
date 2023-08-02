using PodcastIndex.Net.Contracts.Enums;
using PodcastIndex.Net.JsonConverters;

namespace PodcastIndex.Net.Contracts.Responses.Podcasts;

public record PodcastsTrendingResponse(
    [property: JsonConverter(typeof(JsonStringEnumConverter))]
    Status Status,
    IReadOnlyList<PodcastsTrendingFeed> Feeds,
    int? Count,
    int? Max,
    [property: JsonConverter(typeof(UnixTimestampConverter))]
    DateTime? Since,
    string Description
);

public record PodcastsTrendingFeed(
    long? Id,
    [property: JsonConverter(typeof(EnsureNullIfEmptyUriPathConverter))]
    Uri? Url,
    string Title,
    string Description,
    string Author,
    [property: JsonConverter(typeof(EnsureNullIfEmptyUriPathConverter))]
    Uri? Image,
    [property: JsonConverter(typeof(EnsureNullIfEmptyUriPathConverter))]
    Uri? Artwork,
    [property: JsonConverter(typeof(UnixTimestampConverter))]
    DateTime? NewestItemPublishTime,
    int? ItunesId,
    int? TrendScore,
    string Language,
    IReadOnlyDictionary<int, string> Categories
);