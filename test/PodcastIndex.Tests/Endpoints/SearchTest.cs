using PodcastIndex.Net.Contracts.Requests.Search;
using PodcastIndex.Net.Contracts.Responses.Search;
using PodcastIndex.Net.Endpoints.Search;
using PodcastIndex.Tests.Responses;

namespace PodcastIndex.Tests.Endpoints;

public class SearchTest
{
    private readonly ISearch _substituteClient;

    public SearchTest()
    {
        _substituteClient = Substitute.For<ISearch>();
    }

    [Fact]
    public async Task GetSearchByTermAsync_Should_ReturnsValidResponse()
    {
        // arrange

        var q = "batman university";

        var expectedApiResponse = Helpers.CreateExpectedApiResponse<SearchResponse>(
            JsonResponses.Search.ByTerm
        );

        _substituteClient
            .GetByTermAsync(
                Arg.Any<string>(),
                Arg.Any<SearchByTermRequest?>(),
                Arg.Any<CancellationToken>()
            )
            .Returns(expectedApiResponse);

        // act
        var result = await _substituteClient.GetByTermAsync(q);

        // assert
        result.Should().NotBeNull();
        result.Content?.Should().NotBeNull();
        result.Content?.Feeds.Should().NotBeNull();
        result.Content?.Status.Should().Be(Status.True);
        result.Content?.Query.Should().Be(q);
        result.Should().BeEquivalentTo(expectedApiResponse);
    }

    [Fact]
    public async Task GetSearchByTitleAsync_Should_ReturnsValidResponse()
    {
        // arrange

        var q = "batman university";

        var expectedApiResponse = Helpers.CreateExpectedApiResponse<SearchResponse>(
            JsonResponses.Search.ByTitle
        );

        _substituteClient
            .GetByTitleAsync(
                Arg.Any<string>(),
                Arg.Any<SearchByTitleRequest?>(),
                Arg.Any<CancellationToken>()
            )
            .Returns(expectedApiResponse);

        // act
        var result = await _substituteClient.GetByTitleAsync(q);

        // assert
        result.Should().NotBeNull();
        result.Content?.Should().NotBeNull();
        result.Content?.Feeds.Should().NotBeNull();
        result.Content?.Status.Should().Be(Status.True);
        result.Content?.Query.Should().Be(q);
        result.Should().BeEquivalentTo(expectedApiResponse);
    }

    [Fact]
    public async Task GetSearchByPersonAsync_Should_ReturnsValidResponse()
    {
        // arrange

        var q = "adam curry";

        var expectedApiResponse = Helpers.CreateExpectedApiResponse<SearchByPersonResponse>(
            JsonResponses.Search.ByPerson
        );

        _substituteClient
            .GetByPersonAsync(
                Arg.Any<string>(),
                Arg.Any<SearchByPersonRequest?>(),
                Arg.Any<CancellationToken>()
            )
            .Returns(expectedApiResponse);

        // act
        var result = await _substituteClient.GetByPersonAsync(q);

        // assert
        result.Should().NotBeNull();
        result.Content?.Should().NotBeNull();
        result.Content?.Items.Should().NotBeNull();
        result.Content?.Status.Should().Be(Status.True);
        result.Content
            ?.Items[0].Transcripts.Should()
            .Contain(t => t.Type == TranscriptType.ApplicationSrt);
        result.Content?.Query.Should().Be(q);
        result.Should().BeEquivalentTo(expectedApiResponse);
    }

    [Fact]
    public async Task GetSearchMusicByTermAsync_Should_ReturnsValidResponse()
    {
        // arrange

        var q = "able kirby";

        var expectedApiResponse = Helpers.CreateExpectedApiResponse<SearchResponse>(
            JsonResponses.Search.MusicByTerm
        );

        _substituteClient
            .GetMusicByTermAsync(
                Arg.Any<string>(),
                Arg.Any<SearchMusicByTermRequest?>(),
                Arg.Any<CancellationToken>()
            )
            .Returns(expectedApiResponse);

        // act
        var result = await _substituteClient.GetMusicByTermAsync(q);

        // assert
        result.Should().NotBeNull();
        result.Content?.Should().NotBeNull();
        result.Content?.Feeds.Should().NotBeNull();
        result.Content?.Status.Should().Be(Status.True);
        result.Content?.Query.Should().Be(q);
        result.Should().BeEquivalentTo(expectedApiResponse);
    }
}