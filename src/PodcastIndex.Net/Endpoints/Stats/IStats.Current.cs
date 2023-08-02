using PodcastIndex.Net.Contracts;
using PodcastIndex.Net.Contracts.Requests.Stats;
using PodcastIndex.Net.Contracts.Responses.Stats;

namespace PodcastIndex.Net.Endpoints.Stats;

public partial interface IStats
{
    /// <summary>
    ///     Return the most recent index statistics.
    ///     <br />
    ///     Hourly statistics can also be access at https://stats.podcastindex.org/daily_counts.json
    ///     <para>
    ///         <see href="https://podcastindex-org.github.io/docs-api/#get-/stats/current">
    ///             See docs on
    ///             podcastindex-org.github.io
    ///         </see>
    ///     </para>
    ///     Example: https://api.podcastindex.org/api/1.0/stats/current?pretty
    /// </summary>
    /// <param name="requestParams">Optional parameter.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    [Get(ApiRoutes.StatsRoutes.GetCurrent)]
    Task<IApiResponse<StatsCurrentResponse>> GetCurrentAsync(
        StatsCurrentRequest? requestParams = null,
        CancellationToken cancellationToken = default
    );
}