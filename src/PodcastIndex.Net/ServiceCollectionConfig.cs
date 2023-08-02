using System;
using System.Net.Http;
using System.Threading;

namespace PodcastIndex.Net;

/// <summary>
///     Custom configuration.
/// </summary>
/// <remarks>
///     <para>Default configuration will be provide if no custom configuration is provided.</para>
/// </remarks>
public class ServiceCollectionConfig
{
    public ServiceCollectionConfig()
    {
        HandlerLifetime = TimeSpan.FromMinutes(2);
    }

    /// <summary>
    ///     Custom Refit settings.
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <see cref="JsonSerializerOptions.PropertyNameCaseInsensitive" /> property of
    ///         <see cref="JsonSerializerOptions" />
    ///         should to be set to <code>true</code> otherwise the deserialization wont work.
    ///         The default is <code>true</code>
    ///     </para>
    /// </remarks>
    public RefitSettings? RefitSettings { get; set; }

    public PodcastIndexApiSettings? PodcastIndexApiSettings { get; set; }

    /// <summary>
    ///     Sets the length of time that a <see cref="HttpMessageHandler" /> instance can be reused. Each named
    ///     client can have its own configured handler lifetime value. The default value is two minutes. Set the lifetime to
    ///     <see cref="Timeout.InfiniteTimeSpan" /> to disable handler expiry.
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The default implementation of <see cref="IHttpClientFactory" /> will pool the <see cref="HttpMessageHandler" />
    ///         instances created by the factory to reduce resource consumption. This setting configures the amount of time
    ///         a handler can be pooled before it is scheduled for removal from the pool and disposal.
    ///     </para>
    ///     <para>
    ///         Pooling of handlers is desirable as each handler typically manages its own underlying HTTP connections;
    ///         creating
    ///         more handlers than necessary can result in connection delays. Some handlers also keep connections open
    ///         indefinitely
    ///         which can prevent the handler from reacting to DNS changes. The value of handlerLifetime should be
    ///         chosen with an understanding of the application's requirement to respond to changes in the network environment.
    ///     </para>
    ///     <para>
    ///         Expiry of a handler will not immediately dispose the handler. An expired handler is placed in a separate pool
    ///         which is processed at intervals to dispose handlers only when they become unreachable. Using long-lived
    ///         <see cref="HttpClient" /> instances will prevent the underlying <see cref="HttpMessageHandler" /> from being
    ///         disposed until all references are garbage-collected.
    ///     </para>
    /// </remarks>
    public TimeSpan HandlerLifetime { get; set; }
}