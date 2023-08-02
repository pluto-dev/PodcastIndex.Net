using System.Runtime.Serialization;

namespace PodcastIndex.Net.Contracts.Enums;

public enum ModelType
{
    [EnumMember(Value = @"lightning")] Lightning = 0,

    [EnumMember(Value = @"hive")] Hive = 1,

    [EnumMember(Value = @"webmonetization")]
    Webmonetization = 2
}