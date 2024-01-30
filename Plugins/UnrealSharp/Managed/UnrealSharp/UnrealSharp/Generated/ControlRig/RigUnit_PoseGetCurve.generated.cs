using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_PoseGetCurve
{
    // StructProperty /Script/ControlRig.RigUnit_PoseGetCurve:Pose
    static readonly int Pose_Offset;
    public UnrealSharp.ControlRig.RigPose Pose;
    
    // NameProperty /Script/ControlRig.RigUnit_PoseGetCurve:Curve
    static readonly int Curve_Offset;
    public Name Curve;
    
    // BoolProperty /Script/ControlRig.RigUnit_PoseGetCurve:Valid
    static readonly int Valid_Offset;
    public bool Valid;
    
    // FloatProperty /Script/ControlRig.RigUnit_PoseGetCurve:CurveValue
    static readonly int CurveValue_Offset;
    public float CurveValue;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_PoseGetCurve()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_PoseGetCurve");
        
        Pose_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Pose");
        Curve_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Curve");
        Valid_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Valid");
        CurveValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CurveValue");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_PoseGetCurve(IntPtr InNativeStruct)
    {
        unsafe
        {
            Pose = UnrealSharp.ControlRig.RigPoseMarshaler.FromNative(IntPtr.Add(InNativeStruct, Pose_Offset), 0, null);
            Curve = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, Curve_Offset), 0, null);
            Valid = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, Valid_Offset), 0, null);
            CurveValue = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, CurveValue_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.ControlRig.RigPoseMarshaler.ToNative(IntPtr.Add(Buffer, Pose_Offset), 0, null, Pose);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, Curve_Offset), 0, null, Curve);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, Valid_Offset), 0, null, Valid);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, CurveValue_Offset), 0, null, CurveValue);
        }
    }
}

public static class RigUnit_PoseGetCurveMarshaler
{
    public static RigUnit_PoseGetCurve FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_PoseGetCurve(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_PoseGetCurve obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_PoseGetCurve.NativeDataSize;
    }
}