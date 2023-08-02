using PodcastIndex.Net.Contracts;
using PodcastIndex.Net.Contracts.Enums;
using PodcastIndex.Net.Contracts.Requests.Podcasts;
using PodcastIndex.Net.Contracts.Responses.Podcasts;

namespace PodcastIndex.Net.Endpoints.Podcasts;

public partial interface IPodcasts
{
    /// <summary>
    ///     This call returns all feeds marked with the specified medium tag value.
    ///     <para>
    ///         <see href="https://podcastindex-org.github.io/docs-api/#get-/podcasts/bymedium">
    ///             See docs on
    ///             podcastindex-org.github.io
    ///         </see>
    ///     </para>
    ///     Example: https://api.podcastindex.org/api/1.0/podcasts/bymedium?medium=music&amp;pretty
    /// </summary>
    /// <param name="medium">
    ///     The medium value to search for.
    ///     <para>
    ///         Allowed: audiobook ┃ blog ┃ film ┃ music ┃ newsletter ┃ podcast ┃ video
    ///     </para>
    ///     Full list of possible values documented in medium tag spec.
    ///     <para>
    ///         Examples: film
    ///     </para>
    /// </param>
    /// <param name="requestParams">Optional parameter.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    [Get(ApiRoutes.PodcastsRoutes.GetByMedium)]
    Task<IApiResponse<PodcastsByMediumResponse>> GetByMediumAsync(
        Medium medium,
        PodcastsByMediumRequest? requestParams = null,
        CancellationToken cancellationToken = default
    );
}