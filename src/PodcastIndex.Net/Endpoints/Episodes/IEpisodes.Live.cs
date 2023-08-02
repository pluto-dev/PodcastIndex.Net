using PodcastIndex.Net.Contracts;
using PodcastIndex.Net.Contracts.Requests.Episodes;
using PodcastIndex.Net.Contracts.Responses.Episodes;

namespace PodcastIndex.Net.Endpoints.Episodes;

public partial interface IEpisodes
{
    /// <summary>
    ///     Get all episodes that have been found in the
    ///     [podcast:liveitem](https://github.com/Podcastindex-org/podcast-namespace/blob/main/docs/1.0.md#live-item) from the
    ///     feeds.
    ///     <para>
    ///         <see href="https://podcastindex-org.github.io/docs-api/#get-/episodes/live">
    ///             See docs on
    ///             podcastindex-org.github.io
    ///         </see>
    ///     </para>
    ///     Examples:
    ///     <br />
    ///     - https://api.podcastindex.org/api/1.0/episodes/live?pretty
    /// </summary>
    /// <param name="requestParams">Optional parameter.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    [Get(ApiRoutes.EpisodesRoutes.GetLive)]
    Task<IApiResponse<EpisodesLiveResponse>> GetLiveAsync(
        EpisodesLiveRequest? requestParams = null,
        CancellationToken cancellationToken = default
    );
}