using System.Diagnostics;
using System.Runtime.InteropServices;

namespace FFXIVClientStructs.Interop;

public unsafe class SignatureScanner
{
    private readonly byte* _baseAddress;
    private readonly int _size;

    public SignatureScanner(nint moduleBase, int moduleSize)
    {
        _baseAddress = (byte*)moduleBase;
        _size = moduleSize;
    }

    public static SignatureScanner FromProcess(string processName = "ffxivgame")
    {
        var proc = Process.GetProcessesByName(processName).FirstOrDefault()
            ?? throw new InvalidOperationException($"Process '{processName}' not found");
        var module = proc.MainModule
            ?? throw new InvalidOperationException("Cannot access main module");
        return new SignatureScanner(module.BaseAddress, module.ModuleMemorySize);
    }

    public nint ScanText(string signature)
    {
        var (pattern, mask) = ParseSignature(signature);
        var textOffset = (int)(GameInfo.TextStart - GameInfo.ImageBase);
        var textSize = (int)(GameInfo.TextEnd - GameInfo.TextStart);
        return Scan(_baseAddress + textOffset, textSize, pattern, mask);
    }

    public nint ScanData(string signature)
    {
        var (pattern, mask) = ParseSignature(signature);
        var dataOffset = (int)(GameInfo.RdataStart - GameInfo.ImageBase);
        var dataSize = (int)(GameInfo.DataEnd - GameInfo.RdataStart);
        return Scan(_baseAddress + dataOffset, dataSize, pattern, mask);
    }

    public nint ScanModule(string signature)
    {
        var (pattern, mask) = ParseSignature(signature);
        return Scan(_baseAddress, _size, pattern, mask);
    }

    public nint GetStaticAddress(uint va)
    {
        return (nint)(_baseAddress + (va - GameInfo.ImageBase));
    }

    private static nint Scan(byte* start, int size, byte[] pattern, bool[] mask)
    {
        var patLen = pattern.Length;
        var end = size - patLen;

        for (var i = 0; i <= end; i++)
        {
            var found = true;
            for (var j = 0; j < patLen; j++)
            {
                if (mask[j] && start[i + j] != pattern[j])
                {
                    found = false;
                    break;
                }
            }
            if (found)
                return (nint)(start + i);
        }

        return nint.Zero;
    }

    private static (byte[] pattern, bool[] mask) ParseSignature(string sig)
    {
        var tokens = sig.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        var pattern = new byte[tokens.Length];
        var mask = new bool[tokens.Length];

        for (var i = 0; i < tokens.Length; i++)
        {
            if (tokens[i] == "??" || tokens[i] == "?")
            {
                pattern[i] = 0;
                mask[i] = false;
            }
            else
            {
                pattern[i] = Convert.ToByte(tokens[i], 16);
                mask[i] = true;
            }
        }

        return (pattern, mask);
    }
}
