using PodcastIndex.Net.Contracts.Enums;
using PodcastIndex.Net.JsonConverters;

namespace PodcastIndex.Net.Contracts.Responses.Episodes;

public record EpisodesItem(
    long? Id,
    string Title,
    Uri? Link,
    string Description,
    string Guid,
    [property: JsonConverter(typeof(UnixTimestampConverter))]
    DateTime? DatePublished,
    string DatePublishedPretty,
    [property: JsonConverter(typeof(UnixTimestampConverter))]
    DateTime? DateCrawled,
    Uri? EnclosureUrl,
    string EnclosureType,
    int? EnclosureLength,
    int? Duration,
    Explicit? Explicit,
    int? Episode,
    [property: JsonConverter(typeof(JsonStringEnumConverter))]
    EpisodeType? EpisodeType,
    int? Season,
    Uri? Image,
    int? FeedItunesId,
    Uri? FeedImage,
    int? FeedId,
    string FeedLanguage,
    int? FeedDead,
    int? FeedDuplicateOf,
    Uri? ChaptersUrl,
    Uri? TranscriptUrl,
    IReadOnlyList<Transcript> Transcripts,
    Soundbite Soundbite,
    IReadOnlyList<Soundbite> Soundbites,
    IReadOnlyList<Person> Persons,
    IReadOnlyList<SocialInteract> SocialInteract,
    Value4Value Value
);