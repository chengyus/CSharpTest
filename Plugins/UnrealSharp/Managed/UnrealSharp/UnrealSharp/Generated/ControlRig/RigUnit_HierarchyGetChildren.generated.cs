using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_HierarchyGetChildren
{
    // StructProperty /Script/ControlRig.RigUnit_HierarchyGetChildren:Parent
    static readonly int Parent_Offset;
    public UnrealSharp.ControlRig.RigElementKey Parent;
    
    // BoolProperty /Script/ControlRig.RigUnit_HierarchyGetChildren:bIncludeParent
    static readonly int bIncludeParent_Offset;
    public bool IncludeParent;
    
    // BoolProperty /Script/ControlRig.RigUnit_HierarchyGetChildren:bRecursive
    static readonly int bRecursive_Offset;
    public bool Recursive;
    
    // StructProperty /Script/ControlRig.RigUnit_HierarchyGetChildren:Children
    static readonly int Children_Offset;
    public UnrealSharp.ControlRig.RigElementKeyCollection Children;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_HierarchyGetChildren()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_HierarchyGetChildren");
        
        Parent_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Parent");
        bIncludeParent_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIncludeParent");
        bRecursive_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bRecursive");
        Children_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Children");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_HierarchyGetChildren(IntPtr InNativeStruct)
    {
        unsafe
        {
            Parent = UnrealSharp.ControlRig.RigElementKeyMarshaler.FromNative(IntPtr.Add(InNativeStruct, Parent_Offset), 0, null);
            IncludeParent = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIncludeParent_Offset), 0, null);
            Recursive = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bRecursive_Offset), 0, null);
            Children = UnrealSharp.ControlRig.RigElementKeyCollectionMarshaler.FromNative(IntPtr.Add(InNativeStruct, Children_Offset), 0, null);
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
            UnrealSharp.ControlRig.RigElementKeyCollectionMarshaler.ToNative(IntPtr.Add(Buffer, Children_Offset), 0, null, Children);
        }
    }
}

public static class RigUnit_HierarchyGetChildrenMarshaler
{
    public static RigUnit_HierarchyGetChildren FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_HierarchyGetChildren(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_HierarchyGetChildren obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_HierarchyGetChildren.NativeDataSize;
    }
}