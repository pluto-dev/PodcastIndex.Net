using PodcastIndex.Net.Contracts;
using PodcastIndex.Net.Contracts.Requests.Podcasts;
using PodcastIndex.Net.Contracts.Responses.Podcasts;

namespace PodcastIndex.Net.Endpoints.Podcasts;

public partial interface IPodcasts
{
    /// <summary>
    ///     This call returns all feeds that have been marked dead (`dead` == 1)
    ///     <br />
    ///     Dead feeds can also be accessed from object storage at https://public.podcastindex.org/podcastindex_dead_feeds.csv
    ///     <para>
    ///         <see href="https://podcastindex-org.github.io/docs-api/#get-/podcasts/dead">
    ///             See docs on
    ///             podcastindex-org.github.io
    ///         </see>
    ///     </para>
    ///     Example: https://api.podcastindex.org/api/1.0/podcasts/dead?pretty
    /// </summary>
    /// <param name="requestParams">Optional parameter.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    [Get(ApiRoutes.PodcastsRoutes.GetDead)]
    Task<IApiResponse<PodcastsDeadResponse>> GetDeadAsync(
        PodcastsDeadRequest? requestParams = null,
        CancellationToken cancellationToken = default
    );
}