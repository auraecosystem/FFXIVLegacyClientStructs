namespace FFXIVClientStructs.Attributes;

[AttributeUsage(AttributeTargets.Method)]
public sealed class MemberFunctionAttribute : Attribute
{
    public uint Address { get; }
    public string? Signature { get; }

    public MemberFunctionAttribute(uint address)
    {
        Address = address;
    }

    public MemberFunctionAttribute(string signature)
    {
        Signature = signature;
    }
}
