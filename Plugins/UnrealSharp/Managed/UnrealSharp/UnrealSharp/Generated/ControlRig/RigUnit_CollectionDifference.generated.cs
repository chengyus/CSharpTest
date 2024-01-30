using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_CollectionDifference
{
    // StructProperty /Script/ControlRig.RigUnit_CollectionDifference:A
    static readonly int A_Offset;
    public UnrealSharp.ControlRig.RigElementKeyCollection A;
    
    // StructProperty /Script/ControlRig.RigUnit_CollectionDifference:B
    static readonly int B_Offset;
    public UnrealSharp.ControlRig.RigElementKeyCollection B;
    
    // StructProperty /Script/ControlRig.RigUnit_CollectionDifference:Collection
    static readonly int Collection_Offset;
    public UnrealSharp.ControlRig.RigElementKeyCollection Collection;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_CollectionDifference()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_CollectionDifference");
        
        A_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "A");
        B_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "B");
        Collection_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Collection");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_CollectionDifference(IntPtr InNativeStruct)
    {
        unsafe
        {
            A = UnrealSharp.ControlRig.RigElementKeyCollectionMarshaler.FromNative(IntPtr.Add(InNativeStruct, A_Offset), 0, null);
            B = UnrealSharp.ControlRig.RigElementKeyCollectionMarshaler.FromNative(IntPtr.Add(InNativeStruct, B_Offset), 0, null);
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
            UnrealSharp.ControlRig.RigElementKeyCollectionMarshaler.ToNative(IntPtr.Add(Buffer, Collection_Offset), 0, null, Collection);
        }
    }
}

public static class RigUnit_CollectionDifferenceMarshaler
{
    public static RigUnit_CollectionDifference FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_CollectionDifference(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_CollectionDifference obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_CollectionDifference.NativeDataSize;
    }
}