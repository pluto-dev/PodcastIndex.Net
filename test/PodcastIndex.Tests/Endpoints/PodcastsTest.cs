using PodcastIndex.Net.Contracts.Requests.Podcasts;
using PodcastIndex.Net.Contracts.Responses.Podcasts;
using PodcastIndex.Net.Endpoints.Podcasts;
using PodcastIndex.Tests.Responses;

namespace PodcastIndex.Tests.Endpoints;

public class PodcastsTest
{
    private readonly IPodcasts _substituteClient;

    public PodcastsTest()
    {
        _substituteClient = Substitute.For<IPodcasts>();
    }

    [Fact]
    public async Task GetPodcastsByFeedIdAsync_Should_ReturnsValidResponse()
    {
        // arrange

        var id = 920666;

        var expectedApiResponse = Helpers.CreateExpectedApiResponse<PodcastsByFeedIdResponse>(
            JsonResponses.Podcasts.ByFeedId
        );

        _substituteClient
            .GetByFeedIdAsync(
                Arg.Any<int>(),
                Arg.Any<PodcastsByFeedIdRequest?>(),
                Arg.Any<CancellationToken>()
            )
            .Returns(expectedApiResponse);

        // act
        var result = await _substituteClient.GetByFeedIdAsync(id);

        // assert
        result.Should().NotBeNull();
        result.Content.Should().NotBeNull();
        result.Content?.Feed.Should().NotBeNull();
        result.Content?.Status.Should().Be(Status.True);
        result.Content?.Query.Id.Should().Be(id.ToString());
        result.Should().BeEquivalentTo(expectedApiResponse);
    }

    [Fact]
    public async Task GetPodcastsByFeedUrlAsync_Should_ReturnsValidResponse()
    {
        // arrange

        var url = new Uri("https://feeds.theincomparable.com/batmanuniversity");
        var expectedApiResponse = Helpers.CreateExpectedApiResponse<PodcastsByFeedUrlResponse>(
            JsonResponses.Podcasts.ByFeedUrl
        );

        _substituteClient
            .GetByFeedUrlAsync(
                Arg.Any<Uri>(),
                Arg.Any<PodcastsByFeedUrlRequest?>(),
                Arg.Any<CancellationToken>()
            )
            .Returns(expectedApiResponse);

        // act
        var result = await _substituteClient.GetByFeedUrlAsync(url);

        // assert
        result.Should().NotBeNull();
        result.Content.Should().NotBeNull();
        result.Content?.Feed.Should().NotBeNull();
        result.Content?.Status.Should().Be(Status.True);
        result.Content?.Query.Url.Should().Be(url);
        result.Should().BeEquivalentTo(expectedApiResponse);
    }

    [Fact]
    public async Task GetPodcastsByGuidAsync_Should_ReturnsValidResponse()
    {
        // arrange

        var guid = Guid.Parse("9b024349-ccf0-5f69-a609-6b82873eab3c");

        var expectedApiResponse = Helpers.CreateExpectedApiResponse<PodcastsByGuidResponse>(
            JsonResponses.Podcasts.ByGuid
        );

        _substituteClient
            .GetByGuidAsync(
                Arg.Any<Guid>(),
                Arg.Any<PodcastsByGuidRequest?>(),
                Arg.Any<CancellationToken>()
            )
            .Returns(expectedApiResponse);

        // act
        var result = await _substituteClient.GetByGuidAsync(guid);

        // assert
        result.Should().NotBeNull();
        result.Content.Should().NotBeNull();
        result.Content?.Feed.Should().NotBeNull();
        result.Content?.Status.Should().Be(Status.True);
        result.Content?.Query.Guid.Should().Be(guid.ToString());
        result.Should().BeEquivalentTo(expectedApiResponse);
    }

