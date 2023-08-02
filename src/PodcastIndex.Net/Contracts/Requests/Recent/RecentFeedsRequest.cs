namespace PodcastIndex.Net.Contracts.Requests.Recent;

public class RecentFeedsRequest : RecentBaseRequest
{
    /// <summary>
    ///     Return items since the specified epoch timestamp.
    ///     <para>Examples: 1612125785</para>
    /// </summary>
    [AliasAs("since")]
    public long? Since { get; set; }

    /// <summary>
    ///     <para>
    ///         Specifying a language code (like "en") will return only episodes having that specific language.
    ///     </para>
    ///     <para>
    ///         You can specify multiple languages by separating them with commas.
    ///     </para>
    ///     <para>
    ///         If you also want to return episodes that have no language given, use the token "unknown". (ex.
    ///         en,es,ja,unknown).
    ///     </para>
    ///     Values are not case sensitive.
    ///     <code>
    /// Examples:
    /// en
    /// Single ID
    /// 
    /// en,es
    /// Multiple IDs
    /// </code>
    /// </summary>
    [Query(CollectionFormat.Csv)]
    [AliasAs("lang")]
    public string[]? Languages { get; set; }

    /// <summary>
    ///     <para>
    ///         Use this argument to specify that you <b>ONLY</b> want episodes with these categories in the results.
    ///     </para>
    ///     <para>
    ///         Separate multiple categories with commas.
    ///     </para>
    ///     <para>
    ///         You may specify either the Category ID and/or the Category Name.
    ///     </para>
    ///     <para>
    ///         Values are not case sensitive.
    ///     </para>
    ///     <para>
    ///         The cat and notcat filters can be used together to fine tune a very specific result set.
    ///     </para>
    ///     <para>
    ///         Category numbers and names can be found in the Podcast Namespace documentation
    ///     </para>
    ///     <code>
    /// Examples:
    /// News
    /// Single Category Name
    /// 
    /// 65
    /// Single Category ID
    /// 
    /// News,Religion
    /// Multiple Category Names
    /// 
    /// 55,65
    /// Multiple Category IDs
    /// 
    /// News,65
    /// Multiple Categories Mixed Format
    /// </code>
    /// </summary>
    [Query(CollectionFormat.Csv)]
    [AliasAs("cat")]
    public string[]? Categories { get; set; }

    /// <summary>
    ///     <para>
    ///         Use this argument to specify categories of episodes to <b>NOT</b> show in the results.
    ///     </para>
    ///     <para>
    ///         Separate multiple categories with commas.
    ///     </para>
    ///     <para>
    ///         You may specify either the Category ID and/or the Category Name.
    ///     </para>
    ///     <para>
    ///         Values are not case sensitive.
    ///     </para>
    ///     <para>
    ///         The cat and notcat filters can be used together to fine tune a very specific result set.
    ///     </para>
    ///     <para>
    ///         Category numbers and names can be found in the Podcast Namespace documentation
    ///     </para>
    ///     <code>
    /// Examples:
    /// News
    /// Single Category Name
    /// 
    /// 65
    /// Single Category ID
    /// 
    /// News,Religion
    /// Multiple Category Names
    /// 
    /// 55,65
    /// Multiple Category IDs
    /// 
    /// News,65
    /// Multiple Categories Mixed Format
    /// </code>
    /// </summary>
    [Query(CollectionFormat.Csv)]
    [AliasAs("notcat")]
    public string[]? NotCategories { get; set; }

    /// <summary>
    ///     If present, return the full text value of any text fields (ex: description). If not provided, field value is
    ///     truncated to 100 words.
    ///     <para>Parameter shall not have a value</para>
    /// </summary>
    [AliasAs("fulltext")]
    public bool? FullText { get; set; }
}