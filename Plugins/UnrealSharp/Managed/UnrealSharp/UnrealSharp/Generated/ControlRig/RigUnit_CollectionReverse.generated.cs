using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_CollectionReverse
{
    // StructProperty /Script/ControlRig.RigUnit_CollectionReverse:Collection
    static readonly int Collection_Offset;
    public UnrealSharp.ControlRig.RigElementKeyCollection Collection;
    
    // StructProperty /Script/ControlRig.RigUnit_CollectionReverse:Reversed
    static readonly int Reversed_Offset;
    public UnrealSharp.ControlRig.RigElementKeyCollection Reversed;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_CollectionReverse()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_CollectionReverse");
        
        Collection_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Collection");
        Reversed_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Reversed");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_CollectionReverse(IntPtr InNativeStruct)
    {
        unsafe
        {
            Collection = UnrealSharp.ControlRig.RigElementKeyCollectionMarshaler.FromNative(IntPtr.Add(InNativeStruct, Collection_Offset), 0, null);
            Reversed = UnrealSharp.ControlRig.RigElementKeyCollectionMarshaler.FromNative(IntPtr.Add(InNativeStruct, Reversed_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.ControlRig.RigElementKeyCollectionMarshaler.ToNative(IntPtr.Add(Buffer, Collection_Offset), 0, null, Collection);
            UnrealSharp.ControlRig.RigElementKeyCollectionMarshaler.ToNative(IntPtr.Add(Buffer, Reversed_Offset), 0, null, Reversed);
        }
    }
}

public static class RigUnit_CollectionReverseMarshaler
{
    public static RigUnit_CollectionReverse FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_CollectionReverse(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_CollectionReverse obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_CollectionReverse.NativeDataSize;
    }
}