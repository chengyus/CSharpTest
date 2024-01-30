using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_QuaternionToAxisAndAngle
{
    // StructProperty /Script/ControlRig.RigUnit_QuaternionToAxisAndAngle:Argument
    static readonly int Argument_Offset;
    public System.DoubleNumerics.Quaternion Argument;
    
    // StructProperty /Script/ControlRig.RigUnit_QuaternionToAxisAndAngle:Axis
    static readonly int Axis_Offset;
    public System.DoubleNumerics.Vector3 Axis;
    
    // FloatProperty /Script/ControlRig.RigUnit_QuaternionToAxisAndAngle:Angle
    static readonly int Angle_Offset;
    public float Angle;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_QuaternionToAxisAndAngle()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_QuaternionToAxisAndAngle");
        
        Argument_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Argument");
        Axis_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Axis");
        Angle_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Angle");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_QuaternionToAxisAndAngle(IntPtr InNativeStruct)
    {
        unsafe
        {
            Argument = BlittableMarshaller<System.DoubleNumerics.Quaternion>.FromNative(IntPtr.Add(InNativeStruct, Argument_Offset), 0, null);
            Axis = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Axis_Offset), 0, null);
            Angle = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Angle_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<System.DoubleNumerics.Quaternion>.ToNative(IntPtr.Add(Buffer, Argument_Offset), 0, null, Argument);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Axis_Offset), 0, null, Axis);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Angle_Offset), 0, null, Angle);
        }
    }
}

public static class RigUnit_QuaternionToAxisAndAngleMarshaler
{
    public static RigUnit_QuaternionToAxisAndAngle FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_QuaternionToAxisAndAngle(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_QuaternionToAxisAndAngle obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_QuaternionToAxisAndAngle.NativeDataSize;
    }
}