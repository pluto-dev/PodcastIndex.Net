using PodcastIndex.Net.Contracts;
using PodcastIndex.Net.Contracts.Requests.Episodes;
using PodcastIndex.Net.Contracts.Responses.Episodes;

namespace PodcastIndex.Net.Endpoints.Episodes;

public partial interface IEpisodes
{
    /// <summary>
    ///     Get all the metadata for a single episode by passing its guid and the feed id or URL.
    ///     <para>The feedid or the feedurl is required.</para>
    ///     <para>
    ///         <see href="https://podcastindex-org.github.io/docs-api/#get-/episodes/byguid">
    ///             See docs on
    ///             podcastindex-org.github.io
    ///         </see>
    ///     </para>
    ///     Examples:
    ///     <br />
    ///     - Search using Podcast Index feed ID: https://api.podcastindex.org/api/1.0/episodes/byguid?guid=PC2084&amp;
    ///     feedid=920666&amp;pretty
    ///     <br />
    ///     - Search using feed URL: https://api.podcastindex.org/api/1.0/episodes/byguid?guid=PC2084&amp;
    ///     feedurl=http://mp3s.nashownotes.com/pc20rss.xml&amp;pretty
    /// </summary>
    /// <param name="guid">
    ///     The guid value for the episode to retrieve.
    ///     <para>
    ///         This value is the value specified in the feed's
    ///         <b>
    ///             <c>guid</c>
    ///         </b>
    ///         field.
    ///     </para>
    ///     Examples: <c>PC2084</c>
    ///     <remarks>
    ///         The Guid is not really a Guid if you can see on the example, might be a BUG.
    ///     </remarks>
    /// </param>
    /// <param name="requestParams">Optional parameter.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    [Get(ApiRoutes.EpisodesRoutes.GetByGuid)]
    Task<IApiResponse<EpisodesByGuidResponse>> GetByGuidAsync(
        string guid,
        EpisodesByGuidRequest? requestParams = null,
        CancellationToken cancellationToken = default
    );
}