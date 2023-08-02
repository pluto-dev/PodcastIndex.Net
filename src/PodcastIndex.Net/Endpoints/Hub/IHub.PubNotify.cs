using PodcastIndex.Net.Contracts;
using PodcastIndex.Net.Contracts.Requests.Hub;
using PodcastIndex.Net.Contracts.Responses.Hub;

namespace PodcastIndex.Net.Endpoints.Hub;

public partial interface IHub
{
    /// <summary>
    ///     Notify the index that a feed has changed.
    ///     <br />
    ///     Note: No API key needed for this endpoint.
    ///     <para>
    ///         <see href="https://podcastindex-org.github.io/docs-api/#get-/hub/pubnotify">
    ///             See docs on
    ///             podcastindex-org.github.io
    ///         </see>
    ///     </para>
    ///     Examples:
    ///     <br />
    ///     - https://api.podcastindex.org/api/1.0/hub/pubnotify?id=920666&amp;pretty
    ///     <br />
    ///     - https://api.podcastindex.org/api/1.0/hub/pubnotify?url=https://feeds.theincomparable.com/batmanuniversity&amp;
    ///     pretty
    /// </summary>
    /// <param name="requestParams">Mandatory parameter.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    [Get(ApiRoutes.HubRoutes.GetPubNotify)]
    Task<IApiResponse<HubPubNotifyResponse>> GetPubNotifyAsync(
        HubPubNotifyRequest requestParams,
        CancellationToken cancellationToken = default
    );
}