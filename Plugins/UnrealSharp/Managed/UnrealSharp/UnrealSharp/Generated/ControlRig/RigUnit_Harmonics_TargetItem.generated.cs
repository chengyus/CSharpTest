using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_Harmonics_TargetItem
{
    // StructProperty /Script/ControlRig.RigUnit_Harmonics_TargetItem:Item
    static readonly int Item_Offset;
    public UnrealSharp.ControlRig.RigElementKey Item;
    
    // FloatProperty /Script/ControlRig.RigUnit_Harmonics_TargetItem:Ratio
    static readonly int Ratio_Offset;
    public float Ratio;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_Harmonics_TargetItem()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_Harmonics_TargetItem");
        
        Item_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Item");
        Ratio_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Ratio");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_Harmonics_TargetItem(IntPtr InNativeStruct)
    {
        unsafe
        {
            Item = UnrealSharp.ControlRig.RigElementKeyMarshaler.FromNative(IntPtr.Add(InNativeStruct, Item_Offset), 0, null);
            Ratio = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Ratio_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.ControlRig.RigElementKeyMarshaler.ToNative(IntPtr.Add(Buffer, Item_Offset), 0, null, Item);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Ratio_Offset), 0, null, Ratio);
        }
    }
}

public static class RigUnit_Harmonics_TargetItemMarshaler
{
    public static RigUnit_Harmonics_TargetItem FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_Harmonics_TargetItem(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_Harmonics_TargetItem obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_Harmonics_TargetItem.NativeDataSize;
    }
}