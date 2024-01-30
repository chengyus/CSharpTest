using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_GetTransformAnimationChannel
{
    // StructProperty /Script/ControlRig.RigUnit_GetTransformAnimationChannel:Value
    static readonly int Value_Offset;
    public UnrealSharp.Transform Value;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_GetTransformAnimationChannel()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_GetTransformAnimationChannel");
        
        Value_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Value");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_GetTransformAnimationChannel(IntPtr InNativeStruct)
    {
        unsafe
        {
            Value = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, Value_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, Value_Offset), 0, null, Value);
        }
    }
}

public static class RigUnit_GetTransformAnimationChannelMarshaler
{
    public static RigUnit_GetTransformAnimationChannel FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_GetTransformAnimationChannel(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_GetTransformAnimationChannel obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_GetTransformAnimationChannel.NativeDataSize;
    }
}