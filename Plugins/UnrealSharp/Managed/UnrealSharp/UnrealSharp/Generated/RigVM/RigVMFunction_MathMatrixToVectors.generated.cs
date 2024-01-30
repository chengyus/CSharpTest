using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_MathMatrixToVectors
{
    // StructProperty /Script/RigVM.RigVMFunction_MathMatrixToVectors:Value
    static readonly int Value_Offset;
    public System.DoubleNumerics.Matrix4x4 Value;
    
    // StructProperty /Script/RigVM.RigVMFunction_MathMatrixToVectors:Origin
    static readonly int Origin_Offset;
    public System.DoubleNumerics.Vector3 Origin;
    
    // StructProperty /Script/RigVM.RigVMFunction_MathMatrixToVectors:X
    static readonly int X_Offset;
    public System.DoubleNumerics.Vector3 X;
    
    // StructProperty /Script/RigVM.RigVMFunction_MathMatrixToVectors:Y
    static readonly int Y_Offset;
    public System.DoubleNumerics.Vector3 Y;
    
    // StructProperty /Script/RigVM.RigVMFunction_MathMatrixToVectors:Z
    static readonly int Z_Offset;
    public System.DoubleNumerics.Vector3 Z;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_MathMatrixToVectors()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_MathMatrixToVectors");
        
        Value_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Value");
        Origin_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Origin");
        X_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "X");
        Y_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Y");
        Z_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Z");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_MathMatrixToVectors(IntPtr InNativeStruct)
    {
        unsafe
        {
            Value = BlittableMarshaller<System.DoubleNumerics.Matrix4x4>.FromNative(IntPtr.Add(InNativeStruct, Value_Offset), 0, null);
            Origin = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Origin_Offset), 0, null);
            X = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, X_Offset), 0, null);
            Y = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Y_Offset), 0, null);
            Z = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Z_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<System.DoubleNumerics.Matrix4x4>.ToNative(IntPtr.Add(Buffer, Value_Offset), 0, null, Value);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Origin_Offset), 0, null, Origin);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, X_Offset), 0, null, X);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Y_Offset), 0, null, Y);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Z_Offset), 0, null, Z);
        }
    }
}

public static class RigVMFunction_MathMatrixToVectorsMarshaler
{
    public static RigVMFunction_MathMatrixToVectors FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_MathMatrixToVectors(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_MathMatrixToVectors obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_MathMatrixToVectors.NativeDataSize;
    }
}