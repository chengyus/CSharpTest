using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_CollectionItemAtIndex
{
    // StructProperty /Script/ControlRig.RigUnit_CollectionItemAtIndex:Collection
    static readonly int Collection_Offset;
    public UnrealSharp.ControlRig.RigElementKeyCollection Collection;
    
    // IntProperty /Script/ControlRig.RigUnit_CollectionItemAtIndex:Index
    static readonly int Index_Offset;
    public int Index;
    
    // StructProperty /Script/ControlRig.RigUnit_CollectionItemAtIndex:Item
    static readonly int Item_Offset;
    public UnrealSharp.ControlRig.RigElementKey Item;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_CollectionItemAtIndex()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_CollectionItemAtIndex");
        
        Collection_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Collection");
        Index_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Index");
        Item_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Item");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_CollectionItemAtIndex(IntPtr InNativeStruct)
    {
        unsafe
        {
            Collection = UnrealSharp.ControlRig.RigElementKeyCollectionMarshaler.FromNative(IntPtr.Add(InNativeStruct, Collection_Offset), 0, null);
            Index = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, Index_Offset), 0, null);
            Item = UnrealSharp.ControlRig.RigElementKeyMarshaler.FromNative(IntPtr.Add(InNativeStruct, Item_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.ControlRig.RigElementKeyCollectionMarshaler.ToNative(IntPtr.Add(Buffer, Collection_Offset), 0, null, Collection);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, Index_Offset), 0, null, Index);
            UnrealSharp.ControlRig.RigElementKeyMarshaler.ToNative(IntPtr.Add(Buffer, Item_Offset), 0, null, Item);
        }
    }
}

public static class RigUnit_CollectionItemAtIndexMarshaler
{
    public static RigUnit_CollectionItemAtIndex FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_CollectionItemAtIndex(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_CollectionItemAtIndex obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_CollectionItemAtIndex.NativeDataSize;
    }
}