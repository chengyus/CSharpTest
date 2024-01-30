using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_ItemReplace
{
    // StructProperty /Script/ControlRig.RigUnit_ItemReplace:Item
    static readonly int Item_Offset;
    public UnrealSharp.ControlRig.RigElementKey Item;
    
    // NameProperty /Script/ControlRig.RigUnit_ItemReplace:Old
    static readonly int Old_Offset;
    public Name Old;
    
    // NameProperty /Script/ControlRig.RigUnit_ItemReplace:New
    static readonly int New_Offset;
    public Name New;
    
    // StructProperty /Script/ControlRig.RigUnit_ItemReplace:Result
    static readonly int Result_Offset;
    public UnrealSharp.ControlRig.RigElementKey Result;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_ItemReplace()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_ItemReplace");
        
        Item_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Item");
        Old_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Old");
        New_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "New");
        Result_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Result");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_ItemReplace(IntPtr InNativeStruct)
    {
        unsafe
        {
            Item = UnrealSharp.ControlRig.RigElementKeyMarshaler.FromNative(IntPtr.Add(InNativeStruct, Item_Offset), 0, null);
            Old = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, Old_Offset), 0, null);
            New = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, New_Offset), 0, null);
            Result = UnrealSharp.ControlRig.RigElementKeyMarshaler.FromNative(IntPtr.Add(InNativeStruct, Result_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.ControlRig.RigElementKeyMarshaler.ToNative(IntPtr.Add(Buffer, Item_Offset), 0, null, Item);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, Old_Offset), 0, null, Old);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, New_Offset), 0, null, New);
            UnrealSharp.ControlRig.RigElementKeyMarshaler.ToNative(IntPtr.Add(Buffer, Result_Offset), 0, null, Result);
        }
    }
}

public static class RigUnit_ItemReplaceMarshaler
{
    public static RigUnit_ItemReplace FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_ItemReplace(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_ItemReplace obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_ItemReplace.NativeDataSize;
    }
}