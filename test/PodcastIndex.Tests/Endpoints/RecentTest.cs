using PodcastIndex.Net.Contracts.Requests.Recent;
using PodcastIndex.Net.Contracts.Responses.Recent;
using PodcastIndex.Net.Endpoints.Recent;
using PodcastIndex.Tests.Responses;

namespace PodcastIndex.Tests.Endpoints;

public class RecentTest
{
    private readonly IRecent _substituteClient;

    public RecentTest()
    {
        _substituteClient = Substitute.For<IRecent>();
    }

    [Fact]
    public async Task GetRecentDataAsync_Should_ReturnValidResponse()
    {
        // arrange

        var expectedApiResponse = Helpers.CreateExpectedApiResponse<RecentDataResponse>(
            JsonResponses.Recent.Data
        );

        _substituteClient
            .GetDataAsync(Arg.Any<RecentDataRequest?>(), Arg.Any<CancellationToken>())
            .Returns(expectedApiResponse);

        // act

        var result = await _substituteClient.GetDataAsync();

        // assert

        result.Should().NotBeNull();
        result.Content?.Should().NotBeNull();
        result.Content?.Status.Should().Be(Status.True);
        result.Content?.Data.Should().NotBeNull();
        result.Content?.Data.Feeds.Should().NotBeNull();
        result.Content?.Data.Items.Should().NotBeNull();
        result.Should().BeEquivalentTo(expectedApiResponse);
    }

    [Fact]
    public async Task GetRecentEpisodesAsync_Should_ReturnValidResponse()
    {
        // arrange

        var expectedApiResponse = Helpers.CreateExpectedApiResponse<RecentEpisodesResponse>(
            JsonResponses.Recent.RecentEpisodes
        );

        _substituteClient
            .GetEpisodesAsync(Arg.Any<RecentEpisodesRequest?>(), Arg.Any<CancellationToken>())
            .Returns(expectedApiResponse);

        // act

        var result = await _substituteClient.GetEpisodesAsync();

        // assert

        result.Should().NotBeNull();
        result.Content?.Should().NotBeNull();
        result.Content?.Items.Should().NotBeNull();
        result.Content?.Status.Should().Be(Status.True);
        result.Should().BeEquivalentTo(expectedApiResponse);
    }

    [Fact]
    public async Task GetRecentFeedsAsync_Should_ReturnValidResponse()
    {
        // arrange

        var expectedApiResponse = Helpers.CreateExpectedApiResponse<RecentFeedsResponse>(
            JsonResponses.Recent.Feeds
        );

        _substituteClient
            .GetFeedsAsync(Arg.Any<RecentFeedsRequest?>(), Arg.Any<CancellationToken>())
            .Returns(expectedApiResponse);

        // act

        var result = await _substituteClient.GetFeedsAsync();

        // assert

        result.Should().NotBeNull();
        result.Content?.Should().NotBeNull();
        result.Content?.Feeds.Should().NotBeNull();
        result.Content?.Status.Should().Be(Status.True);
        result.Should().BeEquivalentTo(expectedApiResponse);
    }

    [Fact]
    public async Task GetRecentNewFeedsAsync_Should_ReturnValidResponse()
    {
        // arrange

        var expectedApiResponse = Helpers.CreateExpectedApiResponse<RecentNewFeedsResponse>(
            JsonResponses.Recent.NewFeeds
        );

        _substituteClient
            .GetNewFeedsAsync(Arg.Any<RecentNewFeedsRequest?>(), Arg.Any<CancellationToken>())
            .Returns(expectedApiResponse);

        // act

        var result = await _substituteClient.GetNewFeedsAsync();

        // assert

        result.Should().NotBeNull();
        result.Content?.Should().NotBeNull();
        result.Content?.Feeds.Should().NotBeNull();
        result.Content?.Status.Should().Be(Status.True);
        result.Should().BeEquivalentTo(expectedApiResponse);
    }

    [Fact]
    public async Task GetRecentSoundbitesAsync_Should_ReturnValidResponse()
    {
        // arrange

        var expectedApiResponse = Helpers.CreateExpectedApiResponse<RecentSoundbitesResponse>(
            JsonResponses.Recent.Soundbites
        );

        _substituteClient
            .GetSoundbitesAsync(Arg.Any<RecentSoundbitesRequest?>(), Arg.Any<CancellationToken>())
            .Returns(expectedApiResponse);

        // act

        var result = await _substituteClient.GetSoundbitesAsync();

        // assert

        result.Should().NotBeNull();
        result.Content?.Should().NotBeNull();
        result.Content?.Items.Should().NotBeNull();
        result.Content?.Status.Should().Be(Status.True);
        result.Should().BeEquivalentTo(expectedApiResponse);
    }
}