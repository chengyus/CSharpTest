using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_NoiseVector2
{
    // StructProperty /Script/RigVM.RigVMFunction_NoiseVector2:Value
    static readonly int Value_Offset;
    public System.DoubleNumerics.Vector3 Value;
    
    // StructProperty /Script/RigVM.RigVMFunction_NoiseVector2:Speed
    static readonly int Speed_Offset;
    public System.DoubleNumerics.Vector3 Speed;
    
    // StructProperty /Script/RigVM.RigVMFunction_NoiseVector2:Frequency
    static readonly int Frequency_Offset;
    public System.DoubleNumerics.Vector3 Frequency;
    
    // DoubleProperty /Script/RigVM.RigVMFunction_NoiseVector2:Minimum
    static readonly int Minimum_Offset;
    public double Minimum;
    
    // DoubleProperty /Script/RigVM.RigVMFunction_NoiseVector2:Maximum
    static readonly int Maximum_Offset;
    public double Maximum;
    
    // StructProperty /Script/RigVM.RigVMFunction_NoiseVector2:Result
    static readonly int Result_Offset;
    public System.DoubleNumerics.Vector3 Result;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_NoiseVector2()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_NoiseVector2");
        
        Value_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Value");
        Speed_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Speed");
        Frequency_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Frequency");
        Minimum_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Minimum");
        Maximum_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Maximum");
        Result_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Result");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_NoiseVector2(IntPtr InNativeStruct)
    {
        unsafe
        {
            Value = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Value_Offset), 0, null);
            Speed = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Speed_Offset), 0, null);
            Frequency = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Frequency_Offset), 0, null);
            Minimum = BlittableMarshaller<double>.FromNative(IntPtr.Add(InNativeStruct, Minimum_Offset), 0, null);
            Maximum = BlittableMarshaller<double>.FromNative(IntPtr.Add(InNativeStruct, Maximum_Offset), 0, null);
            Result = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Result_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Value_Offset), 0, null, Value);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Speed_Offset), 0, null, Speed);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Frequency_Offset), 0, null, Frequency);
            BlittableMarshaller<double>.ToNative(IntPtr.Add(Buffer, Minimum_Offset), 0, null, Minimum);
            BlittableMarshaller<double>.ToNative(IntPtr.Add(Buffer, Maximum_Offset), 0, null, Maximum);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Result_Offset), 0, null, Result);
        }
    }
}

public static class RigVMFunction_NoiseVector2Marshaler
{
    public static RigVMFunction_NoiseVector2 FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_NoiseVector2(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_NoiseVector2 obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_NoiseVector2.NativeDataSize;
    }
}