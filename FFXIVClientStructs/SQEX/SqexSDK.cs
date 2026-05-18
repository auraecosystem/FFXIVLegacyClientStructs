using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.Sqex;

[Rtti(".?AVCDevMedia@CDev@Sqex@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct CDev_CDevMedia
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0110DF04 (1 vfunc)
}

[Rtti(".?AVCert@Crypt@Sqex@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct Crypt_Cert
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00F6738C (2 vfuncs)
}

[Rtti(".?AVCrc32@Crypt@Sqex@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct Crypt_Crc32
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0111280C (1 vfunc)
}

[Rtti(".?AVCryptInterface@Crypt@Sqex@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct Crypt_CryptInterface
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00F909D4 (3 vfuncs)
}

[Rtti(".?AVShuffleString@Crypt@Sqex@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct Crypt_ShuffleString
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01108BE0 (3 vfuncs)
}

[Rtti(".?AVSimpleString@Crypt@Sqex@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct Crypt_SimpleString
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00F90A40 (3 vfuncs)
}

[Rtti(".?AVBlockMemory@Data@Sqex@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct Data_BlockMemory
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0110C7F0 (1 vfunc)
}

[Rtti(".?AVPackRead@Data@Sqex@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct Data_PackRead
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0110DD40 (11 vfuncs)
}

[Rtti(".?AVPackWrite@Data@Sqex@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct Data_PackWrite
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0111311C (1 vfunc)
}

[Rtti(".?AVDivFile@File@Sqex@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct File_DivFile
{
    [FieldOffset(0x0000)] public nint VTable; // 0x011130FC (1 vfunc)
}

[Rtti(".?AVExecuteFunctionCopy@LocalDir@File@Sqex@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct File_LocalDir_ExecuteFunctionCopy
{
    [FieldOffset(0x0000)] public nint VTable; // 0x011107A4 (3 vfuncs)
}

[Rtti(".?AVExecuteFunctionFind@LocalDir@File@Sqex@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct File_LocalDir_ExecuteFunctionFind
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01110794 (3 vfuncs)
}

[Rtti(".?AVExecuteFunctionInterface@LocalDir@File@Sqex@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct File_LocalDir_ExecuteFunctionInterface
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01110774 (3 vfuncs)
}

[Rtti(".?AVExecuteFunctionRemove@LocalDir@File@Sqex@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct File_LocalDir_ExecuteFunctionRemove
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01110784 (3 vfuncs)
}

[Rtti(".?AVLocalFile@File@Sqex@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct File_LocalFile
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00F676F4 (1 vfunc)
}

[Rtti(".?AVIHandledPtr<FileData>@ResourceSafePath@File@Sqex@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct File_ResourceSafePath_IHandledPtrFileData
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00F6732C (3 vfuncs)
}

[Rtti(".?AVIHandledPtr<FolderData>@ResourceSafePath@File@Sqex@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct File_ResourceSafePath_IHandledPtrFolderData
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00F6733C (3 vfuncs)
}

[Rtti(".?AVResourceSafeHandledPtr<FileData>@ResourceSafePath@File@Sqex@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct File_ResourceSafePath_ResourceSafeHandledPtrFileData
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00F6735C (3 vfuncs)
}

[Rtti(".?AVResourceSafeHandledPtr<FolderData>@ResourceSafePath@File@Sqex@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct File_ResourceSafePath_ResourceSafeHandledPtrFolderData
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00F6736C (3 vfuncs)
}

[Rtti(".?AVHttpClient@Http@Sqex@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct Http_HttpClient
{
    [FieldOffset(0x0000)] public nint VTable; // 0x011128E8 (1 vfunc)
}

[Rtti(".?AVHttpHeader@Http@Sqex@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct Http_HttpHeader
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01112FC8 (1 vfunc)
}

[Rtti(".?AVHttpRequest@Http@Sqex@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct Http_HttpRequest
{
    [FieldOffset(0x0000)] public nint VTable; // 0x011130B0 (1 vfunc)
}

[Rtti(".?AVHttpStatusLine@Http@Sqex@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct Http_HttpStatusLine
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01112D68 (1 vfunc)
}

[Rtti(".?AVQueue@PAUEvent@Http@Sqex@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct Http_PAUEvent_Queue
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01113054 (1 vfunc)
}

[Rtti(".?AVCCiceroEventSink@Input@Sqex@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct Input_CCiceroEventSink
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00F67938 (8 vfuncs)
}

[Rtti(".?AVCUIElementSink@Input@Sqex@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct Input_CUIElementSink
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00F678F8 (6 vfuncs)
}

[Rtti(".?AVCicero@Input@Sqex@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct Input_Cicero
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00F67488 (1 vfunc)
}

[Rtti(".?AVCiceroCandidateInterface@Input@Sqex@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct Input_CiceroCandidateInterface
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00F67490 (5 vfuncs)
}

[Rtti(".?AVKeyboardDevice@Input@Sqex@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct Input_KeyboardDevice
{
    [FieldOffset(0x0000)] public nint VTable; // 0x011104C0 (7 vfuncs)
}

[Rtti(".?AVKeyboardDeviceInterface@Input@Sqex@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct Input_KeyboardDeviceInterface
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01110498 (7 vfuncs)
}

[Rtti(".?AVMouseDevice@Input@Sqex@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct Input_MouseDevice
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01110504 (6 vfuncs)
}

[Rtti(".?AVMouseDeviceInterface@Input@Sqex@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct Input_MouseDeviceInterface
{
    [FieldOffset(0x0000)] public nint VTable; // 0x011104E0 (6 vfuncs)
}

[Rtti(".?AVPadDevice@Input@Sqex@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct Input_PadDevice
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01110624 (7 vfuncs)
}

[Rtti(".?AVPadDeviceInterface@Input@Sqex@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct Input_PadDeviceInterface
{
    [FieldOffset(0x0000)] public nint VTable; // 0x011105CC (7 vfuncs)
}

[Rtti(".?AVSoftKeyboardDevice@Input@Sqex@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct Input_SoftKeyboardDevice
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FA28B8 (6 vfuncs)
}

[Rtti(".?AVSoftKeyboardDeviceInterface@Input@Sqex@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct Input_SoftKeyboardDeviceInterface
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FA289C (6 vfuncs)
}

[Rtti(".?AVSoftKeyboardInputInterface@SoftKeyboardDeviceInterface@Input@Sqex@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct Input_SoftKeyboardDeviceInterface_SoftKeyboardInputInterface
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00F90F0C (7 vfuncs)
}

[Rtti(".?AVTextService@Input@Sqex@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct Input_TextService
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00F674C4 (20 vfuncs)
}

[Rtti(".?AVTextServiceInterface@Input@Sqex@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct Input_TextServiceInterface
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00F67434 (20 vfuncs)
}

[Rtti(".?AVSqexIdAuthentication@Login@Sqex@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct Login_SqexIdAuthentication
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00F6742C (1 vfunc)
}

[Rtti(".?AVHolderInterface@AnyType@Misc@Sqex@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct Misc_AnyType_HolderInterface
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FDF820 (4 vfuncs)
}

[Rtti(".?AVConfig@Misc@Sqex@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct Misc_Config
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00F67290 (2 vfuncs)
}

[Rtti(".?AVStackOperator<Utf8String>@Misc@Sqex@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct Misc_StackOperatorUtf8String
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0110DFB0 (9 vfuncs)
}

[Rtti(".?AVThreadMemory<Utf8String>@Misc@Sqex@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct Misc_ThreadMemoryUtf8String
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00F672A8 (1 vfunc)
}

[Rtti(".?AVMutex@Thread@Sqex@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct Thread_Mutex
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00F67878 (1 vfunc)
}

[Rtti(".?AVReadWriteLock@Thread@Sqex@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct Thread_ReadWriteLock
{
    [FieldOffset(0x0000)] public nint VTable; // 0x011128F0 (1 vfunc)
}

[Rtti(".?AVThreadManager@Thread@Sqex@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct Thread_ThreadManager
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01110678 (1 vfunc)
}

[Rtti(".?AVUpnpDeviceFinderCallback@Upnp@Sqex@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct Upnp_UpnpDeviceFinderCallback
{
    [FieldOffset(0x0000)] public nint VTable; // 0x011136DC (6 vfuncs)
}

[Rtti(".?AVUpnpDeviceFinderImpl@Upnp@Sqex@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct Upnp_UpnpDeviceFinderImpl
{
    [FieldOffset(0x0000)] public nint VTable; // 0x011136F8 (2 vfuncs)
}

[Rtti(".?AVUpnpPortMappingImpl@Upnp@Sqex@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct Upnp_UpnpPortMappingImpl
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01112880 (4 vfuncs)
}

[Rtti(".?AVUpnpService@Upnp@Sqex@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct Upnp_UpnpService
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01113728 (1 vfunc)
}

