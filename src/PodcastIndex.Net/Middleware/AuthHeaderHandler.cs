using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;

namespace PodcastIndex.Net.Middleware;

public class AuthHeaderHandler : DelegatingHandler
{
    private readonly PodcastIndexApiSettings? _podcastIndexApiSettings;

    public AuthHeaderHandler(IOptions<PodcastIndexApiSettings>? podcastIndexSettings)
    {
        _podcastIndexApiSettings = podcastIndexSettings?.Value;
    }

    protected override async Task<HttpResponseMessage> SendAsync(
        HttpRequestMessage request,
        CancellationToken cancellationToken
    )
    {
        var timestamp = DateTimeOffset.UtcNow.ToUnixTimeSeconds().ToString();
        var apiKey = _podcastIndexApiSettings?.ApiKey;
        var apiSecret = _podcastIndexApiSettings?.ApiSecret;


        var token = Helpers.CreateAuthorizationToken(apiKey, apiSecret, timestamp);

        request.Headers.Add("User-Agent", "PlutoCast");
        request.Headers.Add("X-Auth-Date", timestamp);
        request.Headers.Add("X-Auth-Key", apiKey);
        request.Headers.Add("Authorization", token);

        return await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
    }
}