using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_MathMatrixFromVectors
{
    // StructProperty /Script/RigVM.RigVMFunction_MathMatrixFromVectors:Origin
    static readonly int Origin_Offset;
    public System.DoubleNumerics.Vector3 Origin;
    
    // StructProperty /Script/RigVM.RigVMFunction_MathMatrixFromVectors:X
    static readonly int X_Offset;
    public System.DoubleNumerics.Vector3 X;
    
    // StructProperty /Script/RigVM.RigVMFunction_MathMatrixFromVectors:Y
    static readonly int Y_Offset;
    public System.DoubleNumerics.Vector3 Y;
    
    // StructProperty /Script/RigVM.RigVMFunction_MathMatrixFromVectors:Z
    static readonly int Z_Offset;
    public System.DoubleNumerics.Vector3 Z;
    
    // StructProperty /Script/RigVM.RigVMFunction_MathMatrixFromVectors:Result
    static readonly int Result_Offset;
    public System.DoubleNumerics.Matrix4x4 Result;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_MathMatrixFromVectors()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_MathMatrixFromVectors");
        
        Origin_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Origin");
        X_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "X");
        Y_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Y");
        Z_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Z");
        Result_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Result");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_MathMatrixFromVectors(IntPtr InNativeStruct)
    {
        unsafe
        {
            Origin = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Origin_Offset), 0, null);
            X = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, X_Offset), 0, null);
            Y = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Y_Offset), 0, null);
            Z = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Z_Offset), 0, null);
            Result = BlittableMarshaller<System.DoubleNumerics.Matrix4x4>.FromNative(IntPtr.Add(InNativeStruct, Result_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Origin_Offset), 0, null, Origin);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, X_Offset), 0, null, X);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Y_Offset), 0, null, Y);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Z_Offset), 0, null, Z);
            BlittableMarshaller<System.DoubleNumerics.Matrix4x4>.ToNative(IntPtr.Add(Buffer, Result_Offset), 0, null, Result);
        }
    }
}

public static class RigVMFunction_MathMatrixFromVectorsMarshaler
{
    public static RigVMFunction_MathMatrixFromVectors FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_MathMatrixFromVectors(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_MathMatrixFromVectors obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_MathMatrixFromVectors.NativeDataSize;
    }
}