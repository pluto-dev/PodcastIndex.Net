using PodcastIndex.Net.Contracts;
using PodcastIndex.Net.Contracts.Requests.Episodes;
using PodcastIndex.Net.Contracts.Responses.Episodes;

namespace PodcastIndex.Net.Endpoints.Episodes;

public partial interface IEpisodes
{
    /// <summary>
    ///     This call returns all the episodes we know about for this feed from the PodcastIndex ID. Episodes are in reverse
    ///     chronological order.
    ///     When using the `enclosure` parameter, only the episode matching the URL is returned.
    ///     <para>
    ///         <see href="https://podcastindex-org.github.io/docs-api/#get-/episodes/byfeedid">
    ///             See docs on
    ///             podcastindex-org.github.io
    ///         </see>
    ///     </para>
    ///     Examples:
    ///     <br />
    ///     - https://api.podcastindex.org/api/1.0/episodes/byfeedid?id=75075&amp;pretty
    ///     <br />
    ///     - https://api.podcastindex.org/api/1.0/episodes/byfeedid?id=41504,920666&amp;pretty
    ///     <br />
    ///     - Includes `persons`: https://api.podcastindex.org/api/1.0/episodes/byfeedid?id=169991&amp;pretty
    ///     <br />
    ///     - Includes `value`: https://api.podcastindex.org/api/1.0/episodes/byfeedid?id=4058673&amp;pretty
    ///     <br />
    ///     - Using `enclosure`: https://api.podcastindex.org/api/1.0/episodes/byfeedid?id=41504&amp;
    ///     enclosure=https://op3.dev/e/mp3s.nashownotes.com/NA-1551-2023-04-30-Final.mp3&amp;pretty
    /// </summary>
    /// <param name="id">
    ///     The PodcastIndex Feed ID or IDs to search for.
    ///     <para>If searching for multiple IDs, separate values with a comma. A maximum of 200 IDs can be provided.</para>
    ///     <code>
    ///     Examples:
    ///     Single ID: 75075
    ///     Multiple IDs: 41504,920666
    ///     </code>
    /// </param>
    /// <param name="requestParams">Optional parameter.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    [Get(ApiRoutes.EpisodesRoutes.GetByFeedId)]
    Task<IApiResponse<EpisodesByFeedIdResponse>> GetByFeedIdAsync(
        [Query(CollectionFormat.Csv)] string[]? id,
        EpisodesByFeedIdRequest? requestParams = null,
        CancellationToken cancellationToken = default
    );
}