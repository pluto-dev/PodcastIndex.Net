using System.Runtime.Serialization;

namespace PodcastIndex.Net.Contracts.Enums;

public enum EpisodeType
{
    [EnumMember(Value = @"full")] Full = 0,

    [EnumMember(Value = @"trailer")] Trailer = 1,

    [EnumMember(Value = @"bonus")] Bonus = 2
}