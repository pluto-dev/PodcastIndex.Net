﻿using PodcastIndex.Net.Contracts.Enums;
using PodcastIndex.Net.JsonConverters;

namespace PodcastIndex.Net.Contracts.Responses.Search;

public record SearchByPersonResponse(
    [property: JsonConverter(typeof(JsonStringEnumConverter))]
    Status Status,
    IReadOnlyList<SearchByPersonItem> Items,
    int? Count,
    string Query,
    string Description
);

public record SearchByPersonItem(
    long? Id,
    string Title,
    [property: JsonConverter(typeof(EnsureNullIfEmptyUriPathConverter))]
    Uri? Link,
    string Description,
    string Guid,
    [property: JsonConverter(typeof(UnixTimestampConverter))]
    DateTime? DatePublished,
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
    [property: JsonConverter(typeof(EnsureNullIfEmptyUriPathConverter))]
    Uri? FeedUrl,
    string FeedAuthor,
    string FeedTitle,
    string FeedLanguage,
    [property: JsonConverter(typeof(EnsureNullIfEmptyUriPathConverter))]
    Uri? ChaptersUrl,
    IReadOnlyList<Transcript> Transcripts
);