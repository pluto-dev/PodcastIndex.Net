using PodcastIndex.Net.Contracts.Enums;

namespace PodcastIndex.Net.Contracts.Responses.Hub;

public record HubPubNotifyResponse(
    [property: JsonConverter(typeof(JsonStringEnumConverter))]
    Status Status,
    string Description
);