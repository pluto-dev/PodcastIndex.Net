namespace PodcastIndex.Net.Contracts;

public static class ApiRoutes
{
    private const string Root = "api";
    private const string Version = "1.0";
    private const string Base = $"/{Root}/{Version}";

    public static class AppleReplacement
    {
        public const string Lookup = "/lookup";
        public const string Search = "/search";
    }

    public static class CategoriesRoutes
    {
        public const string GetList = $"{Base}/categories/list";
    }

    public static class EpisodesRoutes
    {
        public const string GetByFeedId = $"{Base}/episodes/byfeedid";
        public const string GetByFeedUrl = $"{Base}/episodes/byfeedurl";
        public const string GetByGuid = $"{Base}/episodes/byguid";
        public const string GetById = $"{Base}/episodes/byid";
        public const string GetByItunesId = $"{Base}/episodes/byitunesid";
        public const string GetByPodcastGuid = $"{Base}/episodes/bypodcastguid";
        public const string GetLive = $"{Base}/episodes/live";
        public const string GetRandom = $"{Base}/episodes/random";
    }

    public static class HubRoutes
    {
        public const string GetPubNotify = $"{Base}/hub/pubnotify";
    }

    public static class PodcastsRoutes
    {
        public const string GetByFeedId = $"{Base}/podcasts/byfeedid";
        public const string GetByFeedUrl = $"{Base}/podcasts/byfeedurl";
        public const string GetByGuid = $"{Base}/podcasts/byguid";
        public const string GetByItunesId = $"{Base}/podcasts/byitunesid";
        public const string GetByMedium = $"{Base}/podcasts/bymedium";
        public const string GetByTag = $"{Base}/podcasts/bytag";
        public const string GetDead = $"{Base}/podcasts/dead";
        public const string GetTrending = $"{Base}/podcasts/trending";
    }

    public static class RecentRoutes
    {
        public const string GetEpisodes = $"{Base}/recent/episodes";
        public const string GetData = $"{Base}/recent/data";
        public const string GetFeeds = $"{Base}/recent/feeds";
        public const string GetNewFeeds = $"{Base}/recent/newfeeds";
        public const string GetNewValueFeeds = $"{Base}/recent/newvaluefeeds";
        public const string GetSoundbites = $"{Base}/recent/soundbites";
    }

    public static class SearchRoutes
    {
        public const string GetByPerson = $"{Base}/search/byperson";
        public const string GetByTerm = $"{Base}/search/byterm";
        public const string GetByTitle = $"{Base}/search/bytitle";
        public const string GetMusicByTerm = $"{Base}/search/music/byterm";
    }

    public static class StatsRoutes
    {
        public const string GetCurrent = $"{Base}/stats/current";
    }

    public static class ValueRoutes
    {
        public const string GetByFeedId = $"{Base}/value/byfeedid";
        public const string GetByFeedUrl = $"{Base}/value/byfeedurl";
    }
}