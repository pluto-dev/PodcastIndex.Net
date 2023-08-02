using PodcastIndex.Net.Contracts;
using PodcastIndex.Net.Contracts.Requests.Episodes;
using PodcastIndex.Net.Contracts.Responses.Episodes;

namespace PodcastIndex.Net.Endpoints.Episodes;

public partial interface IEpisodes
{
    /// <summary>
    ///     This call returns all the episodes we know about for this feed from the feed URL. Episodes are in reverse
    ///     chronological order.
    ///     <para>
    ///         <see href="https://podcastindex-org.github.io/docs-api/#get-/episodes/byfeedurl">
    ///             See docs on
    ///             podcastindex-org.github.io
    ///         </see>
    ///     </para>
    ///     Examples:
    ///     <br />
    ///     - https://api.podcastindex.org/api/1.0/episodes/byfeedurl?url=https://feeds.theincomparable.com/batmanuniversity
    ///     &amp;pretty
    ///     <br />
    ///     - Includes `persons`:
    ///     https://api.podcastindex.org/api/1.0/episodes/byfeedurl?url=https://engineered.network/pragmatic/feed/index.xml
    ///     &amp;pretty
    ///     <br />
    ///     - Includes `value`:
    ///     https://api.podcastindex.org/api/1.0/episodes/byfeedurl?url=https://closing-the-loop.github.io/feed.xml&amp;pretty
    /// </summary>
    /// <param name="url">
    ///     Podcast feed url.
    ///     <para>Examples: https://feeds.theincomparable.com/batmanuniversity</para>
    /// </param>
    /// <param name="requestParams">Optional parameter.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    [Get(ApiRoutes.EpisodesRoutes.GetByFeedUrl)]
    Task<IApiResponse<EpisodesByFeedUrlResponse>> GetByFeedUrlAsync(
        Uri url,
        EpisodesByFeedUrlRequest? requestParams = null,
        CancellationToken cancellationToken = default
    );
}