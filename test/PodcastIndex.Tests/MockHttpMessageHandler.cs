using System.Net.Http;

namespace PodcastIndex.Tests;

public class MockHttpMessageHandler : HttpMessageHandler
{
    private readonly HttpResponseMessage? _response;
    private readonly HttpStatusCode _statusCode;

    public MockHttpMessageHandler(HttpResponseMessage? response)
    {
        _response = response;
    }

    public MockHttpMessageHandler(HttpStatusCode statusCode)
    {
        _statusCode = statusCode;
    }

    protected override Task<HttpResponseMessage> SendAsync(
        HttpRequestMessage request,
        CancellationToken cancellationToken
    )
    {
        if (_response is not null)
            return Task.FromResult(
                new HttpResponseMessage
                {
                    RequestMessage = request,
                    StatusCode = _response.StatusCode,
                    Content = _response.Content
                }
            );

        return Task.FromResult(
            new HttpResponseMessage { RequestMessage = request, StatusCode = _statusCode }
        );
    }
}