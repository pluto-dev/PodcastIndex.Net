using PodcastIndex.Net.Contracts.Requests.Categories;
using PodcastIndex.Net.Contracts.Responses.Categories;
using PodcastIndex.Net.Endpoints.Categories;
using PodcastIndex.Tests.Responses;

namespace PodcastIndex.Tests.Endpoints;

public class CategoriesTest
{
    [Fact]
    public async Task GetCategoriesListAsync_Should_ReturnsValidResponse()
    {
        // arrange
        var expectedApiResponse = Helpers.CreateExpectedApiResponse<CategoriesListResponse>(
            JsonResponses.Categories.List
        );

        var substitute = Substitute.For<ICategories>();

        substitute
            .GetListAsync(Arg.Any<CategoriesListRequest>(), Arg.Any<CancellationToken>())
            .Returns(expectedApiResponse);

        // act
        var result = await substitute.GetListAsync();

        // assert
        result.Should().NotBeNull();
        result.Content?.Status.Should().Be(Status.True);
        result.Content.Should().NotBeNull();
        result.StatusCode.Should().Be(HttpStatusCode.OK);
        result.Should().BeEquivalentTo(expectedApiResponse);
    }
}