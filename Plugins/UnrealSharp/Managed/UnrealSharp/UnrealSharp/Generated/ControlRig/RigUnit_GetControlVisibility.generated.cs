using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_GetControlVisibility
{
    // StructProperty /Script/ControlRig.RigUnit_GetControlVisibility:Item
    static readonly int Item_Offset;
    public UnrealSharp.ControlRig.RigElementKey Item;
    
    // BoolProperty /Script/ControlRig.RigUnit_GetControlVisibility:bVisible
    static readonly int bVisible_Offset;
    public bool Visible;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_GetControlVisibility()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_GetControlVisibility");
        
        Item_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Item");
        bVisible_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bVisible");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_GetControlVisibility(IntPtr InNativeStruct)
    {
        unsafe
        {
            Item = UnrealSharp.ControlRig.RigElementKeyMarshaler.FromNative(IntPtr.Add(InNativeStruct, Item_Offset), 0, null);
            Visible = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bVisible_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.ControlRig.RigElementKeyMarshaler.ToNative(IntPtr.Add(Buffer, Item_Offset), 0, null, Item);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bVisible_Offset), 0, null, Visible);
        }
    }
}

public static class RigUnit_GetControlVisibilityMarshaler
{
    public static RigUnit_GetControlVisibility FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_GetControlVisibility(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_GetControlVisibility obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_GetControlVisibility.NativeDataSize;
    }
}