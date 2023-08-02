using PodcastIndex.Net.Contracts;
using PodcastIndex.Net.Contracts.Requests.AppleReplacement;
using PodcastIndex.Net.Contracts.Responses.AppleReplacement;

namespace PodcastIndex.Net.Endpoints.AppleReplacement;

public partial interface IAppleReplacement
{
    /// <summary>
    ///     Replaces the Apple search API but returns data from the Podcast Index database.
    ///     <br />
    ///     Note: No API key needed for this endpoint.
    ///     <para>
    ///         <see href="https://podcastindex-org.github.io/docs-api/#get-/search">See docs on podcastindex-org.github.io</see>
    ///     </para>
    ///     Example:
    ///     <br />
    ///     - Apple: https://itunes.apple.com/search?media=podcast&amp;entity=podcast&amp;term=batman
    ///     <br />
    ///     - PodcastIndex: https://api.podcastindex.org/search?term=batman
    /// </summary>
    /// <param name="searchTerm">
    ///     The iTunes Feed ID to search for.
    ///     <br />
    ///     Examples:
    ///     <br />
    ///     1441923632
    ///     iTunes ID
    /// </param>
    /// <param name="requestParams">Optional parameter.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    [Get(ApiRoutes.AppleReplacement.Search)]
    Task<IApiResponse<AppleReplacementResponse>> Search(
        [AliasAs("term")] string searchTerm,
        AppleReplacementSearchRequest? requestParams = null,
        CancellationToken cancellationToken = default
    );
}