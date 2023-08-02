using System.Runtime.Serialization;

namespace PodcastIndex.Net.Contracts.Enums;

/// <summary>
///     Indicates API request status
///     <br />
/// </summary>
public enum Status
{
    [EnumMember(Value = @"true")] True = 0,

    [EnumMember(Value = @"false")] False = 1
}