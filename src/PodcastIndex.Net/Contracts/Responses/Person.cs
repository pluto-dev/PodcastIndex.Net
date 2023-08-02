using PodcastIndex.Net.JsonConverters;

namespace PodcastIndex.Net.Contracts.Responses;

public record Person(
    long? Id,
    string Name,
    string Role,
    string Group,
    [property: JsonConverter(typeof(EnsureNullIfEmptyUriPathConverter))]
    Uri? Href,
    [property: JsonConverter(typeof(EnsureNullIfEmptyUriPathConverter))]
    Uri? Img
);