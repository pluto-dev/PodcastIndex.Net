using System.Net.Http;
using Refit;

namespace PodcastIndex.Tests;

public static class Helpers
{
    public static ApiResponse<T> CreateExpectedApiResponse<T>(
        string json,
        HttpStatusCode httpStatusCode = HttpStatusCode.OK
    )
    {
        var jsonSerializerOptions = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        var deserializeResponse = JsonSerializer.Deserialize<T>(json, jsonSerializerOptions);

        var expectedApiResponse = new ApiResponse<T>(
            new HttpResponseMessage(httpStatusCode),
            deserializeResponse,
            new RefitSettings()
        );
        return expectedApiResponse;
    }
}