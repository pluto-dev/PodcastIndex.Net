using System.Runtime.Serialization;

namespace PodcastIndex.Net.Contracts.Enums;

public enum FeedStatus
{
    [EnumMember(Value = @"unconfirmed")] Unconfirmed = 0,

    [EnumMember(Value = @"confirmed")] Confirmed = 1
}