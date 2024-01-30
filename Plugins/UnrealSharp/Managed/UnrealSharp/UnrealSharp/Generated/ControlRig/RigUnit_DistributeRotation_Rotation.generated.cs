using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_DistributeRotation_Rotation
{
    // StructProperty /Script/ControlRig.RigUnit_DistributeRotation_Rotation:Rotation
    static readonly int Rotation_Offset;
    public System.DoubleNumerics.Quaternion Rotation;
    
    // FloatProperty /Script/ControlRig.RigUnit_DistributeRotation_Rotation:Ratio
    static readonly int Ratio_Offset;
    public float Ratio;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_DistributeRotation_Rotation()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_DistributeRotation_Rotation");
        
        Rotation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Rotation");
        Ratio_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Ratio");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_DistributeRotation_Rotation(IntPtr InNativeStruct)
    {
        unsafe
        {
            Rotation = BlittableMarshaller<System.DoubleNumerics.Quaternion>.FromNative(IntPtr.Add(InNativeStruct, Rotation_Offset), 0, null);
            Ratio = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Ratio_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<System.DoubleNumerics.Quaternion>.ToNative(IntPtr.Add(Buffer, Rotation_Offset), 0, null, Rotation);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Ratio_Offset), 0, null, Ratio);
        }
    }
}

public static class RigUnit_DistributeRotation_RotationMarshaler
{
    public static RigUnit_DistributeRotation_Rotation FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_DistributeRotation_Rotation(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_DistributeRotation_Rotation obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_DistributeRotation_Rotation.NativeDataSize;
    }
}