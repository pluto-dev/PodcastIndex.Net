namespace PodcastIndex.Net.Contracts.Requests.Episodes;

public class EpisodesByGuidRequest : EpisodesBaseRequest
{
    public EpisodesByGuidRequest(string feedId)
    {
        FeedId = feedId;
    }

    public EpisodesByGuidRequest(Uri feedUrl)
    {
        FeedUrl = feedUrl;
    }

    /// <summary>
    ///     The Feed URL.
    ///     <para>Examples: http://mp3s.nashownotes.com/pc20rss.xml</para>
    /// </summary>
    [AliasAs("feedurl")]
    public Uri? FeedUrl { get; private set; }

    /// <summary>
    ///     The PodcastIndex Feed ID
    ///     <para>Examples: 920666</para>
    /// </summary>
    [AliasAs("feedid")]
    public string? FeedId { get; private set; }

    /// <summary>
    ///     If present, return the full text value of any text fields (ex: description). If not provided, field value is
    ///     truncated to 100 words.
    ///     <para>Parameter shall not have a value</para>
    /// </summary>
    [AliasAs("fulltext")]
    public bool? FullText { get; set; }
}