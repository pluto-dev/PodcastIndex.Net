namespace PodcastIndex.Net.Contracts.Requests.Episodes;

public class EpisodesByIdRequest : EpisodesBaseRequest
{
    /// <summary>
    ///     If present, return the full text value of any text fields (ex: description). If not provided, field value is
    ///     truncated to 100 words.
    ///     <para>Parameter shall not have a value</para>
    /// </summary>
    [AliasAs("fulltext")]
    public bool? FullText { get; set; }
}