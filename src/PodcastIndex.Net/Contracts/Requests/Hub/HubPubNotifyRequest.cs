namespace PodcastIndex.Net.Contracts.Requests.Hub;

public class HubPubNotifyRequest : HubPubNotifyBaseRequest
{
    public HubPubNotifyRequest(Uri url)
    {
        Url = url;
    }

    public HubPubNotifyRequest(int id)
    {
        Id = id;
    }

    /// <summary>
    ///     PodcastIndex Feed ID.
    ///     <para>The id or the url is required.</para>
    ///     <para>Examples: 75075</para>
    /// </summary>
    [AliasAs("id")]
    public int? Id { get; private set; }

    /// <summary>
    ///     Podcast feed URL.
    ///     <para>The id or the url is required.</para>
    ///     <para>Examples: https://feeds.theincomparable.com/batmanuniversity</para>
    /// </summary>
    [AliasAs("url")]
    public Uri? Url { get; private set; }
}