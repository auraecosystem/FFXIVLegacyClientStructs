namespace FFXIVClientStructs.Attributes;

[AttributeUsage(AttributeTargets.Struct)]
public sealed class RttiAttribute : Attribute
{
    public string MangledName { get; }

    public RttiAttribute(string mangledName)
    {
        MangledName = mangledName;
    }
}
