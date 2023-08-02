using System;
using System.Net.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using PodcastIndex.Net.Endpoints.AppleReplacement;
using PodcastIndex.Net.Endpoints.Categories;
using PodcastIndex.Net.Endpoints.Episodes;
using PodcastIndex.Net.Endpoints.Hub;
using PodcastIndex.Net.Endpoints.Podcasts;
using PodcastIndex.Net.Endpoints.Recent;
using PodcastIndex.Net.Endpoints.Search;
using PodcastIndex.Net.Endpoints.Stats;
using PodcastIndex.Net.Endpoints.Value;
using PodcastIndex.Net.Middleware;

namespace PodcastIndex.Net;

public static class ServiceCollectionExtension
{
    private static ServiceCollectionConfig? PodcastIndexConfig { get; set; }

    /// <summary>
    /// </summary>
    /// <param name="services"></param>
    /// <param name="config">
    ///     Add Configuration to provide the api key, secret and user agent from your appsettings.json.
    ///     <seealso cref="PodcastIndexApiSettings" />
    ///     <remarks>
    ///         Do not add if you provide your own <see cref="PodcastIndexApiSettings" /> through
    ///         <see cref="PodcastIndexConfig" /> otherwise the data provided by the appsettings.json will get overwritten.
    ///     </remarks>
    /// </param>
    /// <param name="podcastIndexConfig"></param>
    /// <returns></returns>
    public static IServiceCollection AddPodcastIndexNet(
        this IServiceCollection services,
        IConfiguration? config = null,
        ServiceCollectionConfig? podcastIndexConfig = null
    )
    {
        if (config is not null)
        {
            services
                .AddOptions<PodcastIndexApiSettings>()
                .Bind(config.GetSection(PodcastIndexApiSettings.Section));

            ApplyApiSettings(config, podcastIndexConfig);
        }
        else
        {
            ArgumentNullException.ThrowIfNull(podcastIndexConfig);
            ArgumentNullException.ThrowIfNull(podcastIndexConfig.PodcastIndexApiSettings);

            PodcastIndexConfig = podcastIndexConfig;
            services.AddSingleton(Options.Create(PodcastIndexConfig.PodcastIndexApiSettings));
        }

        services.AddTransient<IPodcastIndex, PodcastIndex>();
        services.AddTransient<AuthHeaderHandler>();

        if (PodcastIndexConfig is null)
            ArgumentNullException.ThrowIfNull(PodcastIndexConfig);

        ConfigureRefitClients(services, PodcastIndexConfig);

        return services;
    }

    private static void ApplyApiSettings(
        IConfiguration config,
        ServiceCollectionConfig? podcastIndexConfig
    )
    {
        var apiSettings = config
            .GetSection(PodcastIndexApiSettings.Section)
            .Get<PodcastIndexApiSettings>();

        ArgumentNullException.ThrowIfNull(apiSettings);

        PodcastIndexConfig = podcastIndexConfig ?? new ServiceCollectionConfig();

        PodcastIndexConfig.PodcastIndexApiSettings = apiSettings;
    }

    private static void ConfigureRefitClients(
        IServiceCollection services,
        ServiceCollectionConfig serviceCollectionConfig
    )
    {
        services
            .AddRefitClient<ICategories>(serviceCollectionConfig.RefitSettings)
            .ConfigureHttpClient(ConfigureClient)
            .AddHttpMessageHandler<AuthHeaderHandler>()
            .SetHandlerLifetime(serviceCollectionConfig.HandlerLifetime);
        services
            .AddRefitClient<IEpisodes>(serviceCollectionConfig.RefitSettings)
            .ConfigureHttpClient(ConfigureClient)
            .AddHttpMessageHandler<AuthHeaderHandler>()
            .SetHandlerLifetime(serviceCollectionConfig.HandlerLifetime);
        services
            .AddRefitClient<IHub>(serviceCollectionConfig.RefitSettings)
            .ConfigureHttpClient(ConfigureClient)
            .AddHttpMessageHandler<AuthHeaderHandler>()
            .SetHandlerLifetime(serviceCollectionConfig.HandlerLifetime);
        services
            .AddRefitClient<IPodcasts>(serviceCollectionConfig.RefitSettings)
            .ConfigureHttpClient(ConfigureClient)
            .AddHttpMessageHandler<AuthHeaderHandler>()
            .SetHandlerLifetime(serviceCollectionConfig.HandlerLifetime);
        services
            .AddRefitClient<IRecent>(serviceCollectionConfig.RefitSettings)
            .ConfigureHttpClient(ConfigureClient)
            .AddHttpMessageHandler<AuthHeaderHandler>()
            .SetHandlerLifetime(serviceCollectionConfig.HandlerLifetime);
        services
            .AddRefitClient<ISearch>(serviceCollectionConfig.RefitSettings)
            .ConfigureHttpClient(ConfigureClient)
            .AddHttpMessageHandler<AuthHeaderHandler>()
            .SetHandlerLifetime(serviceCollectionConfig.HandlerLifetime);
        services
            .AddRefitClient<IStats>(serviceCollectionConfig.RefitSettings)
            .ConfigureHttpClient(ConfigureClient)
            .AddHttpMessageHandler<AuthHeaderHandler>()
            .SetHandlerLifetime(serviceCollectionConfig.HandlerLifetime);
        services
            .AddRefitClient<IValue>(serviceCollectionConfig.RefitSettings)
            .ConfigureHttpClient(ConfigureClient)
            .AddHttpMessageHandler<AuthHeaderHandler>()
            .SetHandlerLifetime(serviceCollectionConfig.HandlerLifetime);
        services
            .AddRefitClient<IAppleReplacement>(serviceCollectionConfig.RefitSettings)
            .ConfigureHttpClient(ConfigureClient);
    }

    private static void ConfigureClient(HttpClient client)
    {
        client.BaseAddress = PodcastIndexConfig?.PodcastIndexApiSettings?.BaseUrl;
    }
}