    [Fact]
    public async Task GetPodcastsByItunesIdAsync_Should_ReturnsValidResponse()
    {
        // arrange

        var id = 1441923632;

        var expectedApiResponse = Helpers.CreateExpectedApiResponse<PodcastsByItunesIdResponse>(
            JsonResponses.Podcasts.ByItunesId
        );

        _substituteClient
            .GetByItunesIdAsync(
                Arg.Any<int>(),
                Arg.Any<PodcastsByItunesIdRequest?>(),
                Arg.Any<CancellationToken>()
            )
            .Returns(expectedApiResponse);

        // act
        var result = await _substituteClient.GetByItunesIdAsync(id);

        // assert
        result.Should().NotBeNull();
        result.Content.Should().NotBeNull();
        result.Content?.Feed.Should().NotBeNull();
        result.Content?.Status.Should().Be(Status.True);
        result.Content?.Feed.ItunesId.Should().Be(id);
        result.Should().BeEquivalentTo(expectedApiResponse);
    }

    [Fact]
    public async Task GetPodcastsByMediumAsync_Should_ReturnsValidResponse()
    {
        // arrange

        var medium = Medium.Film;

        var expectedApiResponse = Helpers.CreateExpectedApiResponse<PodcastsByMediumResponse>(
            JsonResponses.Podcasts.ByMedium
        );

        _substituteClient
            .GetByMediumAsync(
                Arg.Any<Medium>(),
                Arg.Any<PodcastsByMediumRequest?>(),
                Arg.Any<CancellationToken>()
            )
            .Returns(expectedApiResponse);

        // act
        var result = await _substituteClient.GetByMediumAsync(medium);

        // assert
        result.Should().NotBeNull();
        result.Content.Should().NotBeNull();
        result.Content?.Feeds.Should().NotBeNull();
        result.Content?.Status.Should().Be(Status.True);
        result.Content?.Medium.Should().Be(Medium.Film.ToString().ToLower());
        result.Should().BeEquivalentTo(expectedApiResponse);
    }

    [Fact]
    public async Task GetPodcastsByTagAsync_Should_ReturnsValidResponse()
    {
        // arrange

        var expectedApiResponse = Helpers.CreateExpectedApiResponse<PodcastsByTagResponse>(
            JsonResponses.Podcasts.ByTag
        );

        _substituteClient
            .GetByTagAsync(
                Arg.Any<bool>(),
                Arg.Any<PodcastsByTagRequest?>(),
                Arg.Any<CancellationToken>()
            )
            .Returns(expectedApiResponse);

        // act
        var result = await _substituteClient.GetByTagAsync();

        // assert
        result.Should().NotBeNull();
        result.Content.Should().NotBeNull();
        result.Content?.Feeds.Should().NotBeNull();
        result.Content?.Status.Should().Be(Status.True);
        result.Should().BeEquivalentTo(expectedApiResponse);
    }

    [Fact]
    public async Task PodcastsDeadResponse_Should_ReturnsValidResponse()
    {
        // arrange

        var expectedApiResponse = Helpers.CreateExpectedApiResponse<PodcastsDeadResponse>(
            JsonResponses.Podcasts.Dead
        );

        _substituteClient
            .GetDeadAsync(Arg.Any<PodcastsDeadRequest?>(), Arg.Any<CancellationToken>())
            .Returns(expectedApiResponse);

        // act
        var result = await _substituteClient.GetDeadAsync();

        // assert
        result.Should().NotBeNull();
        result.Content.Should().NotBeNull();
        result.Content?.Feeds.Should().NotBeNull();
        result.Content?.Status.Should().Be(Status.True);
        result.Should().BeEquivalentTo(expectedApiResponse);
    }

    [Fact]
    public async Task GetPodcastsTrendingAsync_Should_ReturnsValidResponse()
    {
        // arrange

        var expectedApiResponse = Helpers.CreateExpectedApiResponse<PodcastsTrendingResponse>(
            JsonResponses.Podcasts.Trending
        );

        _substituteClient
            .GetTrendingAsync(Arg.Any<PodcastsTrendingRequest?>(), Arg.Any<CancellationToken>())
            .Returns(expectedApiResponse);

        // act
        var result = await _substituteClient.GetTrendingAsync();

        // assert
        result.Should().NotBeNull();
        result.Content.Should().NotBeNull();
        result.Content?.Feeds.Should().NotBeNull();
        result.Content?.Status.Should().Be(Status.True);
        result.Should().BeEquivalentTo(expectedApiResponse);
    }
}