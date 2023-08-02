using PodcastIndex.Net.Contracts;
using PodcastIndex.Net.Contracts.Requests.Episodes;
using PodcastIndex.Net.Contracts.Responses.Episodes;

namespace PodcastIndex.Net.Endpoints.Episodes;

public partial interface IEpisodes
{
    /// <summary>
    ///     This call returns all the episodes we know about for this feed from the Podcast GUID. Episodes are in reverse
    ///     chronological order.b
    ///     <para>
    ///         <see href="https://podcastindex-org.github.io/docs-api/#get-/episodes/bypodcastguid">
    ///             See docs on
    ///             podcastindex-org.github.io
    ///         </see>
    ///     </para>
    ///     Examples: https://api.podcastindex.org/api/1.0/episodes/bypodcastguid?guid=856cd618-7f34-57ea-9b84-3600f1f65e7f
    ///     &amp;pretty
    /// </summary>
    /// <param name="guid">
    ///     The GUID from the 'podcast:guid' tag in the feed. This value is a unique, global identifier for the podcast.
    ///     <see href="https://github.com/Podcastindex-org/podcast-namespace/blob/main/docs/1.0.md#guid">
    ///         See the namespace spec
    ///         for <c>guid</c> for details.
    ///     </see>
    ///     <para> Examples: 9b024349-ccf0-5f69-a609-6b82873eab3c </para>
    /// </param>
    /// <param name="requestParams">Optional parameter.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    [Get(ApiRoutes.EpisodesRoutes.GetByPodcastGuid)]
    Task<IApiResponse<EpisodesByPodcastGuidResponse>> GetByPodcastGuidAsync(
        Guid guid,
        EpisodesByPodcastGuidRequest? requestParams = null,
        CancellationToken cancellationToken = default
    );
}