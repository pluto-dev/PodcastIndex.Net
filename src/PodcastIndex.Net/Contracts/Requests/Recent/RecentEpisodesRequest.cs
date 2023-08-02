namespace PodcastIndex.Net.Contracts.Requests.Recent;

public class RecentEpisodesRequest : RecentBaseRequest
{
    /// <summary>
    ///     Any item containing this string will be discarded from the result set.
    ///     <para>This may, in certain cases, reduce your set size below your max value.</para>
    ///     <para>Matches against the title and URL properties.</para>
    ///     <para>Examples: <c>religion</c></para>
    /// </summary>
    [AliasAs("excludeString")]
    public string? ExcludeString { get; set; }

    /// <summary>
    ///     If you pass a PodcastIndex Episode ID, you will get recent episodes before that ID,
    ///     allowing you to walk back through the episode history sequentially.
    ///     <para>Examples: 1721351091</para>
    /// </summary>
    [AliasAs("before")]
    public int? Before { get; set; }

    /// <summary>
    ///     If present, return the full text value of any text fields (ex: description). If not provided, field value is
    ///     truncated to 100 words.
    ///     <para>Parameter shall not have a value</para>
    /// </summary>
    [AliasAs("fulltext")]
    public bool? FullText { get; set; }
}