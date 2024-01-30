using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct MathRBFInterpolateVectorQuat_Target
{
    // StructProperty /Script/RigVM.MathRBFInterpolateVectorQuat_Target:Target
    static readonly int Target_Offset;
    public System.DoubleNumerics.Vector3 Target;
    
    // StructProperty /Script/RigVM.MathRBFInterpolateVectorQuat_Target:Value
    static readonly int Value_Offset;
    public System.DoubleNumerics.Quaternion Value;
    
    
    public static readonly int NativeDataSize;
    static MathRBFInterpolateVectorQuat_Target()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("MathRBFInterpolateVectorQuat_Target");
        
        Target_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Target");
        Value_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Value");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public MathRBFInterpolateVectorQuat_Target(IntPtr InNativeStruct)
    {
        unsafe
        {
            Target = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Target_Offset), 0, null);
            Value = BlittableMarshaller<System.DoubleNumerics.Quaternion>.FromNative(IntPtr.Add(InNativeStruct, Value_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Target_Offset), 0, null, Target);
            BlittableMarshaller<System.DoubleNumerics.Quaternion>.ToNative(IntPtr.Add(Buffer, Value_Offset), 0, null, Value);
        }
    }
}

public static class MathRBFInterpolateVectorQuat_TargetMarshaler
{
    public static MathRBFInterpolateVectorQuat_Target FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new MathRBFInterpolateVectorQuat_Target(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, MathRBFInterpolateVectorQuat_Target obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return MathRBFInterpolateVectorQuat_Target.NativeDataSize;
    }
}