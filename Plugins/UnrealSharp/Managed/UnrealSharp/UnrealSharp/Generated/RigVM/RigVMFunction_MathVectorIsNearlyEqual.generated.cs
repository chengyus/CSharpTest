using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_MathVectorIsNearlyEqual
{
    // StructProperty /Script/RigVM.RigVMFunction_MathVectorIsNearlyEqual:A
    static readonly int A_Offset;
    public System.DoubleNumerics.Vector3 A;
    
    // StructProperty /Script/RigVM.RigVMFunction_MathVectorIsNearlyEqual:B
    static readonly int B_Offset;
    public System.DoubleNumerics.Vector3 B;
    
    // FloatProperty /Script/RigVM.RigVMFunction_MathVectorIsNearlyEqual:Tolerance
    static readonly int Tolerance_Offset;
    public float Tolerance;
    
    // BoolProperty /Script/RigVM.RigVMFunction_MathVectorIsNearlyEqual:Result
    static readonly int Result_Offset;
    public bool Result;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_MathVectorIsNearlyEqual()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_MathVectorIsNearlyEqual");
        
        A_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "A");
        B_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "B");
        Tolerance_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Tolerance");
        Result_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Result");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_MathVectorIsNearlyEqual(IntPtr InNativeStruct)
    {
        unsafe
        {
            A = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, A_Offset), 0, null);
            B = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, B_Offset), 0, null);
            Tolerance = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Tolerance_Offset), 0, null);
            Result = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, Result_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, A_Offset), 0, null, A);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, B_Offset), 0, null, B);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Tolerance_Offset), 0, null, Tolerance);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, Result_Offset), 0, null, Result);
        }
    }
}

public static class RigVMFunction_MathVectorIsNearlyEqualMarshaler
{
    public static RigVMFunction_MathVectorIsNearlyEqual FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_MathVectorIsNearlyEqual(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_MathVectorIsNearlyEqual obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_MathVectorIsNearlyEqual.NativeDataSize;
    }
}