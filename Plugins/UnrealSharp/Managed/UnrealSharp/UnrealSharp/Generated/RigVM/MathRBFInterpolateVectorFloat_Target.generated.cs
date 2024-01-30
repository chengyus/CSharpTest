using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct MathRBFInterpolateVectorFloat_Target
{
    // StructProperty /Script/RigVM.MathRBFInterpolateVectorFloat_Target:Target
    static readonly int Target_Offset;
    public System.DoubleNumerics.Vector3 Target;
    
    // FloatProperty /Script/RigVM.MathRBFInterpolateVectorFloat_Target:Value
    static readonly int Value_Offset;
    public float Value;
    
    
    public static readonly int NativeDataSize;
    static MathRBFInterpolateVectorFloat_Target()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("MathRBFInterpolateVectorFloat_Target");
        
        Target_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Target");
        Value_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Value");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public MathRBFInterpolateVectorFloat_Target(IntPtr InNativeStruct)
    {
        unsafe
        {
            Target = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Target_Offset), 0, null);
            Value = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Value_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Target_Offset), 0, null, Target);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Value_Offset), 0, null, Value);
        }
    }
}

public static class MathRBFInterpolateVectorFloat_TargetMarshaler
{
    public static MathRBFInterpolateVectorFloat_Target FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new MathRBFInterpolateVectorFloat_Target(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, MathRBFInterpolateVectorFloat_Target obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return MathRBFInterpolateVectorFloat_Target.NativeDataSize;
    }
}