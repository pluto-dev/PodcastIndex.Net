using PodcastIndex.Net.Contracts.Requests.Hub;
using PodcastIndex.Net.Contracts.Responses.Hub;
using PodcastIndex.Net.Endpoints.Hub;
using PodcastIndex.Tests.Responses;

namespace PodcastIndex.Tests.Endpoints;

public class HubTest
{
    [Fact]
    public async Task GetHubPubNotifyAsync_Should_ReturnsValidResponse()
    {
        // arrange

        var id = 75075;

        var expectedApiResponse = Helpers.CreateExpectedApiResponse<HubPubNotifyResponse>(
            JsonResponses.Hub.PubNotify
        );

        var substitute = Substitute.For<IHub>();

        substitute
            ?.GetPubNotifyAsync(Arg.Any<HubPubNotifyRequest>(), Arg.Any<CancellationToken>())
            .Returns(expectedApiResponse);

        // act
        var result = await substitute?.GetPubNotifyAsync(new HubPubNotifyRequest(id))!;

        // assert
        result.Should().NotBeNull();
        result.Content.Should().NotBeNull();
        result.Content?.Description.Should().Be("Found matching feed");
        result.Content?.Status.Should().Be(Status.True);
        result.Should().BeEquivalentTo(expectedApiResponse);
    }
}