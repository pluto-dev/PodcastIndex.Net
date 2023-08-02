using PodcastIndex.Net.Contracts.Enums;
using PodcastIndex.Net.JsonConverters;

namespace PodcastIndex.Net.Contracts.Responses.Episodes;

public record EpisodesEpisodeItem(
    long? Id,
    string Title,
    [property: JsonConverter(typeof(EnsureNullIfEmptyUriPathConverter))]
    Uri? Link,
    string Description,
    string Guid,
    [property: JsonConverter(typeof(UnixTimestampConverter))]
    DateTime? DatePublished,
    string DatePublishedPretty,
    [property: JsonConverter(typeof(UnixTimestampConverter))]
    DateTime? DateCrawled,
    [property: JsonConverter(typeof(EnsureNullIfEmptyUriPathConverter))]
    Uri? EnclosureUrl,
    string EnclosureType,
    int? EnclosureLength,
    int? Duration,
    Explicit? Explicit,
    int? Episode,
    [property: JsonConverter(typeof(JsonStringEnumConverter))]
    EpisodeType? EpisodeType,
    int? Season,
    [property: JsonConverter(typeof(EnsureNullIfEmptyUriPathConverter))]
    Uri? Image,
    int? FeedItunesId,
    [property: JsonConverter(typeof(EnsureNullIfEmptyUriPathConverter))]
    Uri? FeedImage,
    int? FeedId,
    string FeedTitle,
    string FeedLanguage,
    [property: JsonConverter(typeof(EnsureNullIfEmptyUriPathConverter))]
    Uri? ChaptersUrl,
    IReadOnlyList<Transcript> Transcripts,
    IReadOnlyList<Person> Persons,
    IReadOnlyList<SocialInteract> SocialInteract,
    Value4Value Value,
    Soundbite Soundbite,
    IReadOnlyList<Soundbite> Soundbites
);