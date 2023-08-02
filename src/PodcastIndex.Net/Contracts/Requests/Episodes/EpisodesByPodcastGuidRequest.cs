namespace PodcastIndex.Net.Contracts.Requests.Episodes;

public class EpisodesByPodcastGuidRequest : EpisodesBaseRequest
{
    /// <summary>
    ///     Return items since the specified epoch timestamp.
    ///     <para>Examples: 1612125785</para>
    /// </summary>
    [AliasAs("since")]
    public long? Since { get; set; }

    /// <summary>
    ///     Maximum number of results to return. The default is 10.
    ///     <para>Min 1 | Max 1000</para>
    ///     <para>Examples: 10</para>
    /// </summary>
    [AliasAs("max")]
    public int? Max { get; set; } = 10;

    /// <summary>
    ///     If present, return the full text value of any text fields (ex: description). If not provided, field value is
    ///     truncated to 100 words.
    ///     <para>Parameter shall not have a value</para>
    /// </summary>
    [AliasAs("fulltext")]
    public bool? FullText { get; set; }
}