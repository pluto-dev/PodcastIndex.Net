using PodcastIndex.Net.Contracts;
using PodcastIndex.Net.Contracts.Requests.Recent;
using PodcastIndex.Net.Contracts.Responses.Recent;

namespace PodcastIndex.Net.Endpoints.Recent;

public partial interface IRecent
{
    /// <summary>
    ///     This call returns the most recent `max` feeds, in reverse chronological order.
    ///     <para>
    ///         <see href="https://podcastindex-org.github.io/docs-api/#get-/recent/feeds">
    ///             See docs on
    ///             podcastindex-org.github.io
    ///         </see>
    ///     </para>
    ///     Examples:
    ///     <br />
    ///     - https://api.podcastindex.org/api/1.0/recent/feeds?pretty
    ///     <br />
    ///     - https://api.podcastindex.org/api/1.0/recent/feeds?max=20&amp;cat=102,health&amp;lang=de,ja&amp;pretty
    /// </summary>
    /// <param name="requestParams">Optional parameter.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    [Get(ApiRoutes.RecentRoutes.GetFeeds)]
    Task<IApiResponse<RecentFeedsResponse>> GetFeedsAsync(
        RecentFeedsRequest? requestParams = null,
        CancellationToken cancellationToken = default
    );
}