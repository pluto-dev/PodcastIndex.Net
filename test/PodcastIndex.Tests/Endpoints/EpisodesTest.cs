using PodcastIndex.Net.Contracts.Requests.Episodes;
using PodcastIndex.Net.Contracts.Responses.Episodes;
using PodcastIndex.Net.Endpoints.Episodes;
using PodcastIndex.Tests.Responses;

namespace PodcastIndex.Tests.Endpoints;

public class EpisodesTest
{
    private readonly IEpisodes? _substitute;

    public EpisodesTest()
    {
        _substitute = Substitute.For<IEpisodes>();
    }

    [Fact]
    public async Task GetEpisodesByFeedIdAsync_Should_ReturnsValidResponse()
    {
        // arrange

        var id = "75075";

        var expectedApiResponse = Helpers.CreateExpectedApiResponse<EpisodesByFeedIdResponse>(
            JsonResponses.Episodes.ByFeedId
        );

        _substitute
            ?.GetByFeedIdAsync(
                Arg.Any<string[]?>(),
                Arg.Any<EpisodesByFeedIdRequest?>(),
                Arg.Any<CancellationToken>()
            )
            .Returns(expectedApiResponse);

        // act
        var result = await _substitute?.GetByFeedIdAsync(new[] { id })!;

        // assert
        result.Should().NotBeNull();
        result.Content?.Items[0].Transcripts.Should().NotBeNull();
        result.Content
            ?.Items[0].Transcripts.Should()
            .Contain(t => t.Type == TranscriptType.ApplicationSrt);
        result.Content?.Should().NotBeNull();
        result.Content?.Status.Should().Be(Status.True);
        result.Content?.Query.Should().ContainEquivalentOf(id);
        result.StatusCode.Should().Be(HttpStatusCode.OK);
        result.Should().BeEquivalentTo(expectedApiResponse);
    }

    [Fact]
    public async Task GetEpisodesByFeedUrlAsync_Should_ReturnsValidResponse()
    {
        // arrange

        var url = new Uri("https://feeds.theincomparable.com/batmanuniversity");

        var expectedApiResponse = Helpers.CreateExpectedApiResponse<EpisodesByFeedUrlResponse>(
            JsonResponses.Episodes.ByFeedUrl
        );

        _substitute
            ?.GetByFeedUrlAsync(
                Arg.Any<Uri>(),
                Arg.Any<EpisodesByFeedUrlRequest?>(),
                Arg.Any<CancellationToken>()
            )
            .Returns(expectedApiResponse);

        // act
        var result = await _substitute?.GetByFeedUrlAsync(url)!;

        // assert
        result.Should().NotBeNull();
        result.Content.Should().NotBeNull();
        result.Content?.Items[0].Transcripts.Should().NotBeNull();
        result.Content
            ?.Items[0].Transcripts.Should()
            .Contain(t => t.Type == TranscriptType.ApplicationSrt);
        result.Content?.Status.Should().Be(Status.True);
        result.Content?.Query.Url.Should().Be(url);
        result.StatusCode.Should().Be(HttpStatusCode.OK);
        result.Should().BeEquivalentTo(expectedApiResponse);
    }

    [Fact]
    public async Task GetEpisodesByGuidAsync_Should_ReturnsValidResponse()
    {
        // arrange

        var guid = "PC2084";

        var expectedApiResponse = Helpers.CreateExpectedApiResponse<EpisodesByGuidResponse>(
            JsonResponses.Episodes.ByGuid
        );

        _substitute
            ?.GetByGuidAsync(
                Arg.Any<string>(),
                Arg.Any<EpisodesByGuidRequest>(),
                Arg.Any<CancellationToken>()
            )
            .Returns(expectedApiResponse);

        // act
        var result = await _substitute?.GetByGuidAsync(guid)!;

        // assert
        result.Should().NotBeNull();
        result.Content.Should().NotBeNull();
        result.Content?.Episode.Transcripts.Should().NotBeNull();
        result.Content?.Episode.Transcripts
            .Should()
            .Contain(t => t.Type == TranscriptType.ApplicationSrt);
        result.Content?.Guid.Should().Be(guid);
        result.Content?.Status.Should().Be(Status.True);
        result.StatusCode.Should().Be(HttpStatusCode.OK);
        result.Should().BeEquivalentTo(expectedApiResponse);
    }

    [Fact]
    public async Task GetEpisodesByIdAsync_Should_ReturnsValidResponse()
    {
        // arrange

        var id = 16795088;

        var expectedApiResponse = Helpers.CreateExpectedApiResponse<EpisodesByIdResponse>(
            JsonResponses.Episodes.ById
        );

        _substitute
            ?.GetByIdAsync(
                Arg.Any<int>(),
                Arg.Any<EpisodesByIdRequest>(),
                Arg.Any<CancellationToken>()
            )
            .Returns(expectedApiResponse);

        // act
        var result = await _substitute?.GetByIdAsync(id)!;

        // assert
        result.Should().NotBeNull();
        result.Content.Should().NotBeNull();
        result.Content?.Episode?.Transcripts.Should().NotBeNull();
        result.Content
            ?.Episode?.Transcripts.Should()
            .Contain(t => t.Type == TranscriptType.ApplicationSrt);
        result.Content?.Id.Should().Be(id);
        result.Content?.Status.Should().Be(Status.True);
        result.StatusCode.Should().Be(HttpStatusCode.OK);
        result.Should().BeEquivalentTo(expectedApiResponse);
    }

