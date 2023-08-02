using PodcastIndex.Net.Contracts.Enums;

namespace PodcastIndex.Net.Contracts.Responses.Value;

public record ValueByFeedUrlResponse(
    [property: JsonConverter(typeof(JsonStringEnumConverter))]
    Status Status,
    QueryUrl Query,
    Value4Value Value,
    string Description
);