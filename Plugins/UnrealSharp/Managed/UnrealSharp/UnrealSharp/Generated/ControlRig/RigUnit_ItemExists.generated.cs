using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_ItemExists
{
    // StructProperty /Script/ControlRig.RigUnit_ItemExists:Item
    static readonly int Item_Offset;
    public UnrealSharp.ControlRig.RigElementKey Item;
    
    // BoolProperty /Script/ControlRig.RigUnit_ItemExists:Exists
    static readonly int Exists_Offset;
    public bool Exists;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_ItemExists()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_ItemExists");
        
        Item_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Item");
        Exists_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Exists");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_ItemExists(IntPtr InNativeStruct)
    {
        unsafe
        {
            Item = UnrealSharp.ControlRig.RigElementKeyMarshaler.FromNative(IntPtr.Add(InNativeStruct, Item_Offset), 0, null);
            Exists = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, Exists_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.ControlRig.RigElementKeyMarshaler.ToNative(IntPtr.Add(Buffer, Item_Offset), 0, null, Item);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, Exists_Offset), 0, null, Exists);
        }
    }
}

public static class RigUnit_ItemExistsMarshaler
{
    public static RigUnit_ItemExists FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_ItemExists(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_ItemExists obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_ItemExists.NativeDataSize;
    }
}