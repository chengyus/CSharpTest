using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_MathTransformFromEulerTransform
{
    // StructProperty /Script/RigVM.RigVMFunction_MathTransformFromEulerTransform:EulerTransform
    static readonly int EulerTransform_Offset;
    public UnrealSharp.AnimationCore.EulerTransform EulerTransform;
    
    // StructProperty /Script/RigVM.RigVMFunction_MathTransformFromEulerTransform:Result
    static readonly int Result_Offset;
    public UnrealSharp.Transform Result;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_MathTransformFromEulerTransform()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_MathTransformFromEulerTransform");
        
        EulerTransform_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "EulerTransform");
        Result_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Result");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_MathTransformFromEulerTransform(IntPtr InNativeStruct)
    {
        unsafe
        {
            EulerTransform = BlittableMarshaller<UnrealSharp.AnimationCore.EulerTransform>.FromNative(IntPtr.Add(InNativeStruct, EulerTransform_Offset), 0, null);
            Result = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, Result_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.AnimationCore.EulerTransform>.ToNative(IntPtr.Add(Buffer, EulerTransform_Offset), 0, null, EulerTransform);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, Result_Offset), 0, null, Result);
        }
    }
}

public static class RigVMFunction_MathTransformFromEulerTransformMarshaler
{
    public static RigVMFunction_MathTransformFromEulerTransform FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_MathTransformFromEulerTransform(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_MathTransformFromEulerTransform obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_MathTransformFromEulerTransform.NativeDataSize;
    }
}