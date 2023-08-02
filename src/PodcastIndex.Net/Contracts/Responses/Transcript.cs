using PodcastIndex.Net.Contracts.Enums;
using PodcastIndex.Net.JsonConverters;

namespace PodcastIndex.Net.Contracts.Responses;

public record Transcript(
    [property: JsonConverter(typeof(EnsureNullIfEmptyUriPathConverter))]
    Uri? Url,
    [property: JsonConverter(typeof(JsonStringToEnumConverter<TranscriptType>))]
    TranscriptType? Type
);