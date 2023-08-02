using System.Runtime.Serialization;

namespace PodcastIndex.Net.Contracts.Enums;

public enum Entity
{
    [EnumMember(Value = @"podcast")] Podcast = 0
}