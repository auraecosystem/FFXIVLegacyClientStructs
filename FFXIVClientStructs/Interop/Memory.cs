using System.Runtime.InteropServices;

namespace FFXIVClientStructs.Interop;

public static unsafe class Memory
{
    [DllImport("kernel32.dll", SetLastError = true)]
    public static extern bool ReadProcessMemory(
        nint hProcess, nint lpBaseAddress, byte* lpBuffer, nuint nSize, out nuint lpNumberOfBytesRead);

    [DllImport("kernel32.dll", SetLastError = true)]
    public static extern bool WriteProcessMemory(
        nint hProcess, nint lpBaseAddress, byte* lpBuffer, nuint nSize, out nuint lpNumberOfBytesWritten);

    [DllImport("kernel32.dll", SetLastError = true)]
    public static extern bool VirtualProtectEx(
        nint hProcess, nint lpAddress, nuint dwSize, uint flNewProtect, out uint lpflOldProtect);

    [DllImport("kernel32.dll")]
    public static extern nint OpenProcess(uint dwDesiredAccess, bool bInheritHandle, int dwProcessId);

    [DllImport("kernel32.dll")]
    public static extern bool CloseHandle(nint hObject);

    public const uint PROCESS_ALL_ACCESS = 0x1F0FFF;
    public const uint PAGE_EXECUTE_READWRITE = 0x40;

    public static T Read<T>(nint address) where T : unmanaged
    {
        return *(T*)address;
    }

    public static void Write<T>(nint address, T value) where T : unmanaged
    {
        *(T*)address = value;
    }

    public static string ReadCString(nint address, int maxLength = 256)
    {
        return Marshal.PtrToStringAnsi(address, maxLength)?.TrimEnd('\0') ?? string.Empty;
    }
}
