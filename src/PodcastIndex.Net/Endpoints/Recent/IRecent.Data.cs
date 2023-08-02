using PodcastIndex.Net.Contracts;
using PodcastIndex.Net.Contracts.Requests.Recent;
using PodcastIndex.Net.Contracts.Responses.Recent;

namespace PodcastIndex.Net.Endpoints.Recent;

public partial interface IRecent
{
    /// <summary>
    ///     This call returns every new feed and episode added to the index over the past 24 hours in reverse chronological
    ///     order.
    ///     <br />
    ///     This is similar to `/recent/feeds` but uses the date the feed was found by the index rather than the feed's
    ///     internal timestamp.
    ///     <br />
    ///     Similar data can also be accessed using object storage root url https://tracking.podcastindex.org/current
    ///     <br />
    ///     <para>
    ///         <see href="https://podcastindex-org.github.io/docs-api/#get-/recent/data">
    ///             See docs on
    ///             podcastindex-org.github.io
    ///         </see>
    ///     </para>
    ///     Examples:
    ///     <br />
    ///     - https://api.podcastindex.org/api/1.0/recent/data?pretty
    ///     <br />
    ///     - https://api.podcastindex.org/api/1.0/recent/data?pretty&amp;max=10
    ///     <br />
    ///     - https://api.podcastindex.org/api/1.0/recent/data?pretty&amp;max=10&amp;since=1671164867
    /// </summary>
    /// <param name="requestParams">Optional parameter.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    [Get(ApiRoutes.RecentRoutes.GetData)]
    Task<IApiResponse<RecentDataResponse>> GetDataAsync(
        RecentDataRequest? requestParams = null,
        CancellationToken cancellationToken = default
    );
}