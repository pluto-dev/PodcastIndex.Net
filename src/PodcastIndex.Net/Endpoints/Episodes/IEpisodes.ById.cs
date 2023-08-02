using PodcastIndex.Net.Contracts;
using PodcastIndex.Net.Contracts.Requests.Episodes;
using PodcastIndex.Net.Contracts.Responses.Episodes;

namespace PodcastIndex.Net.Endpoints.Episodes;

public partial interface IEpisodes
{
    /// <summary>
    ///     Get all the metadata for a single episode by passing its id.
    ///     <para>
    ///         <see href="https://podcastindex-org.github.io/docs-api/#get-/episodes/byid">
    ///             See docs on
    ///             podcastindex-org.github.io
    ///         </see>
    ///     </para>
    ///     Example: https://api.podcastindex.org/api/1.0/episodes/byid?id=16795090&amp;pretty
    /// </summary>
    /// <param name="id">
    ///     The PodcastIndex episode ID to search for.
    ///     <para>Examples: 16795089</para>
    /// </param>
    /// <param name="requestParams">Optional parameter.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    [Get(ApiRoutes.EpisodesRoutes.GetById)]
    Task<IApiResponse<EpisodesByIdResponse>> GetByIdAsync(
        int id,
        EpisodesByIdRequest? requestParams = null,
        CancellationToken cancellationToken = default
    );
}