using PodcastIndex.Net.Contracts.Enums;
using PodcastIndex.Net.JsonConverters;

namespace PodcastIndex.Net.Contracts.Responses;

public record DestinationV4V(
    string Name,
    [property: JsonConverter(typeof(EnsureNullIfEmptyUriPathConverter))]
    Uri? Address,
    [property: JsonConverter(typeof(JsonStringEnumConverter))]
    DestinationType? Type,
    int? Split,
    bool? Fee,
    string CustomKey,
    string CustomValue
);