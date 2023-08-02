namespace PodcastIndex.Net.Contracts.Requests.Recent;

public class RecentNewValueFeedsRequest : RecentBaseRequest
{
    /// <summary>
    ///     Return items since the specified epoch timestamp.
    ///     <para>Examples: 1612125785</para>
    /// </summary>
    [AliasAs("since")]
    public long? Since { get; set; }
}