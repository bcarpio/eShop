namespace eShop.ServiceDefaults;

/// <summary>
/// Static build/version metadata for the eShop services.
/// Exposed so health-check and admin endpoints can surface a single
/// canonical version string without each service hard-coding its own.
/// </summary>
public static class BuildInfo
{
    public const string Version = "1.0.0-ha-test";

    public static readonly DateTime BuiltAtUtc = DateTime.UtcNow;

    public static string Describe() => $"eShop {Version} (started {BuiltAtUtc:O})";
}
