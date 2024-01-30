using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_CollectionChildrenArray
{
    // StructProperty /Script/ControlRig.RigUnit_CollectionChildrenArray:Parent
    static readonly int Parent_Offset;
    public UnrealSharp.ControlRig.RigElementKey Parent;
    
    // BoolProperty /Script/ControlRig.RigUnit_CollectionChildrenArray:bIncludeParent
    static readonly int bIncludeParent_Offset;
    public bool IncludeParent;
    
    // BoolProperty /Script/ControlRig.RigUnit_CollectionChildrenArray:bRecursive
    static readonly int bRecursive_Offset;
    public bool Recursive;
    
    // EnumProperty /Script/ControlRig.RigUnit_CollectionChildrenArray:TypeToSearch
    static readonly int TypeToSearch_Offset;
    public UnrealSharp.ControlRig.ERigElementType TypeToSearch;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_CollectionChildrenArray()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_CollectionChildrenArray");
        
        Parent_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Parent");
        bIncludeParent_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIncludeParent");
        bRecursive_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bRecursive");
        TypeToSearch_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TypeToSearch");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_CollectionChildrenArray(IntPtr InNativeStruct)
    {
        unsafe
        {
            Parent = UnrealSharp.ControlRig.RigElementKeyMarshaler.FromNative(IntPtr.Add(InNativeStruct, Parent_Offset), 0, null);
            IncludeParent = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIncludeParent_Offset), 0, null);
            Recursive = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bRecursive_Offset), 0, null);
            TypeToSearch = BlittableMarshaller<UnrealSharp.ControlRig.ERigElementType>.FromNative(IntPtr.Add(InNativeStruct, TypeToSearch_Offset), 0, null);
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
        }
    }
}

public static class RigUnit_CollectionChildrenArrayMarshaler
{
    public static RigUnit_CollectionChildrenArray FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_CollectionChildrenArray(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_CollectionChildrenArray obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_CollectionChildrenArray.NativeDataSize;
    }
}