namespace PodcastIndex.Net.Contracts.Requests.Recent;

public class RecentNewFeedsRequest : RecentBaseRequest
{
    /// <summary>
    ///     Return items since the specified epoch timestamp.
    ///     <para>Examples: 1612125785</para>
    /// </summary>
    [AliasAs("since")]
    public long? Since { get; set; }

    /// <summary>
    ///     The PodcastIndex Feed ID to start from (or go to if <c>desc</c> specified).
    ///     <para>If <c>since</c> parameter also specified, value of <c>since</c> is ignored.</para>
    ///     <para>Examples: 2653471</para>
    /// </summary>
    [AliasAs("feedid")]
    public string? FeedId { get; set; }

    /// <summary>
    ///     If present, display feeds in descending order.
    ///     <para>Only applicable when using <c>feedid</c> parameter.</para>
    ///     <para>Parameter shall not have a value.</para>
    /// </summary>
    [AliasAs("desc")]
    public bool? DescendingOrder { get; set; }
}