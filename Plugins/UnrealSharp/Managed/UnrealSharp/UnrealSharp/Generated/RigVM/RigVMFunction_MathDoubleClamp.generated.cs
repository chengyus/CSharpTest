using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_MathDoubleClamp
{
    // DoubleProperty /Script/RigVM.RigVMFunction_MathDoubleClamp:Value
    static readonly int Value_Offset;
    public double Value;
    
    // DoubleProperty /Script/RigVM.RigVMFunction_MathDoubleClamp:Minimum
    static readonly int Minimum_Offset;
    public double Minimum;
    
    // DoubleProperty /Script/RigVM.RigVMFunction_MathDoubleClamp:Maximum
    static readonly int Maximum_Offset;
    public double Maximum;
    
    // DoubleProperty /Script/RigVM.RigVMFunction_MathDoubleClamp:Result
    static readonly int Result_Offset;
    public double Result;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_MathDoubleClamp()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_MathDoubleClamp");
        
        Value_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Value");
        Minimum_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Minimum");
        Maximum_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Maximum");
        Result_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Result");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_MathDoubleClamp(IntPtr InNativeStruct)
    {
        unsafe
        {
            Value = BlittableMarshaller<double>.FromNative(IntPtr.Add(InNativeStruct, Value_Offset), 0, null);
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
            BlittableMarshaller<double>.ToNative(IntPtr.Add(Buffer, Minimum_Offset), 0, null, Minimum);
            BlittableMarshaller<double>.ToNative(IntPtr.Add(Buffer, Maximum_Offset), 0, null, Maximum);
            BlittableMarshaller<double>.ToNative(IntPtr.Add(Buffer, Result_Offset), 0, null, Result);
        }
    }
}

public static class RigVMFunction_MathDoubleClampMarshaler
{
    public static RigVMFunction_MathDoubleClamp FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_MathDoubleClamp(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_MathDoubleClamp obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_MathDoubleClamp.NativeDataSize;
    }
}