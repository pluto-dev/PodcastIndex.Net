using PodcastIndex.Net.Contracts.Enums;

namespace PodcastIndex.Net.Contracts.Requests.Search;

public class SearchByTitleRequest : SearchBaseRequest
{
    /// <summary>
    ///     Only returns feeds with a <b>value</b> block of the specified type. Use <b>any</b> to return feeds with any
    ///     <b>value</b> block.
    ///     <br />
    ///     Allowed: any ┃ lightning ┃ hive ┃ webmonetization
    /// </summary>
    [AliasAs("val")]
    public ValueBlock? Value { get; set; }

    /// <summary>
    ///     If present, only non-explicit feeds will be returned.
    ///     Meaning, feeds where the <c>itunes:explicit</c> flag is set to <c>false</c>.
    /// </summary>
    [AliasAs("clean")]
    public bool? Clean { get; set; }

    /// <summary>
    ///     If present, include similar matches in search response. For search/byterm, prioritizes title matches.
    /// </summary>
    [AliasAs("similar")]
    public bool? Similar { get; set; }
}