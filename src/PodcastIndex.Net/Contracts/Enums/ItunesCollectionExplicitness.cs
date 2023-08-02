using System.Runtime.Serialization;

namespace PodcastIndex.Net.Contracts.Enums;

public enum ItunesCollectionExplicitness
{
    [EnumMember(Value = @"explicit")] Explicit = 0,

    [EnumMember(Value = @"cleaned")] Cleaned = 1
}