    [Fact]
    public async Task GetEpisodesByItunesIdAsync_Should_ReturnsValidResponse()
    {
        // arrange

        var iTunesId = 1441923632;

        var expectedApiResponse = Helpers.CreateExpectedApiResponse<EpisodesByItunesIdResponse>(
            JsonResponses.Episodes.ByItunesId
        );

        _substitute
            ?.GetByItunesIdAsync(
                Arg.Any<int>(),
                Arg.Any<EpisodesByItunesIdRequest>(),
                Arg.Any<CancellationToken>()
            )
            .Returns(expectedApiResponse);

        // act
        var result = await _substitute?.GetByItunesIdAsync(iTunesId)!;

        // assert

        result.Should().NotBeNull();
        result.Content.Should().NotBeNull();
        result.Content?.Items?[0].Transcripts.Should().NotBeNull();
        result.Content
            ?.Items?[0].Transcripts.Should()
            .Contain(t => t.Type == TranscriptType.ApplicationSrt);
        result.Content?.Query.Should().Be(iTunesId.ToString());
        result.Content?.Status.Should().Be(Status.True);
        result.Content?.Items.Should().ContainSingle(i => i.FeedItunesId == iTunesId);
        result.StatusCode.Should().Be(HttpStatusCode.OK);
        result.Should().BeEquivalentTo(expectedApiResponse);
    }

    [Fact]
    public async Task GetEpisodesByPodcastGuidAsync_Should_ReturnsValidResponse()
    {
        // arrange

        var guid = Guid.Parse("9b024349-ccf0-5f69-a609-6b82873eab3c");

        var expectedApiResponse = Helpers.CreateExpectedApiResponse<EpisodesByPodcastGuidResponse>(
            JsonResponses.Episodes.ByPodcastGuid
        );

        _substitute
            ?.GetByPodcastGuidAsync(
                Arg.Any<Guid>(),
                Arg.Any<EpisodesByPodcastGuidRequest>(),
                Arg.Any<CancellationToken>()
            )
            .Returns(expectedApiResponse);

        // act
        var result = await _substitute?.GetByPodcastGuidAsync(guid)!;

        // assert
        // BUG The schema says it's an URL but we get back an int
        // result.Content?.Query.Should().Be(guid);

        result.Should().NotBeNull();
        result.Content.Should().NotBeNull();
        result.Content?.Items[0].Transcripts.Should().NotBeNull();
        result.Content
            ?.Items[0].Transcripts.Should()
            .Contain(t => t.Type == TranscriptType.ApplicationSrt);
        result.Content?.Status.Should().Be(Status.True);
        result.StatusCode.Should().Be(HttpStatusCode.OK);
        result.Should().BeEquivalentTo(expectedApiResponse);
    }

    [Fact]
    public async Task GetEpisodesLiveAsync_Should_ReturnsValidResponse()
    {
        // arrange

        var expectedApiResponse = Helpers.CreateExpectedApiResponse<EpisodesLiveResponse>(
            JsonResponses.Episodes.Live
        );

        _substitute
            ?.GetLiveAsync(Arg.Any<EpisodesLiveRequest>(), Arg.Any<CancellationToken>())
            .Returns(expectedApiResponse);

        // act
        var result = await _substitute?.GetLiveAsync()!;

        // assert
        result.Should().NotBeNull();
        result.Content.Should().NotBeNull();
        result.Content?.Items.Should().NotBeNull();
        result.Content?.Status.Should().Be(Status.True);
        result.StatusCode.Should().Be(HttpStatusCode.OK);
        result.Should().BeEquivalentTo(expectedApiResponse);
    }

    [Fact]
    public async Task GetEpisodesRandomAsync_Should_ReturnsValidResponse()
    {
        // arrange

        var expectedApiResponse = Helpers.CreateExpectedApiResponse<EpisodesRandomResponse>(
            JsonResponses.Episodes.Random
        );

        _substitute
            ?.GetRandomAsync(Arg.Any<EpisodesRandomRequest>(), Arg.Any<CancellationToken>())
            .Returns(expectedApiResponse);

        // act
        var result = await _substitute?.GetRandomAsync()!;

        // assert
        result.Should().NotBeNull();
        result.Content.Should().NotBeNull();
        result.Content?.Episodes.Should().NotBeNull();
        result.Content?.Status.Should().Be(Status.True);
        result.StatusCode.Should().Be(HttpStatusCode.OK);
        result.Should().BeEquivalentTo(expectedApiResponse);
    }
}