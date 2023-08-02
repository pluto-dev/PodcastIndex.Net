using PodcastIndex.Net.Contracts.Enums;

namespace PodcastIndex.Net.Contracts.Responses.Categories;

public record CategoriesListResponse(
    [property: JsonConverter(typeof(JsonStringEnumConverter))]
    Status Status,
    IReadOnlyList<CategoriesList> Feeds,
    int? Count,
    string Description
);

public record CategoriesList(long? Id, string Name);