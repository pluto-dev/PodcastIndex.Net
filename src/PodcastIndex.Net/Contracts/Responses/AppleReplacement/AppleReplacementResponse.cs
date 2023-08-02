using PodcastIndex.Net.Contracts.Enums;

namespace PodcastIndex.Net.Contracts.Responses.AppleReplacement;

// TODO refactor this. Check urls and move types to folder
public record AppleReplacementResponse(
    int? ResultCount,
    IReadOnlyList<AppleReplacementItem> Results
);

public record AppleReplacementItem(
    string ArtistName,
    Uri? ArtworkUrl100,
    Uri? ArtworkUrl30,
    Uri? ArtworkUrl60,
    Uri? ArtworkUrl600,
    string CollectionCensoredName,
    [property: JsonConverter(typeof(JsonStringEnumConverter))]
    ItunesCollectionExplicitness CollectionExplicitness,
    int? CollectionHdPrice,
    long? CollectionId,
    string CollectionName,
    int? CollectionPrice,
    Uri? CollectionViewUrl,
    [property: JsonConverter(typeof(JsonStringEnumConverter))]
    ItunesContentAdvisoryRating ContentAdvisoryRating,
    string Country,
    string Currency,
    Uri? FeedUrl,
    IReadOnlyList<int?> GenreIds,
    IReadOnlyList<string> Genres,
    string Kind,
    string PrimaryGenreName,
    string ReleaseDate,
    string TrackCensoredName,
    int? TrackCount,
    [property: JsonConverter(typeof(JsonStringEnumConverter))]
    ItunesTrackExplicitness TrackExplicitness,
    int? TrackHdPrice,
    int? TrackHdRentalPrice,
    long? TrackId,
    string TrackName,
    int? TrackPrice,
    int? TrackRentalPrice,
    Uri? TrackViewUrl,
    string WrapperType
);