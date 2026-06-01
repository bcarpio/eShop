namespace eShop.ServiceDefaults;

/// <summary>
/// Lightweight helper exposing a couple of typed methods used as a
/// fixture for verifying the platform's symbol-graph signature
/// extraction round-trip end-to-end.
/// </summary>
public static class SignaturesDemo
{
    public static string Greet(string name, bool loud)
    {
        return loud ? name.ToUpperInvariant() : name;
    }

    public static void Log(int code)
    {
        // intentionally empty
    }

    public static int CountKeys(System.Collections.Generic.Dictionary<string, int> map, string fallback)
    {
        return map?.Count ?? 0;
    }
}
