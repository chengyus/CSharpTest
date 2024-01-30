using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_CollectionReplaceItems
{
    // StructProperty /Script/ControlRig.RigUnit_CollectionReplaceItems:Items
    static readonly int Items_Offset;
    public UnrealSharp.ControlRig.RigElementKeyCollection Items;
    
    // NameProperty /Script/ControlRig.RigUnit_CollectionReplaceItems:Old
    static readonly int Old_Offset;
    public Name Old;
    
    // NameProperty /Script/ControlRig.RigUnit_CollectionReplaceItems:New
    static readonly int New_Offset;
    public Name New;
    
    // BoolProperty /Script/ControlRig.RigUnit_CollectionReplaceItems:RemoveInvalidItems
    static readonly int RemoveInvalidItems_Offset;
    public bool RemoveInvalidItems;
    
    // BoolProperty /Script/ControlRig.RigUnit_CollectionReplaceItems:bAllowDuplicates
    static readonly int bAllowDuplicates_Offset;
    public bool AllowDuplicates;
    
    // StructProperty /Script/ControlRig.RigUnit_CollectionReplaceItems:Collection
    static readonly int Collection_Offset;
    public UnrealSharp.ControlRig.RigElementKeyCollection Collection;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_CollectionReplaceItems()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_CollectionReplaceItems");
        
        Items_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Items");
        Old_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Old");
        New_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "New");
        RemoveInvalidItems_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RemoveInvalidItems");
        bAllowDuplicates_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bAllowDuplicates");
        Collection_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Collection");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_CollectionReplaceItems(IntPtr InNativeStruct)
    {
        unsafe
        {
            Items = UnrealSharp.ControlRig.RigElementKeyCollectionMarshaler.FromNative(IntPtr.Add(InNativeStruct, Items_Offset), 0, null);
            Old = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, Old_Offset), 0, null);
            New = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, New_Offset), 0, null);
            RemoveInvalidItems = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, RemoveInvalidItems_Offset), 0, null);
            AllowDuplicates = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bAllowDuplicates_Offset), 0, null);
            Collection = UnrealSharp.ControlRig.RigElementKeyCollectionMarshaler.FromNative(IntPtr.Add(InNativeStruct, Collection_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.ControlRig.RigElementKeyCollectionMarshaler.ToNative(IntPtr.Add(Buffer, Items_Offset), 0, null, Items);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, Old_Offset), 0, null, Old);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, New_Offset), 0, null, New);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, RemoveInvalidItems_Offset), 0, null, RemoveInvalidItems);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bAllowDuplicates_Offset), 0, null, AllowDuplicates);
            UnrealSharp.ControlRig.RigElementKeyCollectionMarshaler.ToNative(IntPtr.Add(Buffer, Collection_Offset), 0, null, Collection);
        }
    }
}

public static class RigUnit_CollectionReplaceItemsMarshaler
{
    public static RigUnit_CollectionReplaceItems FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_CollectionReplaceItems(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_CollectionReplaceItems obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_CollectionReplaceItems.NativeDataSize;
    }
}