using PodcastIndex.Net.Contracts;
using PodcastIndex.Net.Contracts.Requests.Search;
using PodcastIndex.Net.Contracts.Responses.Search;

namespace PodcastIndex.Net.Endpoints.Search;

public partial interface ISearch
{
    /// <summary>
    ///     This call returns all of the feeds where the `title` of the feed matches the search term (ignores case).
    ///     <br />
    ///     Example "everything everywhere daily" will match the podcast [Everything Everywhere
    ///     Daily](https://podcastindex.org/podcast/437685) by "everything everywhere" will not.
    ///     <para>
    ///         <see href="https://podcastindex-org.github.io/docs-api/#get-/search/bytitle">
    ///             See docs on
    ///             podcastindex-org.github.io
    ///         </see>
    ///     </para>
    ///     Example: https://api.podcastindex.org/api/1.0/search/bytitle?q=everything+everywhere+daily&amp;pretty
    /// </summary>
    /// <param name="searchTerm">
    ///     Terms to search for.
    ///     <br />
    ///     Examples: batman university
    /// </param>
    /// <param name="requestParams">Optional parameter.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    [Get(ApiRoutes.SearchRoutes.GetByTitle)]
    Task<IApiResponse<SearchResponse>> GetByTitleAsync(
        [AliasAs("q")] string searchTerm,
        SearchByTitleRequest? requestParams = null,
        CancellationToken cancellationToken = default
    );
}