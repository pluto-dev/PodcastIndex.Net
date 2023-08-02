namespace PodcastIndex.Net.Contracts.Requests.Podcasts;

public class PodcastsByTagRequest : PodcastsBaseRequest
{
    /// <summary>
    ///     Feed ID to start at for request.
    ///     <para>Min 1</para>
    ///     Examples: 1
    /// </summary>
    [AliasAs("start_at")]
    public int? StartAt { get; set; }

    /// <summary>
    ///     Maximum number of results to return. The default is 10.
    ///     <para>Min 1 | Max 5000</para>
    ///     <para>Examples: 10</para>
    /// </summary>
    [AliasAs("max")]
    public int? Max { get; set; } = 10;
}