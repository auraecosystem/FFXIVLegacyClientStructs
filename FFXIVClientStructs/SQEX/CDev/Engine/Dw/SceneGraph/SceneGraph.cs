// Project: FFXIVLegacyClientStructs (FFXIV 1.23b)
// Author: Yokimitsuro
// SQEX::CDev::Engine::Dw::SceneGraph — Scene graph node hierarchy

using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.SQEX.CDev.Engine.Dw.SceneGraph
{
    [Rtti(".?AVIVisitor@SceneGraph@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct IVisitor
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x01099F54 (2 vfuncs)
    }

    [Rtti(".?AVIAttributeAccessor@SceneGraph@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct IAttributeAccessor
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x0109A2E4 (13 vfuncs)
    }

    [Rtti(".?AVReferenceObject@SceneGraph@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct ReferenceObject
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x00FBDE84 (1 vfuncs)
    }

    [Rtti(".?AVNode@SceneGraph@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct Node
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x0109A1F0 (5 vfuncs)
    }

    [Rtti(".?AVTransformNode@SceneGraph@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct TransformNode
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x0109A46C (6 vfuncs)
    }

    [Rtti(".?AVCharacterSkeletonNode@SceneGraph@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct CharacterSkeletonNode
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x0109A2DC (1 vfuncs)
    }

    [Rtti(".?AV?$CDevJointObjectProxy@VCharacterSkeletonNode@SceneGraph@Dw@Engine@CDev@SQEX@@@SceneGraph@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct CDevJointObjectProxyCharacterSkeletonNode
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x0109DED4 (17 vfuncs)
    }

    [Rtti(".?AVSceneGraphManager@SceneGraph@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct SceneGraphManager
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x0113BE98 (1 vfuncs)
    }

    [Rtti(".?AVTraverser@SceneGraph@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct Traverser
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x0109A788 (1 vfuncs)
    }

    [Rtti(".?AVResourceAsyncManager@SceneGraph@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct ResourceAsyncManager
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x0109A5A8 (1 vfuncs)
    }

    [Rtti(".?AVHandleInfo@ResourceAsyncManager@SceneGraph@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct ResourceAsyncManager_HandleInfo
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x0109A490 (1 vfuncs)
    }

    [Rtti(".?AVResourceChain@ResourceAsyncManager@SceneGraph@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct ResourceAsyncManager_ResourceChain
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x0109A488 (1 vfuncs)
    }

    namespace Detail
    {
        [Rtti(".?AVJoint@Detail@SceneGraph@Dw@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct Joint
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x0109A31C (13 vfuncs)
        }
    }

    namespace ElementId
    {
        [Rtti(".?AVIElementIdContainer@ElementId@SceneGraph@Dw@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct IElementIdContainer
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x0109AC24 (8 vfuncs)
        }

        [Rtti(".?AVElementIdBinaryParser@ElementId@SceneGraph@Dw@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct ElementIdBinaryParser
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x0109ACC8 (8 vfuncs)
        }

        [Rtti(".?AVElementIdCompositor@ElementId@SceneGraph@Dw@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct ElementIdCompositor
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010F565C (8 vfuncs)
        }
    }

    namespace Resource
    {
        [Rtti(".?AVIReferenceRequestListener@Resource@SceneGraph@Dw@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct IReferenceRequestListener
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x00FBF784 (2 vfuncs)
        }

        [Rtti(".?AVIResourceNodeFactory@Resource@SceneGraph@Dw@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct IResourceNodeFactory
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x00FB6DA0 (7 vfuncs)
        }

        [Rtti(".?AVReferencedResourceNodeFactory@Resource@SceneGraph@Dw@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct ReferencedResourceNodeFactory
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x00FB6DC0 (7 vfuncs)
        }

        [Rtti(".?AVPackedResourceNodeFactory@Resource@SceneGraph@Dw@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct PackedResourceNodeFactory
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x00FB6E68 (7 vfuncs)
        }

        [Rtti(".?AVResourceNode@Resource@SceneGraph@Dw@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct ResourceNode
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x00FB6EDC (15 vfuncs)
        }

        [Rtti(".?AVResourceNodesAllocator@Resource@SceneGraph@Dw@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct ResourceNodesAllocator
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x0109D078 (4 vfuncs)
        }

        [Rtti(".?AVResourceRoot@Resource@SceneGraph@Dw@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct ResourceRoot
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x00FBC32C (15 vfuncs)
        }

        [Rtti(".?AVResourceFactory@Resource@SceneGraph@Dw@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct ResourceFactory
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x01099FD8 (1 vfuncs)
        }

        [Rtti(".?AVResourceNodeFinder@ResourceManager@Resource@SceneGraph@Dw@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct ResourceManager_ResourceNodeFinder
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x01099FCC (2 vfuncs)
        }

        [Rtti(".?AVResourceRootFinder@ResourceManager@Resource@SceneGraph@Dw@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct ResourceManager_ResourceRootFinder
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x01099F60 (2 vfuncs)
        }

        [Rtti(".?AVBindResourceNode@Resource@SceneGraph@Dw@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct BindResourceNode
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x01098024 (15 vfuncs)
        }

        [Rtti(".?AVDefaultResourceNode@Resource@SceneGraph@Dw@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct DefaultResourceNode
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x0109AA8C (15 vfuncs)
        }

        [Rtti(".?AVDefaultResourceNodeFactory@Resource@SceneGraph@Dw@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct DefaultResourceNodeFactory
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x0109A690 (7 vfuncs)
        }

        [Rtti(".?AVDependentResourceNode@Resource@SceneGraph@Dw@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct DependentResourceNode
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x0109A83C (15 vfuncs)
        }

        [Rtti(".?AVFactory@DependentResourceNode@Resource@SceneGraph@Dw@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct DependentResourceNode_Factory
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x01099FAC (7 vfuncs)
        }

        [Rtti(".?AVElementIdResourceNode@Resource@SceneGraph@Dw@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct ElementIdResourceNode
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x0109ABC4 (15 vfuncs)
        }

        [Rtti(".?AVElementIdResourceNodeFactory@Resource@SceneGraph@Dw@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct ElementIdResourceNodeFactory
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x01099F8C (7 vfuncs)
        }

        [Rtti(".?AVSkeletonResourceNode@Resource@SceneGraph@Dw@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct SkeletonResourceNode
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x0109A93C (15 vfuncs)
        }

        [Rtti(".?AVSkeletonResourceNodeFactory@Resource@SceneGraph@Dw@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct SkeletonResourceNodeFactory
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x01099F6C (7 vfuncs)
        }

        [Rtti(".?AV?$TDynamicPointerArray@VResourceNode@Resource@SceneGraph@Dw@Engine@CDev@SQEX@@@Resource@SceneGraph@Dw@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct TDynamicPointerArrayResourceNode
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x00FBFA70 (1 vfuncs)
        }
    }
}
