using System.Runtime.Serialization;

namespace PodcastIndex.Net.Contracts.Enums;

public enum SocialInteractProtocol
{
    [EnumMember(Value = @"disabled")] Disabled = 0,

    [EnumMember(Value = @"activitypub")] Activitypub = 1,

    [EnumMember(Value = @"twitter")] Twitter = 2,

    [EnumMember(Value = @"lightning")] Lightning = 3
}