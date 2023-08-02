using System;

namespace PodcastIndex.Net;

public class PodcastIndexApiSettings
{
    public const string Section = "PodcastIndex";

    public Uri? BaseUrl { get; set; } = new("https://api.podcastindex.org/");

    public string? UserAgent { get; set; }

    public string? ApiKey { get; set; }

    public string? ApiSecret { get; set; }
}