using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_HasMetadataTagArray
{
    // StructProperty /Script/ControlRig.RigUnit_HasMetadataTagArray:Item
    static readonly int Item_Offset;
    public UnrealSharp.ControlRig.RigElementKey Item;
    
    // BoolProperty /Script/ControlRig.RigUnit_HasMetadataTagArray:Found
    static readonly int Found_Offset;
    public bool Found;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_HasMetadataTagArray()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_HasMetadataTagArray");
        
        Item_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Item");
        Found_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Found");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_HasMetadataTagArray(IntPtr InNativeStruct)
    {
        unsafe
        {
            Item = UnrealSharp.ControlRig.RigElementKeyMarshaler.FromNative(IntPtr.Add(InNativeStruct, Item_Offset), 0, null);
            Found = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, Found_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.ControlRig.RigElementKeyMarshaler.ToNative(IntPtr.Add(Buffer, Item_Offset), 0, null, Item);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, Found_Offset), 0, null, Found);
        }
    }
}

public static class RigUnit_HasMetadataTagArrayMarshaler
{
    public static RigUnit_HasMetadataTagArray FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_HasMetadataTagArray(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_HasMetadataTagArray obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_HasMetadataTagArray.NativeDataSize;
    }
}