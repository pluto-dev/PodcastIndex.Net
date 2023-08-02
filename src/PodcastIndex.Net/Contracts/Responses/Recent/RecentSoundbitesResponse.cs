using PodcastIndex.Net.Contracts.Enums;
using PodcastIndex.Net.JsonConverters;

namespace PodcastIndex.Net.Contracts.Responses.Recent;

public record RecentSoundbitesResponse(
    [property: JsonConverter(typeof(JsonStringEnumConverter))]
    Status Status,
    IReadOnlyList<RecentSoundbite> Items,
    int? Count,
    string Description
);

public record RecentSoundbite(
    [property: JsonConverter(typeof(EnsureNullIfEmptyUriPathConverter))]
    Uri? EnclosureUrl,
    string Title,
    [property: JsonConverter(typeof(UnixTimestampConverter))]
    DateTime? StartTime,
    int? Duration,
    long? EpisodeId,
    string EpisodeTitle,
    string FeedTitle,
    [property: JsonConverter(typeof(EnsureNullIfEmptyUriPathConverter))]
    Uri? FeedUrl,
    int? FeedId
);