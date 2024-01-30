using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_MathQuaternionMake
{
    // FloatProperty /Script/RigVM.RigVMFunction_MathQuaternionMake:X
    static readonly int X_Offset;
    public float X;
    
    // FloatProperty /Script/RigVM.RigVMFunction_MathQuaternionMake:Y
    static readonly int Y_Offset;
    public float Y;
    
    // FloatProperty /Script/RigVM.RigVMFunction_MathQuaternionMake:Z
    static readonly int Z_Offset;
    public float Z;
    
    // FloatProperty /Script/RigVM.RigVMFunction_MathQuaternionMake:W
    static readonly int W_Offset;
    public float W;
    
    // StructProperty /Script/RigVM.RigVMFunction_MathQuaternionMake:Result
    static readonly int Result_Offset;
    public System.DoubleNumerics.Quaternion Result;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_MathQuaternionMake()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_MathQuaternionMake");
        
        X_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "X");
        Y_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Y");
        Z_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Z");
        W_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "W");
        Result_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Result");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_MathQuaternionMake(IntPtr InNativeStruct)
    {
        unsafe
        {
            X = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, X_Offset), 0, null);
            Y = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Y_Offset), 0, null);
            Z = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Z_Offset), 0, null);
            W = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, W_Offset), 0, null);
            Result = BlittableMarshaller<System.DoubleNumerics.Quaternion>.FromNative(IntPtr.Add(InNativeStruct, Result_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, X_Offset), 0, null, X);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Y_Offset), 0, null, Y);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Z_Offset), 0, null, Z);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, W_Offset), 0, null, W);
            BlittableMarshaller<System.DoubleNumerics.Quaternion>.ToNative(IntPtr.Add(Buffer, Result_Offset), 0, null, Result);
        }
    }
}

public static class RigVMFunction_MathQuaternionMakeMarshaler
{
    public static RigVMFunction_MathQuaternionMake FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_MathQuaternionMake(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_MathQuaternionMake obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_MathQuaternionMake.NativeDataSize;
    }
}