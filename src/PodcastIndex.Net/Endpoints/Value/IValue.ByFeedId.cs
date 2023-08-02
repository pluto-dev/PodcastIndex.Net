using System.Threading;
using PodcastIndex.Net.Contracts;
using PodcastIndex.Net.Contracts.Requests.Value;
using PodcastIndex.Net.Contracts.Responses.Value;

namespace PodcastIndex.Net.Endpoints.Value;

public partial interface IValue
{
    /// <summary>
    ///     This call returns the information for supporting the podcast via one of the "Value for Value" methods from the
    ///     PodcastIndex ID.
    ///     <br />
    ///     Additionally, the value block data can be accessed using static JSON files (updated every 15 minutes).
    ///     <br />
    ///     - Feeds: https://tracking.podcastindex.org/feedValueBlocks.json
    ///     <br />
    ///     - Episodes: https://tracking.podcastindex.org/episodeValueBlocks.json
    ///     <para>
    ///         <see href="https://podcastindex-org.github.io/docs-api/#get-/value/byfeedid">
    ///             See docs on
    ///             podcastindex-org.github.io
    ///         </see>
    ///     </para>
    ///     Examples:
    ///     <br />
    ///     - https://api.podcastindex.org/api/1.0/value/byfeedid?id=920666&amp;pretty
    ///     <br />
    ///     - https://api.podcastindex.org/api/1.0/value/byfeedid?id=779873&amp;pretty
    /// </summary>
    /// <param name="id">
    ///     The PodcastIndex Feed ID to search for.
    ///     <para>Examples: 75075</para>
    /// </param>
    /// <param name="requestParams">Optional parameter.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns></returns>
    [Get(ApiRoutes.ValueRoutes.GetByFeedId)]
    Task<IApiResponse<ValueByFeedIdResponse>> GetByFeedIdAsync(int id,
        ValueByFeedIdRequest? requestParams = null,
        CancellationToken cancellationToken = default);
}