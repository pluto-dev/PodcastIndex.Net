using System.Runtime.Serialization;

namespace PodcastIndex.Net.Contracts.Enums;

public enum ItunesContentAdvisoryRating
{
    [EnumMember(Value = @"Clean")] Clean = 0,

    [EnumMember(Value = @"Explicit")] Explicit = 1
}