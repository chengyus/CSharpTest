using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_Item
{
    // StructProperty /Script/ControlRig.RigUnit_Item:Item
    static readonly int Item_Offset;
    public UnrealSharp.ControlRig.RigElementKey Item;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_Item()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_Item");
        
        Item_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Item");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_Item(IntPtr InNativeStruct)
    {
        unsafe
        {
            Item = UnrealSharp.ControlRig.RigElementKeyMarshaler.FromNative(IntPtr.Add(InNativeStruct, Item_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.ControlRig.RigElementKeyMarshaler.ToNative(IntPtr.Add(Buffer, Item_Offset), 0, null, Item);
        }
    }
}

public static class RigUnit_ItemMarshaler
{
    public static RigUnit_Item FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_Item(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_Item obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_Item.NativeDataSize;
    }
}