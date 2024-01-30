using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_NoiseDouble
{
    // DoubleProperty /Script/RigVM.RigVMFunction_NoiseDouble:Value
    static readonly int Value_Offset;
    public double Value;
    
    // DoubleProperty /Script/RigVM.RigVMFunction_NoiseDouble:Speed
    static readonly int Speed_Offset;
    public double Speed;
    
    // DoubleProperty /Script/RigVM.RigVMFunction_NoiseDouble:Frequency
    static readonly int Frequency_Offset;
    public double Frequency;
    
    // DoubleProperty /Script/RigVM.RigVMFunction_NoiseDouble:Minimum
    static readonly int Minimum_Offset;
    public double Minimum;
    
    // DoubleProperty /Script/RigVM.RigVMFunction_NoiseDouble:Maximum
    static readonly int Maximum_Offset;
    public double Maximum;
    
    // DoubleProperty /Script/RigVM.RigVMFunction_NoiseDouble:Result
    static readonly int Result_Offset;
    public double Result;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_NoiseDouble()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_NoiseDouble");
        
        Value_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Value");
        Speed_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Speed");
        Frequency_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Frequency");
        Minimum_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Minimum");
        Maximum_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Maximum");
        Result_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Result");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_NoiseDouble(IntPtr InNativeStruct)
    {
        unsafe
        {
            Value = BlittableMarshaller<double>.FromNative(IntPtr.Add(InNativeStruct, Value_Offset), 0, null);
            Speed = BlittableMarshaller<double>.FromNative(IntPtr.Add(InNativeStruct, Speed_Offset), 0, null);
            Frequency = BlittableMarshaller<double>.FromNative(IntPtr.Add(InNativeStruct, Frequency_Offset), 0, null);
            Minimum = BlittableMarshaller<double>.FromNative(IntPtr.Add(InNativeStruct, Minimum_Offset), 0, null);
            Maximum = BlittableMarshaller<double>.FromNative(IntPtr.Add(InNativeStruct, Maximum_Offset), 0, null);
            Result = BlittableMarshaller<double>.FromNative(IntPtr.Add(InNativeStruct, Result_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<double>.ToNative(IntPtr.Add(Buffer, Value_Offset), 0, null, Value);
            BlittableMarshaller<double>.ToNative(IntPtr.Add(Buffer, Speed_Offset), 0, null, Speed);
            BlittableMarshaller<double>.ToNative(IntPtr.Add(Buffer, Frequency_Offset), 0, null, Frequency);
            BlittableMarshaller<double>.ToNative(IntPtr.Add(Buffer, Minimum_Offset), 0, null, Minimum);
            BlittableMarshaller<double>.ToNative(IntPtr.Add(Buffer, Maximum_Offset), 0, null, Maximum);
            BlittableMarshaller<double>.ToNative(IntPtr.Add(Buffer, Result_Offset), 0, null, Result);
        }
    }
}

public static class RigVMFunction_NoiseDoubleMarshaler
{
    public static RigVMFunction_NoiseDouble FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_NoiseDouble(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_NoiseDouble obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_NoiseDouble.NativeDataSize;
    }
}