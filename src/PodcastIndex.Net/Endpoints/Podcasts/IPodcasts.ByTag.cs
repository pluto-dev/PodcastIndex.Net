using PodcastIndex.Net.Contracts;
using PodcastIndex.Net.Contracts.Requests.Podcasts;
using PodcastIndex.Net.Contracts.Responses.Podcasts;

namespace PodcastIndex.Net.Endpoints.Podcasts;

public partial interface IPodcasts
{
    /// <summary>
    ///     This call returns all feeds that support the specified [podcast
    ///     namespace](https://github.com/Podcastindex-org/podcast-namespace/blob/main/docs/1.0.md) tag.
    ///     <br />
    ///     When called without a `start_at` value, the top 500 feeds sorted by popularity are returned in descending order.
    ///     <br />
    ///     When called with a `start_at` value, the feeds are returned sorted by the `feedId` starting with the specified
    ///     value up to the max number of feeds to return. The `nextStartAt` specifies the value to pass to the next
    ///     `start_at`. Repeat this sequence until no items are returned.
    ///     <para>
    ///         <see href="https://podcastindex-org.github.io/docs-api/#get-/podcasts/bytag">
    ///             See docs on
    ///             podcastindex-org.github.io
    ///         </see>
    ///     </para>
    ///     Examples:
    ///     <br />
    ///     - https://api.podcastindex.org/api/1.0/podcasts/bytag?podcast-value&amp;max=200&amp;pretty
    ///     <br />
    ///     - https://api.podcastindex.org/api/1.0/podcasts/bytag?podcast-value&amp;max=200&amp;start_at=1&amp;pretty
    /// </summary>
    /// <param name="podcastValue">
    ///     Get feeds supporting the value tag. Default is true.
    ///     Parameter shall not have a value.
    /// </param>
    /// <param name="requestParams">Optional parameter.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    [Get(ApiRoutes.PodcastsRoutes.GetByTag)]
    Task<IApiResponse<PodcastsByTagResponse>> GetByTagAsync(
        [AliasAs("podcast-value")] bool podcastValue = true,
        PodcastsByTagRequest? requestParams = null,
        CancellationToken cancellationToken = default
    );
}