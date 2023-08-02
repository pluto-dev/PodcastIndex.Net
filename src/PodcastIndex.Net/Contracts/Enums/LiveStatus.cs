using System.Runtime.Serialization;

namespace PodcastIndex.Net.Contracts.Enums;

public enum LiveStatus
{
    [EnumMember(Value = @"ended")] Ended = 0,

    [EnumMember(Value = @"live")] Live = 1
}