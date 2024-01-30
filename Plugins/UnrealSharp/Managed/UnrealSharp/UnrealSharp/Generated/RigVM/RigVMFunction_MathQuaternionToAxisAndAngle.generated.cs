using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_MathQuaternionToAxisAndAngle
{
    // StructProperty /Script/RigVM.RigVMFunction_MathQuaternionToAxisAndAngle:Value
    static readonly int Value_Offset;
    public System.DoubleNumerics.Quaternion Value;
    
    // StructProperty /Script/RigVM.RigVMFunction_MathQuaternionToAxisAndAngle:Axis
    static readonly int Axis_Offset;
    public System.DoubleNumerics.Vector3 Axis;
    
    // FloatProperty /Script/RigVM.RigVMFunction_MathQuaternionToAxisAndAngle:Angle
    static readonly int Angle_Offset;
    public float Angle;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_MathQuaternionToAxisAndAngle()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_MathQuaternionToAxisAndAngle");
        
        Value_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Value");
        Axis_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Axis");
        Angle_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Angle");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_MathQuaternionToAxisAndAngle(IntPtr InNativeStruct)
    {
        unsafe
        {
            Value = BlittableMarshaller<System.DoubleNumerics.Quaternion>.FromNative(IntPtr.Add(InNativeStruct, Value_Offset), 0, null);
            Axis = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Axis_Offset), 0, null);
            Angle = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Angle_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<System.DoubleNumerics.Quaternion>.ToNative(IntPtr.Add(Buffer, Value_Offset), 0, null, Value);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Axis_Offset), 0, null, Axis);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Angle_Offset), 0, null, Angle);
        }
    }
}

public static class RigVMFunction_MathQuaternionToAxisAndAngleMarshaler
{
    public static RigVMFunction_MathQuaternionToAxisAndAngle FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_MathQuaternionToAxisAndAngle(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_MathQuaternionToAxisAndAngle obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_MathQuaternionToAxisAndAngle.NativeDataSize;
    }
}