using System.Runtime.Serialization;

namespace PodcastIndex.Net.Contracts.Enums;

public enum DestinationType
{
    [EnumMember(Value = @"node")] Node = 0
}