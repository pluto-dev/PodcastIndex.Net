namespace PodcastIndex.Net.Contracts.Requests.Recent;

public class RecentBaseRequest : BaseRequest
{
    /// <summary>
    ///     Maximum number of results to return. The default is 10.
    ///     <para>Min 1 | Max 1000</para>
    ///     <para>Examples: 10</para>
    /// </summary>
    [AliasAs("max")]
    public int? Max { get; set; } = 10;
}