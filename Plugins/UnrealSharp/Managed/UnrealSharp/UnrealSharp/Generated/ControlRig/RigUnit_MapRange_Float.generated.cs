using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_MapRange_Float
{
    // FloatProperty /Script/ControlRig.RigUnit_MapRange_Float:Value
    static readonly int Value_Offset;
    public float Value;
    
    // FloatProperty /Script/ControlRig.RigUnit_MapRange_Float:MinIn
    static readonly int MinIn_Offset;
    public float MinIn;
    
    // FloatProperty /Script/ControlRig.RigUnit_MapRange_Float:MaxIn
    static readonly int MaxIn_Offset;
    public float MaxIn;
    
    // FloatProperty /Script/ControlRig.RigUnit_MapRange_Float:MinOut
    static readonly int MinOut_Offset;
    public float MinOut;
    
    // FloatProperty /Script/ControlRig.RigUnit_MapRange_Float:MaxOut
    static readonly int MaxOut_Offset;
    public float MaxOut;
    
    // FloatProperty /Script/ControlRig.RigUnit_MapRange_Float:Result
    static readonly int Result_Offset;
    public float Result;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_MapRange_Float()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_MapRange_Float");
        
        Value_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Value");
        MinIn_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MinIn");
        MaxIn_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MaxIn");
        MinOut_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MinOut");
        MaxOut_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MaxOut");
        Result_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Result");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_MapRange_Float(IntPtr InNativeStruct)
    {
        unsafe
        {
            Value = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Value_Offset), 0, null);
            MinIn = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MinIn_Offset), 0, null);
            MaxIn = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MaxIn_Offset), 0, null);
            MinOut = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MinOut_Offset), 0, null);
            MaxOut = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MaxOut_Offset), 0, null);
            Result = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Result_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Value_Offset), 0, null, Value);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MinIn_Offset), 0, null, MinIn);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MaxIn_Offset), 0, null, MaxIn);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MinOut_Offset), 0, null, MinOut);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MaxOut_Offset), 0, null, MaxOut);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Result_Offset), 0, null, Result);
        }
    }
}

public static class RigUnit_MapRange_FloatMarshaler
{
    public static RigUnit_MapRange_Float FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_MapRange_Float(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_MapRange_Float obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_MapRange_Float.NativeDataSize;
    }
}