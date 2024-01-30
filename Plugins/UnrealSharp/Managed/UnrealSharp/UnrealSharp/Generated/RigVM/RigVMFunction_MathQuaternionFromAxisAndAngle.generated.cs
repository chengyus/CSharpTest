using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_MathQuaternionFromAxisAndAngle
{
    // StructProperty /Script/RigVM.RigVMFunction_MathQuaternionFromAxisAndAngle:Axis
    static readonly int Axis_Offset;
    public System.DoubleNumerics.Vector3 Axis;
    
    // FloatProperty /Script/RigVM.RigVMFunction_MathQuaternionFromAxisAndAngle:Angle
    static readonly int Angle_Offset;
    public float Angle;
    
    // StructProperty /Script/RigVM.RigVMFunction_MathQuaternionFromAxisAndAngle:Result
    static readonly int Result_Offset;
    public System.DoubleNumerics.Quaternion Result;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_MathQuaternionFromAxisAndAngle()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_MathQuaternionFromAxisAndAngle");
        
        Axis_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Axis");
        Angle_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Angle");
        Result_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Result");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_MathQuaternionFromAxisAndAngle(IntPtr InNativeStruct)
    {
        unsafe
        {
            Axis = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Axis_Offset), 0, null);
            Angle = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Angle_Offset), 0, null);
            Result = BlittableMarshaller<System.DoubleNumerics.Quaternion>.FromNative(IntPtr.Add(InNativeStruct, Result_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Axis_Offset), 0, null, Axis);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Angle_Offset), 0, null, Angle);
            BlittableMarshaller<System.DoubleNumerics.Quaternion>.ToNative(IntPtr.Add(Buffer, Result_Offset), 0, null, Result);
        }
    }
}

public static class RigVMFunction_MathQuaternionFromAxisAndAngleMarshaler
{
    public static RigVMFunction_MathQuaternionFromAxisAndAngle FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_MathQuaternionFromAxisAndAngle(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_MathQuaternionFromAxisAndAngle obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_MathQuaternionFromAxisAndAngle.NativeDataSize;
    }
}