using PodcastIndex.Net.Contracts;
using PodcastIndex.Net.Contracts.Requests.Recent;
using PodcastIndex.Net.Contracts.Responses.Recent;

namespace PodcastIndex.Net.Endpoints.Recent;

public partial interface IRecent
{
    /// <summary>
    ///     This call returns every new feed added to the index over the past 24 hours in reverse chronological order.
    ///     <para>
    ///         <see href="https://podcastindex-org.github.io/docs-api/#get-/recent/newfeeds">
    ///             See docs on
    ///             podcastindex-org.github.io
    ///         </see>
    ///     </para>
    ///     Examples:
    ///     <br />
    ///     - https://api.podcastindex.org/api/1.0/recent/newfeeds?pretty
    ///     <br />
    ///     - https://api.podcastindex.org/api/1.0/recent/newfeeds?pretty&amp;since=1613805000
    ///     <br />
    ///     - https://api.podcastindex.org/api/1.0/recent/newfeeds?feedid=2653471&amp;pretty
    ///     <br />
    ///     - https://api.podcastindex.org/api/1.0/recent/newfeeds?feedid=2653471&amp;desc&amp;pretty
    /// </summary>
    /// <param name="requestParams">Optional parameter.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    [Get(ApiRoutes.RecentRoutes.GetNewFeeds)]
    Task<IApiResponse<RecentNewFeedsResponse>> GetNewFeedsAsync(
        RecentNewFeedsRequest? requestParams = null,
        CancellationToken cancellationToken = default
    );
}