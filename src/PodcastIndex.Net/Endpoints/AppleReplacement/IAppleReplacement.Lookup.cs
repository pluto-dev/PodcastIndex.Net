using PodcastIndex.Net.Contracts;
using PodcastIndex.Net.Contracts.Enums;
using PodcastIndex.Net.Contracts.Requests.AppleReplacement;
using PodcastIndex.Net.Contracts.Responses.AppleReplacement;

namespace PodcastIndex.Net.Endpoints.AppleReplacement;

public partial interface IAppleReplacement
{
    /// <summary>
    ///     Replaces the Apple podcast lookup API but returns data from the Podcast Index database.
    ///     <br />
    ///     Note: No API key needed for this endpoint.
    ///     <para>
    ///         <see href="https://podcastindex-org.github.io/docs-api/#get-/lookup">See docs on podcastindex-org.github.io</see>
    ///     </para>
    ///     Example:
    ///     <br />
    ///     - Apple: https://itunes.apple.com/lookup?media=podcast&amp;entity=podcast&amp;id=1636765656
    ///     <br />
    ///     - PodcastIndex: https://api.podcastindex.org/lookup?entity=podcast&amp;id=1636765656
    /// </summary>
    /// <param name="id">
    ///     The iTunes Feed ID to search for.
    ///     <br />
    ///     Examples:
    ///     <br />
    ///     1441923632
    ///     iTunes ID
    /// </param>
    /// <param name="entity">
    ///     The iTunes entity type to look in.
    ///     <br />
    ///     Only 'podcast' is currently allowed.
    ///     <br />
    ///     Examples: podcast
    /// </param>
    /// <param name="requestParams">Optional parameter.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    [Get(ApiRoutes.AppleReplacement.Lookup)]
    Task<IApiResponse<AppleReplacementResponse>> Lookup(
        int id,
        Entity entity = Entity.Podcast,
        AppleReplacementLookupRequest? requestParams = null,
        CancellationToken cancellationToken = default
    );
}