using PodcastIndex.Net.Contracts;
using PodcastIndex.Net.Contracts.Requests.Podcasts;
using PodcastIndex.Net.Contracts.Responses.Podcasts;

namespace PodcastIndex.Net.Endpoints.Podcasts;

public partial interface IPodcasts
{
    /// <summary>
    ///     This call returns everything we know about the feed from the feed URL.
    ///     <para>
    ///         <see href="https://podcastindex-org.github.io/docs-api/#get-/podcasts/byfeedurl">
    ///             See docs on
    ///             podcastindex-org.github.io
    ///         </see>
    ///     </para>
    ///     Examples:
    ///     <br />
    ///     - https://api.podcastindex.org/api/1.0/podcasts/byfeedurl?url=https://feeds.theincomparable.com/batmanuniversity
    ///     &amp;pretty
    ///     <br />
    ///     - Includes `value` and `funding`:
    ///     https://api.podcastindex.org/api/1.0/podcasts/byfeedurl?url=https://engineered.network/pragmatic/feed/index.xml
    ///     &amp;pretty
    /// </summary>
    /// <param name="url">
    ///     Podcast feed URL.
    ///     <para>
    ///         Examples: https://feeds.theincomparable.com/batmanuniversity
    ///     </para>
    /// </param>
    /// <param name="requestParams">Optional parameter.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    [Get(ApiRoutes.PodcastsRoutes.GetByFeedUrl)]
    Task<IApiResponse<PodcastsByFeedUrlResponse>> GetByFeedUrlAsync(
        Uri url,
        PodcastsByFeedUrlRequest? requestParams = null,
        CancellationToken cancellationToken = default
    );
}