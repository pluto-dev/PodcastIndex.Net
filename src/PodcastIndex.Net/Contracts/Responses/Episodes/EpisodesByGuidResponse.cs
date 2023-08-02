using PodcastIndex.Net.Contracts.Enums;
using PodcastIndex.Net.JsonConverters;

namespace PodcastIndex.Net.Contracts.Responses.Episodes;

public record EpisodesByGuidResponse(
    [property: JsonConverter(typeof(JsonStringEnumConverter))]
    Status Status,
    [property: JsonConverter(typeof(EnsureToStringConverter))]
    string Id,
    [property: JsonConverter(typeof(EnsureNullIfEmptyUriPathConverter))]
    Uri? Url,
    string Guid,
    EpisodesEpisodeItem Episode,
    string Description
);