using PodcastIndex.Net.Endpoints.AppleReplacement;
using PodcastIndex.Net.Endpoints.Categories;
using PodcastIndex.Net.Endpoints.Episodes;
using PodcastIndex.Net.Endpoints.Hub;
using PodcastIndex.Net.Endpoints.Podcasts;
using PodcastIndex.Net.Endpoints.Recent;
using PodcastIndex.Net.Endpoints.Search;
using PodcastIndex.Net.Endpoints.Stats;
using PodcastIndex.Net.Endpoints.Value;

namespace PodcastIndex.Net;

public interface IPodcastIndex
{
    /// <summary>
    ///     Replaces the Apple search API but returns data from the Podcast Index database.
    /// </summary>
    IAppleReplacement AppleReplacement();

    /// <summary>
    ///     Categories used by the Podcast Index.
    /// </summary>
    ICategories Categories();

    /// <summary>
    ///     Find details about one or more episodes of a podcast or podcasts.
    /// </summary>
    IEpisodes Episodes();

    /// <summary>
    ///     Notify the index that a feed has changed.
    /// </summary>
    IHub Hub();

    /// <summary>
    ///     Find details about a Podcast and its feed.
    /// </summary>
    IPodcasts Podcasts();

    /// <summary>
    ///     Find recent additions to the index.
    /// </summary>
    IRecent Recent();

    /// <summary>
    ///     Search the index.
    /// </summary>
    ISearch Search();

    /// <summary>
    ///     Statistics for items in the Podcast Index.
    /// </summary>
    IStats Stats();

    /// <summary>
    ///     The podcast's "Value for Value" information.
    /// </summary>
    IValue Value();
}