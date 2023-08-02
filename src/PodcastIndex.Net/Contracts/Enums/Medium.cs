using System.Runtime.Serialization;

namespace PodcastIndex.Net.Contracts.Enums;

public enum Medium
{
    [EnumMember(Value = @"audiobook")] Audiobook = 0,

    [EnumMember(Value = @"blog")] Blog = 1,

    [EnumMember(Value = @"film")] Film = 2,

    [EnumMember(Value = @"music")] Music = 3,

    [EnumMember(Value = @"newsletter")] Newsletter = 4,

    [EnumMember(Value = @"podcast")] Podcast = 5,

    [EnumMember(Value = @"video")] Video = 6
}