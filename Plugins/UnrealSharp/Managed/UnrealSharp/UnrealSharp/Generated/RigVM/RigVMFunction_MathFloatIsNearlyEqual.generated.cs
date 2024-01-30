using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_MathFloatIsNearlyEqual
{
    // FloatProperty /Script/RigVM.RigVMFunction_MathFloatIsNearlyEqual:A
    static readonly int A_Offset;
    public float A;
    
    // FloatProperty /Script/RigVM.RigVMFunction_MathFloatIsNearlyEqual:B
    static readonly int B_Offset;
    public float B;
    
    // FloatProperty /Script/RigVM.RigVMFunction_MathFloatIsNearlyEqual:Tolerance
    static readonly int Tolerance_Offset;
    public float Tolerance;
    
    // BoolProperty /Script/RigVM.RigVMFunction_MathFloatIsNearlyEqual:Result
    static readonly int Result_Offset;
    public bool Result;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_MathFloatIsNearlyEqual()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_MathFloatIsNearlyEqual");
        
        A_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "A");
        B_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "B");
        Tolerance_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Tolerance");
        Result_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Result");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_MathFloatIsNearlyEqual(IntPtr InNativeStruct)
    {
        unsafe
        {
            A = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, A_Offset), 0, null);
            B = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, B_Offset), 0, null);
            Tolerance = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Tolerance_Offset), 0, null);
            Result = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, Result_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, A_Offset), 0, null, A);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, B_Offset), 0, null, B);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Tolerance_Offset), 0, null, Tolerance);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, Result_Offset), 0, null, Result);
        }
    }
}

public static class RigVMFunction_MathFloatIsNearlyEqualMarshaler
{
    public static RigVMFunction_MathFloatIsNearlyEqual FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_MathFloatIsNearlyEqual(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_MathFloatIsNearlyEqual obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_MathFloatIsNearlyEqual.NativeDataSize;
    }
}