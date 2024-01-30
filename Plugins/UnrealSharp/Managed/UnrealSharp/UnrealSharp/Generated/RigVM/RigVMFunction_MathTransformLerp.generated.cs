using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_MathTransformLerp
{
    // StructProperty /Script/RigVM.RigVMFunction_MathTransformLerp:A
    static readonly int A_Offset;
    public UnrealSharp.Transform A;
    
    // StructProperty /Script/RigVM.RigVMFunction_MathTransformLerp:B
    static readonly int B_Offset;
    public UnrealSharp.Transform B;
    
    // FloatProperty /Script/RigVM.RigVMFunction_MathTransformLerp:T
    static readonly int T_Offset;
    public float T;
    
    // StructProperty /Script/RigVM.RigVMFunction_MathTransformLerp:Result
    static readonly int Result_Offset;
    public UnrealSharp.Transform Result;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_MathTransformLerp()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_MathTransformLerp");
        
        A_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "A");
        B_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "B");
        T_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "T");
        Result_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Result");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_MathTransformLerp(IntPtr InNativeStruct)
    {
        unsafe
        {
            A = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, A_Offset), 0, null);
            B = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, B_Offset), 0, null);
            T = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, T_Offset), 0, null);
            Result = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, Result_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, A_Offset), 0, null, A);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, B_Offset), 0, null, B);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, T_Offset), 0, null, T);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, Result_Offset), 0, null, Result);
        }
    }
}

public static class RigVMFunction_MathTransformLerpMarshaler
{
    public static RigVMFunction_MathTransformLerp FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_MathTransformLerp(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_MathTransformLerp obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_MathTransformLerp.NativeDataSize;
    }
}