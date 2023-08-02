using PodcastIndex.Net.Contracts;
using PodcastIndex.Net.Contracts.Requests.Search;
using PodcastIndex.Net.Contracts.Responses.Search;

namespace PodcastIndex.Net.Endpoints.Search;

public partial interface ISearch
{
    /// <summary>
    ///     This call returns all of the feeds that match the search terms in the `title`, `author` or `owner` of the
    ///     <feed></feed> where the
    ///     [medium](https://github.com/Podcastindex-org/podcast-namespace/blob/main/docs/1.0.md#medium) is `music`.
    ///     <para>
    ///         <see href="https://podcastindex-org.github.io/docs-api/#get-/search/music/byterm">
    ///             See docs on
    ///             podcastindex-org.github.io
    ///         </see>
    ///     </para>
    ///     Example: https://api.podcastindex.org/api/1.0/search/music/byterm?q=able+kirby&amp;pretty
    /// </summary>
    /// <param name="searchTerm">
    ///     Terms to search for.
    ///     <br />
    ///     Examples: batman university
    /// </param>
    /// <param name="requestParams">Optional parameter.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    [Get(ApiRoutes.SearchRoutes.GetMusicByTerm)]
    Task<IApiResponse<SearchResponse>> GetMusicByTermAsync(
        [AliasAs("q")] string searchTerm,
        SearchMusicByTermRequest? requestParams = null,
        CancellationToken cancellationToken = default
    );
}