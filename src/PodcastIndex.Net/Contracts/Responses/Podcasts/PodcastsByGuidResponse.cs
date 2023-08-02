using PodcastIndex.Net.Contracts.Enums;
using PodcastIndex.Net.JsonConverters;

namespace PodcastIndex.Net.Contracts.Responses.Podcasts;

public record PodcastsByGuidResponse(
    [property: JsonConverter(typeof(JsonStringEnumConverter))]
    Status Status,
    PodcastsByGuidQuery Query,
    PodcastsFeed Feed,
    string Description
);

public record PodcastsByGuidQuery(
    string Guid,
    // The schema says the id property is of type string.
    [property: JsonConverter(typeof(EnsureToStringConverter))]
    string Id
);