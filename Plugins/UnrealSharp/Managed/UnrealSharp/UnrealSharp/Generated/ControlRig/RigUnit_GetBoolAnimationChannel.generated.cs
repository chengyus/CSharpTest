using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_GetBoolAnimationChannel
{
    // BoolProperty /Script/ControlRig.RigUnit_GetBoolAnimationChannel:Value
    static readonly int Value_Offset;
    public bool Value;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_GetBoolAnimationChannel()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_GetBoolAnimationChannel");
        
        Value_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Value");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_GetBoolAnimationChannel(IntPtr InNativeStruct)
    {
        unsafe
        {
            Value = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, Value_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, Value_Offset), 0, null, Value);
        }
    }
}

public static class RigUnit_GetBoolAnimationChannelMarshaler
{
    public static RigUnit_GetBoolAnimationChannel FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_GetBoolAnimationChannel(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_GetBoolAnimationChannel obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_GetBoolAnimationChannel.NativeDataSize;
    }
}