namespace FFXIVClientStructs.Interop;

public static class GameInfo
{
    public const string GameVersion = "2012.09.19.0001";
    public const string BootVersion = "2010.09.18.0000";
    public const uint ImageBase = 0x00400000;
    public const uint SizeOfImage = 0x00F99000;
    public const uint EntryPointRVA = 0x005D4BAA;
    public const string Architecture = "x86";

    public const uint TextStart = 0x00401000;
    public const uint TextEnd = 0x00F3C56D;
    public const uint RdataStart = 0x00F3E000;
    public const uint RdataEnd = 0x01264032;
    public const uint DataStart = 0x01265000;
    public const uint DataEnd = 0x0137C940;

    public static uint RvaToVa(uint rva) => ImageBase + rva;
    public static uint VaToRva(uint va) => va - ImageBase;
}
