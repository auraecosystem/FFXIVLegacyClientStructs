namespace FFXIVClientStructs.Attributes;

[AttributeUsage(AttributeTargets.Method)]
public sealed class VirtualFunctionAttribute : Attribute
{
    public int Index { get; }

    public VirtualFunctionAttribute(int index)
    {
        Index = index;
    }
}
