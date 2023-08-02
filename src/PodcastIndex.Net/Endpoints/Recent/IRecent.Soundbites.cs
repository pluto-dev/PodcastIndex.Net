using PodcastIndex.Net.Contracts;
using PodcastIndex.Net.Contracts.Requests.Recent;
using PodcastIndex.Net.Contracts.Responses.Recent;

namespace PodcastIndex.Net.Endpoints.Recent;

public partial interface IRecent
{
    /// <summary>
    ///     This call returns the most recent `max` soundbites that the index has discovered.
    ///     <br />
    ///     A soundbite consists of an enclosure url, a start time and a duration. It is documented in the [podcast
    ///     namespace](https://github.com/Podcastindex-org/podcast-namespace/blob/main/docs/1.0.md#soundbite).
    ///     <br />
    ///     <para>
    ///         <see href="https://podcastindex-org.github.io/docs-api/#get-/recent/soundbites">
    ///             See docs on
    ///             podcastindex-org.github.io
    ///         </see>
    ///     </para>
    ///     Example: https://api.podcastindex.org/api/1.0/recent/soundbites?pretty
    /// </summary>
    /// <param name="requestParams">Optional parameter.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    [Get(ApiRoutes.RecentRoutes.GetSoundbites)]
    Task<IApiResponse<RecentSoundbitesResponse>> GetSoundbitesAsync(
        RecentSoundbitesRequest? requestParams = null,
        CancellationToken cancellationToken = default
    );
}