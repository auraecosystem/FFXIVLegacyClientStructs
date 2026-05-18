namespace FFXIVClientStructs.Attributes;

[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
public sealed class FixedAddressAttribute : Attribute
{
    public uint Address { get; }
    public string? Description { get; }

    public FixedAddressAttribute(uint address, string? description = null)
    {
        Address = address;
        Description = description;
    }
}
