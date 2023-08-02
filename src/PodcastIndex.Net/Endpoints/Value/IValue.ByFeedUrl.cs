using PodcastIndex.Net.Contracts;
using PodcastIndex.Net.Contracts.Requests.Value;
using PodcastIndex.Net.Contracts.Responses.Value;

namespace PodcastIndex.Net.Endpoints.Value;

public partial interface IValue
{
    /// <summary>
    ///     This call returns the information for supporting the podcast via one of the "Value for Value" methods from feed
    ///     URL.
    ///     <br />
    ///     Additionally, the value block data can be accessed using static JSON files (updated every 15 minutes).
    ///     <br />
    ///     - Feeds: https://tracking.podcastindex.org/feedValueBlocks.json
    ///     <br />
    ///     - Episodes: https://tracking.podcastindex.org/episodeValueBlocks.json
    ///     <para>
    ///         <see href="https://podcastindex-org.github.io/docs-api/#get-/value/byfeedurl">
    ///             See docs on
    ///             podcastindex-org.github.io
    ///         </see>
    ///     </para>
    ///     Examples:
    ///     <br />
    ///     - https://api.podcastindex.org/api/1.0/value/byfeedurl?url=https://mp3s.nashownotes.com/pc20rss.xml&amp;pretty
    ///     <br />
    ///     - https://api.podcastindex.org/api/1.0/value/byfeedurl?url=https://lespoesiesdheloise.fr/@heloise/feed.xml&amp;
    ///     pretty
    /// </summary>
    /// <param name="uri">
    ///     Podcast feed URL.
    ///     <para>Examples: https://feeds.theincomparable.com/batmanuniversity</para>
    /// </param>
    /// <param name="requestParams">Optional parameter.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    [Get(ApiRoutes.ValueRoutes.GetByFeedUrl)]
    Task<IApiResponse<ValueByFeedUrlResponse>> GetByFeedUrlAsync(
        Uri uri,
        ValueByFeedUrlRequest? requestParams = null,
        CancellationToken cancellationToken = default
    );
}