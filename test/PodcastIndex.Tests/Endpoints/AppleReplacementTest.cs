using PodcastIndex.Net.Contracts.Requests.AppleReplacement;
using PodcastIndex.Net.Contracts.Responses.AppleReplacement;
using PodcastIndex.Net.Endpoints.AppleReplacement;
using PodcastIndex.Tests.Responses;

namespace PodcastIndex.Tests.Endpoints;

public class AppleReplacementTest
{
    private readonly IAppleReplacement _substituteClient;

    public AppleReplacementTest()
    {
        _substituteClient = Substitute.For<IAppleReplacement>();
    }

    [Fact]
    public async Task Search_Should_ReturnsValidResponse()
    {
        // arrange
        var term = "batman";

        var expectedApiResponse = Helpers.CreateExpectedApiResponse<AppleReplacementResponse>(
            JsonResponses.AppleReplacement.Search
        );

        _substituteClient
            .Search(
                Arg.Any<string>(),
                Arg.Any<AppleReplacementSearchRequest?>(),
                Arg.Any<CancellationToken>()
            )
            .Returns(expectedApiResponse);

        // act
        var result = await _substituteClient.Search(term);

        // assert
        result.Should().NotBeNull();
        result.StatusCode.Should().Be(HttpStatusCode.OK);
        result.Content?.Should().NotBeNull();
        result.Content?.Results.Should().NotBeNull();
        result.Content?.Results[0].Should().NotBeNull();
        result.Content?.Results[0].CollectionName.Should().ContainEquivalentOf(term);
        result.Should().BeEquivalentTo(expectedApiResponse);
    }

    [Fact]
    public async Task Lookup_Should_ReturnsValidResponse()
    {
        // arrange
        var id = 1441923632;
        var entity = Entity.Podcast;

        var expectedApiResponse = Helpers.CreateExpectedApiResponse<AppleReplacementResponse>(
            JsonResponses.AppleReplacement.Lookup
        );

        _substituteClient
            .Lookup(
                Arg.Any<int>(),
                Arg.Any<Entity>(),
                Arg.Any<AppleReplacementLookupRequest?>(),
                Arg.Any<CancellationToken>()
            )
            .Returns(expectedApiResponse);

        // act
        var result = await _substituteClient.Lookup(id, entity);

        // assert
        result.Should().NotBeNull();
        result.StatusCode.Should().Be(HttpStatusCode.OK);
        result.Content?.Should().NotBeNull();
        result.Content?.Results.Should().NotBeNull();
        result.Content?.Results[0].Kind.Should().Be(Enum.GetName(entity)!.ToLower());
        result.Content?.Results[0].CollectionId.Should().Be(id);
        result.Content?.Results[0].TrackId.Should().Be(id);
        result.Should().BeEquivalentTo(expectedApiResponse);
    }
}