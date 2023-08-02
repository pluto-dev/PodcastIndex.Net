using PodcastIndex.Net.Contracts.Requests.Value;
using PodcastIndex.Net.Contracts.Responses.Value;
using PodcastIndex.Net.Endpoints.Value;
using PodcastIndex.Tests.Responses;

namespace PodcastIndex.Tests.Endpoints;

public class ValueTest
{
    private readonly IValue _substituteClient;

    public ValueTest()
    {
        _substituteClient = Substitute.For<IValue>();
    }

    [Fact]
    public async Task GetValueByFeedIdAsync_Should_ReturnsValidResponse()
    {
        // arrange

        var id = 920666;

        var expectedApiResponse = Helpers.CreateExpectedApiResponse<ValueByFeedIdResponse>(
            JsonResponses.Value.ByFeedId
        );

        _substituteClient
            .GetByFeedIdAsync(
                Arg.Any<int>(),
                Arg.Any<ValueByFeedIdRequest?>(),
                Arg.Any<CancellationToken>()
            )
            .Returns(expectedApiResponse);

        // act
        var result = await _substituteClient.GetByFeedIdAsync(id);

        // assert
        result.Should().NotBeNull();
        result.Content?.Should().NotBeNull();
        result.Content?.Status.Should().Be(Status.True);
        result.Content?.Value.Should().NotBeNull();
        result.Content?.Value.Model.Should().NotBeNull();
        result.Content?.Value.Destinations.Should().NotBeNull();
        result.Content?.Query.Id.Should().Be(id.ToString());
        result.Should().BeEquivalentTo(expectedApiResponse);
    }

    [Fact]
    public async Task GetValueByFeedUrlAsync_Should_ReturnsValidResponse()
    {
        // arrange

        var url = new Uri("https://feeds.theincomparable.com/batmanuniversity");

        var expectedApiResponse = Helpers.CreateExpectedApiResponse<ValueByFeedUrlResponse>(
            JsonResponses.Value.ByFeedUrl
        );

        _substituteClient
            .GetByFeedUrlAsync(
                Arg.Any<Uri>(),
                Arg.Any<ValueByFeedUrlRequest?>(),
                Arg.Any<CancellationToken>()
            )
            .Returns(expectedApiResponse);

        // act
        var result = await _substituteClient.GetByFeedUrlAsync(url);

        // assert
        result.Should().NotBeNull();
        result.Content?.Should().NotBeNull();
        result.Content?.Status.Should().Be(Status.True);
        result.Content?.Value.Should().NotBeNull();
        result.Content?.Value.Model.Should().NotBeNull();
        result.Content?.Value.Destinations.Should().NotBeNull();
        result.Content?.Query.Url.Should().Be(url);
        result.Should().BeEquivalentTo(expectedApiResponse);
    }
}