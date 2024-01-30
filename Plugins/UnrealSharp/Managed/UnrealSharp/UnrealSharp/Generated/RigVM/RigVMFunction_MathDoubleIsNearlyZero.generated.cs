using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_MathDoubleIsNearlyZero
{
    // DoubleProperty /Script/RigVM.RigVMFunction_MathDoubleIsNearlyZero:Value
    static readonly int Value_Offset;
    public double Value;
    
    // DoubleProperty /Script/RigVM.RigVMFunction_MathDoubleIsNearlyZero:Tolerance
    static readonly int Tolerance_Offset;
    public double Tolerance;
    
    // BoolProperty /Script/RigVM.RigVMFunction_MathDoubleIsNearlyZero:Result
    static readonly int Result_Offset;
    public bool Result;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_MathDoubleIsNearlyZero()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_MathDoubleIsNearlyZero");
        
        Value_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Value");
        Tolerance_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Tolerance");
        Result_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Result");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_MathDoubleIsNearlyZero(IntPtr InNativeStruct)
    {
        unsafe
        {
            Value = BlittableMarshaller<double>.FromNative(IntPtr.Add(InNativeStruct, Value_Offset), 0, null);
            Tolerance = BlittableMarshaller<double>.FromNative(IntPtr.Add(InNativeStruct, Tolerance_Offset), 0, null);
            Result = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, Result_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<double>.ToNative(IntPtr.Add(Buffer, Value_Offset), 0, null, Value);
            BlittableMarshaller<double>.ToNative(IntPtr.Add(Buffer, Tolerance_Offset), 0, null, Tolerance);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, Result_Offset), 0, null, Result);
        }
    }
}

public static class RigVMFunction_MathDoubleIsNearlyZeroMarshaler
{
    public static RigVMFunction_MathDoubleIsNearlyZero FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_MathDoubleIsNearlyZero(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_MathDoubleIsNearlyZero obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_MathDoubleIsNearlyZero.NativeDataSize;
    }
}