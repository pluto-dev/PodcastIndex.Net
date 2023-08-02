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

public class PodcastIndex : IPodcastIndex
{
    private readonly IAppleReplacement _appleReplacement;
    private readonly ICategories _categories;
    private readonly IEpisodes _episodes;
    private readonly IHub _hub;
    private readonly IPodcasts _podcasts;
    private readonly IRecent _recent;
    private readonly ISearch _search;
    private readonly IStats _stats;
    private readonly IValue _value;

    public PodcastIndex(
        IRecent recent,
        ICategories categories,
        IEpisodes episodes,
        IHub hub,
        IPodcasts podcasts,
        ISearch search,
        IStats stats,
        IValue value,
        IAppleReplacement appleReplacement
    )
    {
        _recent = recent;
        _categories = categories;
        _episodes = episodes;
        _hub = hub;
        _podcasts = podcasts;
        _search = search;
        _stats = stats;
        _value = value;
        _appleReplacement = appleReplacement;
    }

    public IAppleReplacement AppleReplacement()
    {
        return _appleReplacement;
    }

    public ICategories Categories()
    {
        return _categories;
    }

    public IEpisodes Episodes()
    {
        return _episodes;
    }

    public IHub Hub()
    {
        return _hub;
    }

    public IPodcasts Podcasts()
    {
        return _podcasts;
    }

    public IRecent Recent()
    {
        return _recent;
    }

    public ISearch Search()
    {
        return _search;
    }

    public IStats Stats()
    {
        return _stats;
    }

    public IValue Value()
    {
        return _value;
    }
}