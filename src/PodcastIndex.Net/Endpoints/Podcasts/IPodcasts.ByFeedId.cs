using PodcastIndex.Net.Contracts;
using PodcastIndex.Net.Contracts.Requests.Podcasts;
using PodcastIndex.Net.Contracts.Responses.Podcasts;

namespace PodcastIndex.Net.Endpoints.Podcasts;

public partial interface IPodcasts
{
    /// <summary>
    ///     This call returns everything we know about the feed from the PodcastIndex ID.
    ///     <para>
    ///         <see href="https://podcastindex-org.github.io/docs-api/#get-/podcasts/byfeedid">
    ///             See docs on
    ///             podcastindex-org.github.io
    ///         </see>
    ///     </para>
    ///     Examples:
    ///     <br />
    ///     - https://api.podcastindex.org/api/1.0/podcasts/byfeedid?id=75075&amp;pretty
    ///     <br />
    ///     - Includes `value` and `funding`: https://api.podcastindex.org/api/1.0/podcasts/byfeedid?id=169991&amp;pretty
    /// </summary>
    /// <param name="id">
    ///     The PodcastIndex Feed ID.
    ///     <br />
    ///     Examples: 75075
    /// </param>
    /// <param name="requestParams">Optional parameter.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    [Get(ApiRoutes.PodcastsRoutes.GetByFeedId)]
    Task<IApiResponse<PodcastsByFeedIdResponse>> GetByFeedIdAsync(int id,
        PodcastsByFeedIdRequest? requestParams = null,
        CancellationToken cancellationToken = default);
}