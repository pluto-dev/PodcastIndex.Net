namespace PodcastIndex.Net.Contracts.Requests;

public class BaseRequest
{
    /// <summary>
    ///     If present, makes the output “pretty” to help with debugging.
    ///     <br />
    ///     Parameter shall not have a value
    /// </summary>
    [AliasAs("pretty")]
    public bool? Pretty { get; set; }
}