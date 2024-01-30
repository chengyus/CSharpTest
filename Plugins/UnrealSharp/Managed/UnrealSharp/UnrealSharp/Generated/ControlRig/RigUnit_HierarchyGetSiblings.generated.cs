using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_HierarchyGetSiblings
{
    // StructProperty /Script/ControlRig.RigUnit_HierarchyGetSiblings:Item
    static readonly int Item_Offset;
    public UnrealSharp.ControlRig.RigElementKey Item;
    
    // BoolProperty /Script/ControlRig.RigUnit_HierarchyGetSiblings:bIncludeItem
    static readonly int bIncludeItem_Offset;
    public bool IncludeItem;
    
    // StructProperty /Script/ControlRig.RigUnit_HierarchyGetSiblings:Siblings
    static readonly int Siblings_Offset;
    public UnrealSharp.ControlRig.RigElementKeyCollection Siblings;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_HierarchyGetSiblings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_HierarchyGetSiblings");
        
        Item_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Item");
        bIncludeItem_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIncludeItem");
        Siblings_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Siblings");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_HierarchyGetSiblings(IntPtr InNativeStruct)
    {
        unsafe
        {
            Item = UnrealSharp.ControlRig.RigElementKeyMarshaler.FromNative(IntPtr.Add(InNativeStruct, Item_Offset), 0, null);
            IncludeItem = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIncludeItem_Offset), 0, null);
            Siblings = UnrealSharp.ControlRig.RigElementKeyCollectionMarshaler.FromNative(IntPtr.Add(InNativeStruct, Siblings_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.ControlRig.RigElementKeyMarshaler.ToNative(IntPtr.Add(Buffer, Item_Offset), 0, null, Item);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bIncludeItem_Offset), 0, null, IncludeItem);
            UnrealSharp.ControlRig.RigElementKeyCollectionMarshaler.ToNative(IntPtr.Add(Buffer, Siblings_Offset), 0, null, Siblings);
        }
    }
}

public static class RigUnit_HierarchyGetSiblingsMarshaler
{
    public static RigUnit_HierarchyGetSiblings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_HierarchyGetSiblings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_HierarchyGetSiblings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_HierarchyGetSiblings.NativeDataSize;
    }
}