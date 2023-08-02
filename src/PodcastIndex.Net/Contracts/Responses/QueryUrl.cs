using PodcastIndex.Net.JsonConverters;

namespace PodcastIndex.Net.Contracts.Responses;

public record QueryUrl(
    [property: JsonConverter(typeof(EnsureNullIfEmptyUriPathConverter))]
    Uri? Url
);