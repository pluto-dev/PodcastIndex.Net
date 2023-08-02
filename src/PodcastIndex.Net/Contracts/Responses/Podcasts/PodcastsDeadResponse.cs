using PodcastIndex.Net.Contracts.Enums;
using PodcastIndex.Net.JsonConverters;

namespace PodcastIndex.Net.Contracts.Responses.Podcasts;

public record PodcastsDeadResponse(
    [property: JsonConverter(typeof(JsonStringEnumConverter))]
    Status Status,
    IReadOnlyList<PodcastsDeadFeed> Feeds,
    int? Count,
    string Description
);

public record PodcastsDeadFeed(
    long? Id,
    string Title,
    [property: JsonConverter(typeof(EnsureNullIfEmptyUriPathConverter))]
    Uri? Url,
    int? DuplicateOf
);