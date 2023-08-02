using PodcastIndex.Net.Contracts.Enums;

namespace PodcastIndex.Net.Contracts.Responses;

public record ModelV4V(
    [property: JsonConverter(typeof(JsonStringEnumConverter))]
    ModelType? Type,
    string Method,
    string Suggested
);