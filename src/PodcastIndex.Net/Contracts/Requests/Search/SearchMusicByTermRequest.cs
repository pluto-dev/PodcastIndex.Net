﻿using PodcastIndex.Net.Contracts.Enums;

namespace PodcastIndex.Net.Contracts.Requests.Search;

public class SearchMusicByTermRequest
{
    /// <summary>
    ///     Only returns feeds with an <c>itunesId</c>.
    /// </summary>
    [AliasAs("aponly")]
    public bool? ItunesOnly { get; set; }

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
}