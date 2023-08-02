using System.Runtime.Serialization;

namespace PodcastIndex.Net.Contracts.Enums;

public enum TranscriptType
{
    [EnumMember(Value = @"application/json")]
    ApplicationJson = 0,

    [EnumMember(Value = @"application/srt")]
    ApplicationSrt = 1,

    [EnumMember(Value = @"text/html")] TextHtml = 2,

    [EnumMember(Value = @"text/plain")] TextPlain = 3,

    [EnumMember(Value = @"text/srt")] TextSrt = 4,

    [EnumMember(Value = @"text/vtt")] TextVtt = 5
}