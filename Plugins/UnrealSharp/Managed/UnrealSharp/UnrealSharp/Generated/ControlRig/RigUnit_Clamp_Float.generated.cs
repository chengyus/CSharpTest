using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_Clamp_Float
{
    // FloatProperty /Script/ControlRig.RigUnit_Clamp_Float:Value
    static readonly int Value_Offset;
    public float Value;
    
    // FloatProperty /Script/ControlRig.RigUnit_Clamp_Float:Min
    static readonly int Min_Offset;
    public float Min;
    
    // FloatProperty /Script/ControlRig.RigUnit_Clamp_Float:Max
    static readonly int Max_Offset;
    public float Max;
    
    // FloatProperty /Script/ControlRig.RigUnit_Clamp_Float:Result
    static readonly int Result_Offset;
    public float Result;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_Clamp_Float()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_Clamp_Float");
        
        Value_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Value");
        Min_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Min");
        Max_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Max");
        Result_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Result");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_Clamp_Float(IntPtr InNativeStruct)
    {
        unsafe
        {
            Value = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Value_Offset), 0, null);
            Min = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Min_Offset), 0, null);
            Max = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Max_Offset), 0, null);
            Result = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Result_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Value_Offset), 0, null, Value);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Min_Offset), 0, null, Min);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Max_Offset), 0, null, Max);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Result_Offset), 0, null, Result);
        }
    }
}

public static class RigUnit_Clamp_FloatMarshaler
{
    public static RigUnit_Clamp_Float FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_Clamp_Float(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_Clamp_Float obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_Clamp_Float.NativeDataSize;
    }
}