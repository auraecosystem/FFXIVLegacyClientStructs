namespace FFXIVClientStructs.Attributes;

[AttributeUsage(AttributeTargets.Struct | AttributeTargets.Field | AttributeTargets.Method)]
public sealed class GameVersionAttribute : Attribute
{
    public string Version { get; }

    public GameVersionAttribute(string version = "2012.09.19.0001")
    {
        Version = version;
    }
}
