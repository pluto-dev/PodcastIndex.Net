using PodcastIndex.Net.Contracts;
using PodcastIndex.Net.Contracts.Requests.Episodes;
using PodcastIndex.Net.Contracts.Responses.Episodes;

namespace PodcastIndex.Net.Endpoints.Episodes;

public partial interface IEpisodes
{
    /// <summary>
    ///     This call returns all the episodes we know about for this feed from the iTunes ID. Episodes are in reverse
    ///     chronological order.
    ///     <para>
    ///         <see href="https://podcastindex-org.github.io/docs-api/#get-/episodes/byitunesid">
    ///             See docs on
    ///             podcastindex-org.github.io
    ///         </see>
    ///     </para>
    ///     When using the `enclosure` parameter, only the episode matching the URL is returned.
    ///     <br />
    ///     Examples:
    ///     <br />
    ///     - https://api.podcastindex.org/api/1.0/episodes/byitunesid?id=1441923632&amp;pretty
    ///     <br />
    ///     - Using `enclosure`: https://api.podcastindex.org/api/1.0/episodes/byitunesid?id=269169796&amp;
    ///     enclosure=https://op3.dev/e/mp3s.nashownotes.com/NA-1551-2023-04-30-Final.mp3&amp;pretty
    /// </summary>
    /// <param name="id">
    ///     The iTunes Feed ID to search for.
    ///     <para>Examples: 144192363</para>
    /// </param>
    /// <param name="requestParams">Optional parameter.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    [Get(ApiRoutes.EpisodesRoutes.GetByItunesId)]
    Task<IApiResponse<EpisodesByItunesIdResponse>> GetByItunesIdAsync(
        int id,
        EpisodesByItunesIdRequest? requestParams = null,
        CancellationToken cancellationToken = default
    );
}