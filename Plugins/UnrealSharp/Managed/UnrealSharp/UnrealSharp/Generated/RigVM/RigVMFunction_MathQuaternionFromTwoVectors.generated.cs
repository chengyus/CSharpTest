using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_MathQuaternionFromTwoVectors
{
    // StructProperty /Script/RigVM.RigVMFunction_MathQuaternionFromTwoVectors:A
    static readonly int A_Offset;
    public System.DoubleNumerics.Vector3 A;
    
    // StructProperty /Script/RigVM.RigVMFunction_MathQuaternionFromTwoVectors:B
    static readonly int B_Offset;
    public System.DoubleNumerics.Vector3 B;
    
    // StructProperty /Script/RigVM.RigVMFunction_MathQuaternionFromTwoVectors:Result
    static readonly int Result_Offset;
    public System.DoubleNumerics.Quaternion Result;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_MathQuaternionFromTwoVectors()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_MathQuaternionFromTwoVectors");
        
        A_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "A");
        B_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "B");
        Result_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Result");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_MathQuaternionFromTwoVectors(IntPtr InNativeStruct)
    {
        unsafe
        {
            A = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, A_Offset), 0, null);
            B = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, B_Offset), 0, null);
            Result = BlittableMarshaller<System.DoubleNumerics.Quaternion>.FromNative(IntPtr.Add(InNativeStruct, Result_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, A_Offset), 0, null, A);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, B_Offset), 0, null, B);
            BlittableMarshaller<System.DoubleNumerics.Quaternion>.ToNative(IntPtr.Add(Buffer, Result_Offset), 0, null, Result);
        }
    }
}

public static class RigVMFunction_MathQuaternionFromTwoVectorsMarshaler
{
    public static RigVMFunction_MathQuaternionFromTwoVectors FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_MathQuaternionFromTwoVectors(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_MathQuaternionFromTwoVectors obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_MathQuaternionFromTwoVectors.NativeDataSize;
    }
}