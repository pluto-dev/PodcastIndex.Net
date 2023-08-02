using PodcastIndex.Net.Contracts.Enums;

namespace PodcastIndex.Net.Contracts.Responses.Podcasts;

public record PodcastsByFeedUrlResponse(
    [property: JsonConverter(typeof(JsonStringEnumConverter))]
    Status Status,
    QueryUrl Query,
    PodcastsFeed Feed,
    string Description
);