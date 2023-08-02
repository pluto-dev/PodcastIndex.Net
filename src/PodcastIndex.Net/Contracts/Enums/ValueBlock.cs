using System.Runtime.Serialization;

namespace PodcastIndex.Net.Contracts.Enums;

public enum ValueBlock
{
    [EnumMember(Value = @"any")] Any = 0,

    [EnumMember(Value = @"lightning")] Lightning = 1,

    [EnumMember(Value = @"hive")] Hive = 2,

    [EnumMember(Value = @"webmonetization")]
    Webmonetization = 3
}