using System;
using System.Security.Cryptography;
using System.Text;

namespace PodcastIndex.Net;

public static class Helpers
{
    /// <summary>
    ///     API Key (Authorization)
    ///     <br />
    ///     A SHA-1 hash of the X-Auth-Key, the corresponding secret and the X-Auth-Date value concatenated as a string. The
    ///     resulting hash should be encoded as a hexadecimal value, two digits per byte, using lower case letters for the hex
    ///     digits "a" through "f".
    ///     <br />
    ///     The Authorization header is computed with something like this (pseudo-code):
    ///     <code>
    /// authHeader = sha1(apiKey+apiSecret+unixTime)
    /// </code>
    /// </summary>
    /// <param name="apiKey">Api Key</param>
    /// <param name="apiSecret">Api Secret</param>
    /// <param name="timestamp">Unix timestamp</param>
    /// <returns>Returns the computed SHA1 hash.</returns>
    public static string CreateAuthorizationToken(
        string? apiKey,
        string? apiSecret,
        string? timestamp
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(apiKey);
        ArgumentException.ThrowIfNullOrEmpty(apiSecret);
        ArgumentException.ThrowIfNullOrEmpty(timestamp);

        return Convert
            .ToHexString(SHA1.HashData(Encoding.UTF8.GetBytes($"{apiKey}{apiSecret}{timestamp}")))
            .ToLower();
    }
}