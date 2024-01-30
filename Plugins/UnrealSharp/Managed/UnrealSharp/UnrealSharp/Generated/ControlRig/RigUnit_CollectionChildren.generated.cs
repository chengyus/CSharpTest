using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_CollectionChildren
{
    // StructProperty /Script/ControlRig.RigUnit_CollectionChildren:Parent
    static readonly int Parent_Offset;
    public UnrealSharp.ControlRig.RigElementKey Parent;
    
    // BoolProperty /Script/ControlRig.RigUnit_CollectionChildren:bIncludeParent
    static readonly int bIncludeParent_Offset;
    public bool IncludeParent;
    
    // BoolProperty /Script/ControlRig.RigUnit_CollectionChildren:bRecursive
    static readonly int bRecursive_Offset;
    public bool Recursive;
    
    // EnumProperty /Script/ControlRig.RigUnit_CollectionChildren:TypeToSearch
    static readonly int TypeToSearch_Offset;
    public UnrealSharp.ControlRig.ERigElementType TypeToSearch;
    
    // StructProperty /Script/ControlRig.RigUnit_CollectionChildren:Collection
    static readonly int Collection_Offset;
    public UnrealSharp.ControlRig.RigElementKeyCollection Collection;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_CollectionChildren()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_CollectionChildren");
        
        Parent_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Parent");
        bIncludeParent_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIncludeParent");
        bRecursive_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bRecursive");
        TypeToSearch_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TypeToSearch");
        Collection_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Collection");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_CollectionChildren(IntPtr InNativeStruct)
    {
        unsafe
        {
            Parent = UnrealSharp.ControlRig.RigElementKeyMarshaler.FromNative(IntPtr.Add(InNativeStruct, Parent_Offset), 0, null);
            IncludeParent = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIncludeParent_Offset), 0, null);
            Recursive = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bRecursive_Offset), 0, null);
            TypeToSearch = BlittableMarshaller<UnrealSharp.ControlRig.ERigElementType>.FromNative(IntPtr.Add(InNativeStruct, TypeToSearch_Offset), 0, null);
            Collection = UnrealSharp.ControlRig.RigElementKeyCollectionMarshaler.FromNative(IntPtr.Add(InNativeStruct, Collection_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.ControlRig.RigElementKeyMarshaler.ToNative(IntPtr.Add(Buffer, Parent_Offset), 0, null, Parent);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bIncludeParent_Offset), 0, null, IncludeParent);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bRecursive_Offset), 0, null, Recursive);
            BlittableMarshaller<UnrealSharp.ControlRig.ERigElementType>.ToNative(IntPtr.Add(Buffer, TypeToSearch_Offset), 0, null, TypeToSearch);
            UnrealSharp.ControlRig.RigElementKeyCollectionMarshaler.ToNative(IntPtr.Add(Buffer, Collection_Offset), 0, null, Collection);
        }
    }
}

public static class RigUnit_CollectionChildrenMarshaler
{
    public static RigUnit_CollectionChildren FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_CollectionChildren(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_CollectionChildren obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_CollectionChildren.NativeDataSize;
    }
}