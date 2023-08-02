using PodcastIndex.Net.Contracts;
using PodcastIndex.Net.Contracts.Requests.Search;
using PodcastIndex.Net.Contracts.Responses.Search;

namespace PodcastIndex.Net.Endpoints.Search;

public partial interface ISearch
{
    /// <summary>
    ///     This call returns all of the episodes where the specified person is mentioned.
    ///     <br />
    ///     It searches the following fields:
    ///     <br />
    ///     - Person tags
    ///     <br />
    ///     - Episode title
    ///     <br />
    ///     - Episode description
    ///     <br />
    ///     - Feed owner
    ///     <br />
    ///     - Feed author
    ///     <para>
    ///         <see href="https://podcastindex-org.github.io/docs-api/#get-/search/byperson">
    ///             See docs on
    ///             podcastindex-org.github.io
    ///         </see>
    ///     </para>
    ///     Examples:
    ///     <br />
    ///     - https://api.podcastindex.org/api/1.0/search/byperson?q=adam%20curry&amp;pretty
    ///     <br />
    ///     - https://api.podcastindex.org/api/1.0/search/byperson?q=Martin+Mouritzen&amp;pretty
    ///     <br />
    ///     - https://api.podcastindex.org/api/1.0/search/byperson?q=Klaus+Schwab&amp;pretty
    /// </summary>
    /// <param name="searchTerm">
    ///     Person to search for.
    ///     <br />
    ///     Examples: adam curry
    /// </param>
    /// <param name="requestParams">Optional parameter.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    [Get(ApiRoutes.SearchRoutes.GetByPerson)]
    Task<IApiResponse<SearchByPersonResponse>> GetByPersonAsync(
        [AliasAs("q")] string searchTerm,
        SearchByPersonRequest? requestParams = null,
        CancellationToken cancellationToken = default
    );
}