using PodcastIndex.Net.Contracts.Requests.Stats;
using PodcastIndex.Net.Contracts.Responses.Stats;
using PodcastIndex.Net.Endpoints.Stats;
using PodcastIndex.Tests.Responses;

namespace PodcastIndex.Tests.Endpoints;

public class StatsTest
{
    [Fact]
    public async Task GetStatsCurrentAsync_Should_ReturnsValidResponse()
    {
        // arrange

        var expectedApiResponse = Helpers.CreateExpectedApiResponse<StatsCurrentResponse>(
            JsonResponses.Value.ByFeedId
        );

        var substituteClient = Substitute.For<IStats>();

        substituteClient
            ?.GetCurrentAsync(Arg.Any<StatsCurrentRequest>(), Arg.Any<CancellationToken>())
            .Returns(expectedApiResponse);

        // act
        var result = await substituteClient?.GetCurrentAsync()!;

        // assert
        result.Should().NotBeNull();
        result.Content?.Should().NotBeNull();
        result.Content?.Status.Should().Be(Status.True);
        result.Should().BeEquivalentTo(expectedApiResponse);
    }
}