using PodcastIndex.Net.Contracts;
using PodcastIndex.Net.Contracts.Requests.Episodes;
using PodcastIndex.Net.Contracts.Responses.Episodes;

namespace PodcastIndex.Net.Endpoints.Episodes;

public partial interface IEpisodes
{
    /// <summary>
    ///     This call returns a random batch of episodes, in no specific order.
    ///     <para>
    ///         <see href="https://podcastindex-org.github.io/docs-api/#get-/episodes/random">
    ///             See docs on
    ///             podcastindex-org.github.io
    ///         </see>
    ///     </para>
    ///     Examples:
    ///     <br />
    ///     - https://api.podcastindex.org/api/1.0/episodes/random?notcat=News,Religion&amp;lang=en,es&amp;pretty
    ///     <br />
    ///     - https://api.podcastindex.org/api/1.0/episodes/random?max=2&amp;pretty
    /// </summary>
    /// <param name="requestParams">Optional parameter.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    [Get(ApiRoutes.EpisodesRoutes.GetRandom)]
    Task<IApiResponse<EpisodesRandomResponse>> GetRandomAsync(
        EpisodesRandomRequest? requestParams = null,
        CancellationToken cancellationToken = default
    );
}