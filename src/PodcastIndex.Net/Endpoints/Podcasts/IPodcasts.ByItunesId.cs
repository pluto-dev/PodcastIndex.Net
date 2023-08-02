using PodcastIndex.Net.Contracts;
using PodcastIndex.Net.Contracts.Requests.Podcasts;
using PodcastIndex.Net.Contracts.Responses.Podcasts;

namespace PodcastIndex.Net.Endpoints.Podcasts;

// https://podcastindex-org.github.io/docs-api/#get-/podcasts/byitunesid
public partial interface IPodcasts
{
    /// <summary>
    ///     This call returns everything we know about the feed from the iTunes ID
    ///     <para>
    ///         <see href="https://podcastindex-org.github.io/docs-api/#get-/podcasts/byitunesid">
    ///             See docs on
    ///             podcastindex-org.github.io
    ///         </see>
    ///     </para>
    ///     Example: https://api.podcastindex.org/api/1.0/podcasts/byitunesid?id=1441923632&amp;pretty
    /// </summary>
    /// <param name="id">
    ///     The iTunes Feed ID to search for
    ///     <para>
    ///         Examples: 1441923632
    ///     </para>
    /// </param>
    /// <param name="requestParams">Optional parameter.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    [Get(ApiRoutes.PodcastsRoutes.GetByItunesId)]
    Task<IApiResponse<PodcastsByItunesIdResponse>> GetByItunesIdAsync(
        int id,
        PodcastsByItunesIdRequest? requestParams = null,
        CancellationToken cancellationToken = default
    );
}