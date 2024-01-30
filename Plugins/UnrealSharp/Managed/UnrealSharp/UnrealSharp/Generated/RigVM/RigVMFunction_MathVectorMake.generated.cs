using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_MathVectorMake
{
    // FloatProperty /Script/RigVM.RigVMFunction_MathVectorMake:X
    static readonly int X_Offset;
    public float X;
    
    // FloatProperty /Script/RigVM.RigVMFunction_MathVectorMake:Y
    static readonly int Y_Offset;
    public float Y;
    
    // FloatProperty /Script/RigVM.RigVMFunction_MathVectorMake:Z
    static readonly int Z_Offset;
    public float Z;
    
    // StructProperty /Script/RigVM.RigVMFunction_MathVectorMake:Result
    static readonly int Result_Offset;
    public System.DoubleNumerics.Vector3 Result;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_MathVectorMake()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_MathVectorMake");
        
        X_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "X");
        Y_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Y");
        Z_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Z");
        Result_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Result");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_MathVectorMake(IntPtr InNativeStruct)
    {
        unsafe
        {
            X = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, X_Offset), 0, null);
            Y = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Y_Offset), 0, null);
            Z = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Z_Offset), 0, null);
            Result = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Result_Offset), 0, null);
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
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Result_Offset), 0, null, Result);
        }
    }
}

public static class RigVMFunction_MathVectorMakeMarshaler
{
    public static RigVMFunction_MathVectorMake FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_MathVectorMake(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_MathVectorMake obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_MathVectorMake.NativeDataSize;
    }
}