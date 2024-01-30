using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_CollectionChain
{
    // StructProperty /Script/ControlRig.RigUnit_CollectionChain:FirstItem
    static readonly int FirstItem_Offset;
    public UnrealSharp.ControlRig.RigElementKey FirstItem;
    
    // StructProperty /Script/ControlRig.RigUnit_CollectionChain:LastItem
    static readonly int LastItem_Offset;
    public UnrealSharp.ControlRig.RigElementKey LastItem;
    
    // BoolProperty /Script/ControlRig.RigUnit_CollectionChain:Reverse
    static readonly int Reverse_Offset;
    public bool Reverse;
    
    // StructProperty /Script/ControlRig.RigUnit_CollectionChain:Collection
    static readonly int Collection_Offset;
    public UnrealSharp.ControlRig.RigElementKeyCollection Collection;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_CollectionChain()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_CollectionChain");
        
        FirstItem_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FirstItem");
        LastItem_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LastItem");
        Reverse_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Reverse");
        Collection_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Collection");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_CollectionChain(IntPtr InNativeStruct)
    {
        unsafe
        {
            FirstItem = UnrealSharp.ControlRig.RigElementKeyMarshaler.FromNative(IntPtr.Add(InNativeStruct, FirstItem_Offset), 0, null);
            LastItem = UnrealSharp.ControlRig.RigElementKeyMarshaler.FromNative(IntPtr.Add(InNativeStruct, LastItem_Offset), 0, null);
            Reverse = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, Reverse_Offset), 0, null);
            Collection = UnrealSharp.ControlRig.RigElementKeyCollectionMarshaler.FromNative(IntPtr.Add(InNativeStruct, Collection_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.ControlRig.RigElementKeyMarshaler.ToNative(IntPtr.Add(Buffer, FirstItem_Offset), 0, null, FirstItem);
            UnrealSharp.ControlRig.RigElementKeyMarshaler.ToNative(IntPtr.Add(Buffer, LastItem_Offset), 0, null, LastItem);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, Reverse_Offset), 0, null, Reverse);
            UnrealSharp.ControlRig.RigElementKeyCollectionMarshaler.ToNative(IntPtr.Add(Buffer, Collection_Offset), 0, null, Collection);
        }
    }
}

public static class RigUnit_CollectionChainMarshaler
{
    public static RigUnit_CollectionChain FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_CollectionChain(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_CollectionChain obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_CollectionChain.NativeDataSize;
    }
}