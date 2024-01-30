using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_CollectionUnion
{
    // StructProperty /Script/ControlRig.RigUnit_CollectionUnion:A
    static readonly int A_Offset;
    public UnrealSharp.ControlRig.RigElementKeyCollection A;
    
    // StructProperty /Script/ControlRig.RigUnit_CollectionUnion:B
    static readonly int B_Offset;
    public UnrealSharp.ControlRig.RigElementKeyCollection B;
    
    // BoolProperty /Script/ControlRig.RigUnit_CollectionUnion:bAllowDuplicates
    static readonly int bAllowDuplicates_Offset;
    public bool AllowDuplicates;
    
    // StructProperty /Script/ControlRig.RigUnit_CollectionUnion:Collection
    static readonly int Collection_Offset;
    public UnrealSharp.ControlRig.RigElementKeyCollection Collection;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_CollectionUnion()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_CollectionUnion");
        
        A_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "A");
        B_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "B");
        bAllowDuplicates_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bAllowDuplicates");
        Collection_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Collection");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_CollectionUnion(IntPtr InNativeStruct)
    {
        unsafe
        {
            A = UnrealSharp.ControlRig.RigElementKeyCollectionMarshaler.FromNative(IntPtr.Add(InNativeStruct, A_Offset), 0, null);
            B = UnrealSharp.ControlRig.RigElementKeyCollectionMarshaler.FromNative(IntPtr.Add(InNativeStruct, B_Offset), 0, null);
            AllowDuplicates = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bAllowDuplicates_Offset), 0, null);
            Collection = UnrealSharp.ControlRig.RigElementKeyCollectionMarshaler.FromNative(IntPtr.Add(InNativeStruct, Collection_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.ControlRig.RigElementKeyCollectionMarshaler.ToNative(IntPtr.Add(Buffer, A_Offset), 0, null, A);
            UnrealSharp.ControlRig.RigElementKeyCollectionMarshaler.ToNative(IntPtr.Add(Buffer, B_Offset), 0, null, B);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bAllowDuplicates_Offset), 0, null, AllowDuplicates);
            UnrealSharp.ControlRig.RigElementKeyCollectionMarshaler.ToNative(IntPtr.Add(Buffer, Collection_Offset), 0, null, Collection);
        }
    }
}

public static class RigUnit_CollectionUnionMarshaler
{
    public static RigUnit_CollectionUnion FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_CollectionUnion(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_CollectionUnion obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_CollectionUnion.NativeDataSize;
    }
}