using PodcastIndex.Net.Contracts;
using PodcastIndex.Net.Contracts.Requests.Recent;
using PodcastIndex.Net.Contracts.Responses.Recent;

namespace PodcastIndex.Net.Endpoints.Recent;

public partial interface IRecent
{
    /// <summary>
    ///     This call returns the most recent max number of episodes globally across the whole index, in reverse chronological
    ///     order.
    ///     <para>
    ///         <see href="https://podcastindex-org.github.io/docs-api/#get-/recent/episodes">
    ///             See docs on
    ///             podcastindex-org.github.io
    ///         </see>
    ///     </para>
    ///     Example: https://api.podcastindex.org/api/1.0/recent/episodes?max=7&amp;pretty
    /// </summary>
    /// <param name="requestParams">Optional parameter.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    [Get(ApiRoutes.RecentRoutes.GetEpisodes)]
    Task<IApiResponse<RecentEpisodesResponse>> GetEpisodesAsync(
        RecentEpisodesRequest? requestParams = null,
        CancellationToken cancellationToken = default
    );
}