using PodcastIndex.Net.Contracts.Enums;

namespace PodcastIndex.Net.Contracts.Responses.Value;

public record ValueByFeedIdResponse(
    [property: JsonConverter(typeof(JsonStringEnumConverter))]
    Status Status,
    QueryId Query,
    Value4Value Value,
    string Description
);