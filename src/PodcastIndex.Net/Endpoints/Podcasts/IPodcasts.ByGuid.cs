using PodcastIndex.Net.Contracts;
using PodcastIndex.Net.Contracts.Requests.Podcasts;
using PodcastIndex.Net.Contracts.Responses.Podcasts;

namespace PodcastIndex.Net.Endpoints.Podcasts;

public partial interface IPodcasts
{
    /// <summary>
    ///     This call returns everything we know about the feed from the feed's GUID.
    ///     <para>
    ///         The GUID is a unique, global identifier for the podcast. See the namespace spec for guid for details.
    ///     </para>
    ///     <para>
    ///         <see href="https://podcastindex-org.github.io/docs-api/#get-/podcasts/byguid">
    ///             See docs on
    ///             podcastindex-org.github.io
    ///         </see>
    ///     </para>
    ///     Examples:
    ///     <br />
    ///     - https://api.podcastindex.org/api/1.0/podcasts/byguid?guid=9b024349-ccf0-5f69-a609-6b82873eab3c&amp;pretty
    ///     <br />
    ///     - Includes `value` and `funding`:
    ///     https://api.podcastindex.org/api/1.0/podcasts/byguid?guid=9b024349-ccf0-5f69-a609-6b82873eab3c&amp;pretty
    /// </summary>
    /// <param name="guid">
    ///     The GUID from the <c>podcast:guid</c> tag in the feed. This value is a unique, global identifier for the podcast.
    ///     <para>
    ///         See the namespace spec for guid for details.
    ///     </para>
    ///     <para>
    ///         Examples: 9b024349-ccf0-5f69-a609-6b82873eab3c
    ///     </para>
    /// </param>
    /// <param name="requestParams">Optional parameter.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    [Get(ApiRoutes.PodcastsRoutes.GetByGuid)]
    Task<IApiResponse<PodcastsByGuidResponse>> GetByGuidAsync(
        Guid guid,
        PodcastsByGuidRequest? requestParams = null,
        CancellationToken cancellationToken = default
    );
}