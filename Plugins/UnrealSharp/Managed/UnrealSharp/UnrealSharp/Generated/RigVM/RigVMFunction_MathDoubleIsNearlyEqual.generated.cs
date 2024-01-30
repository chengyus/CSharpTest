using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_MathDoubleIsNearlyEqual
{
    // DoubleProperty /Script/RigVM.RigVMFunction_MathDoubleIsNearlyEqual:A
    static readonly int A_Offset;
    public double A;
    
    // DoubleProperty /Script/RigVM.RigVMFunction_MathDoubleIsNearlyEqual:B
    static readonly int B_Offset;
    public double B;
    
    // DoubleProperty /Script/RigVM.RigVMFunction_MathDoubleIsNearlyEqual:Tolerance
    static readonly int Tolerance_Offset;
    public double Tolerance;
    
    // BoolProperty /Script/RigVM.RigVMFunction_MathDoubleIsNearlyEqual:Result
    static readonly int Result_Offset;
    public bool Result;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_MathDoubleIsNearlyEqual()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_MathDoubleIsNearlyEqual");
        
        A_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "A");
        B_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "B");
        Tolerance_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Tolerance");
        Result_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Result");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_MathDoubleIsNearlyEqual(IntPtr InNativeStruct)
    {
        unsafe
        {
            A = BlittableMarshaller<double>.FromNative(IntPtr.Add(InNativeStruct, A_Offset), 0, null);
            B = BlittableMarshaller<double>.FromNative(IntPtr.Add(InNativeStruct, B_Offset), 0, null);
            Tolerance = BlittableMarshaller<double>.FromNative(IntPtr.Add(InNativeStruct, Tolerance_Offset), 0, null);
            Result = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, Result_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<double>.ToNative(IntPtr.Add(Buffer, A_Offset), 0, null, A);
            BlittableMarshaller<double>.ToNative(IntPtr.Add(Buffer, B_Offset), 0, null, B);
            BlittableMarshaller<double>.ToNative(IntPtr.Add(Buffer, Tolerance_Offset), 0, null, Tolerance);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, Result_Offset), 0, null, Result);
        }
    }
}

public static class RigVMFunction_MathDoubleIsNearlyEqualMarshaler
{
    public static RigVMFunction_MathDoubleIsNearlyEqual FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_MathDoubleIsNearlyEqual(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_MathDoubleIsNearlyEqual obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_MathDoubleIsNearlyEqual.NativeDataSize;
    }
}