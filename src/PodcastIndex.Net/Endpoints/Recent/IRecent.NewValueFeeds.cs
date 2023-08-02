using PodcastIndex.Net.Contracts;
using PodcastIndex.Net.Contracts.Requests.Recent;
using PodcastIndex.Net.Contracts.Responses.Recent;

namespace PodcastIndex.Net.Endpoints.Recent;

public partial interface IRecent
{
    /// <summary>
    ///     This call returns feeds that have added a `value` tag in reverse chronological order.
    ///     <para>
    ///         <see href="https://podcastindex-org.github.io/docs-api/#get-/recent/newvaluefeeds">
    ///             See docs on
    ///             podcastindex-org.github.io
    ///         </see>
    ///     </para>
    ///     Example: https://api.podcastindex.org/api/1.0/recent/newvaluefeeds?pretty
    /// </summary>
    /// <param name="requestParams">Optional parameter.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    [Get(ApiRoutes.RecentRoutes.GetNewValueFeeds)]
    Task<IApiResponse<RecentNewValueFeedsResponse>> GetNewValueFeeds(
        RecentNewValueFeedsRequest? requestParams = null,
        CancellationToken cancellationToken = default
    );
}