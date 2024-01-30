using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_CCDIK_RotationLimitPerItem
{
    // StructProperty /Script/ControlRig.RigUnit_CCDIK_RotationLimitPerItem:Item
    static readonly int Item_Offset;
    public UnrealSharp.ControlRig.RigElementKey Item;
    
    // FloatProperty /Script/ControlRig.RigUnit_CCDIK_RotationLimitPerItem:Limit
    static readonly int Limit_Offset;
    public float Limit;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_CCDIK_RotationLimitPerItem()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_CCDIK_RotationLimitPerItem");
        
        Item_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Item");
        Limit_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Limit");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_CCDIK_RotationLimitPerItem(IntPtr InNativeStruct)
    {
        unsafe
        {
            Item = UnrealSharp.ControlRig.RigElementKeyMarshaler.FromNative(IntPtr.Add(InNativeStruct, Item_Offset), 0, null);
            Limit = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Limit_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.ControlRig.RigElementKeyMarshaler.ToNative(IntPtr.Add(Buffer, Item_Offset), 0, null, Item);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Limit_Offset), 0, null, Limit);
        }
    }
}

public static class RigUnit_CCDIK_RotationLimitPerItemMarshaler
{
    public static RigUnit_CCDIK_RotationLimitPerItem FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_CCDIK_RotationLimitPerItem(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_CCDIK_RotationLimitPerItem obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_CCDIK_RotationLimitPerItem.NativeDataSize;
    }
}