using PodcastIndex.Net.Contracts.Enums;

namespace PodcastIndex.Net.Contracts.Responses.Podcasts;

public record PodcastsByFeedIdResponse(
    [property: JsonConverter(typeof(JsonStringEnumConverter))]
    Status Status,
    QueryId Query,
    PodcastsFeed Feed,
    string Description
);