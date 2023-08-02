using PodcastIndex.Net.Contracts;
using PodcastIndex.Net.Contracts.Requests.Categories;
using PodcastIndex.Net.Contracts.Responses.Categories;

namespace PodcastIndex.Net.Endpoints.Categories;

public partial interface ICategories
{
    /// <summary>
    ///     Return all the possible categories supported by the index.
    ///     <para>
    ///         <see href="https://podcastindex-org.github.io/docs-api/#get-/categories/list">
    ///             See docs on
    ///             podcastindex-org.github.io
    ///         </see>
    ///     </para>
    ///     Example: https://api.podcastindex.org/api/1.0/categories/list?pretty
    /// </summary>
    /// <param name="requestParams">Optional parameter.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    [Get(ApiRoutes.CategoriesRoutes.GetList)]
    Task<IApiResponse<CategoriesListResponse>> GetListAsync(
        CategoriesListRequest? requestParams = null,
        CancellationToken cancellationToken = default
    );
}