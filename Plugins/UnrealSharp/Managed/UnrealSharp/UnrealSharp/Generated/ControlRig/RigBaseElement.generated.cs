using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigBaseElement
{
    // StructProperty /Script/ControlRig.RigBaseElement:Key
    static readonly int Key_Offset;
    public UnrealSharp.ControlRig.RigElementKey Key;
    
    // IntProperty /Script/ControlRig.RigBaseElement:Index
    static readonly int Index_Offset;
    public int Index;
    
    // IntProperty /Script/ControlRig.RigBaseElement:SubIndex
    static readonly int SubIndex_Offset;
    public int SubIndex;
    
    // IntProperty /Script/ControlRig.RigBaseElement:CreatedAtInstructionIndex
    static readonly int CreatedAtInstructionIndex_Offset;
    public int CreatedAtInstructionIndex;
    
    // BoolProperty /Script/ControlRig.RigBaseElement:bSelected
    static readonly int bSelected_Offset;
    public bool Selected;
    
    
    public static readonly int NativeDataSize;
    static RigBaseElement()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigBaseElement");
        
        Key_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Key");
        Index_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Index");
        SubIndex_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SubIndex");
        CreatedAtInstructionIndex_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CreatedAtInstructionIndex");
        bSelected_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bSelected");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigBaseElement(IntPtr InNativeStruct)
    {
        unsafe
        {
            Key = UnrealSharp.ControlRig.RigElementKeyMarshaler.FromNative(IntPtr.Add(InNativeStruct, Key_Offset), 0, null);
            Index = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, Index_Offset), 0, null);
            SubIndex = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, SubIndex_Offset), 0, null);
            CreatedAtInstructionIndex = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, CreatedAtInstructionIndex_Offset), 0, null);
            Selected = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bSelected_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.ControlRig.RigElementKeyMarshaler.ToNative(IntPtr.Add(Buffer, Key_Offset), 0, null, Key);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, Index_Offset), 0, null, Index);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, SubIndex_Offset), 0, null, SubIndex);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, CreatedAtInstructionIndex_Offset), 0, null, CreatedAtInstructionIndex);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bSelected_Offset), 0, null, Selected);
        }
    }
}

public static class RigBaseElementMarshaler
{
    public static RigBaseElement FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigBaseElement(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigBaseElement obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigBaseElement.NativeDataSize;
    }
}