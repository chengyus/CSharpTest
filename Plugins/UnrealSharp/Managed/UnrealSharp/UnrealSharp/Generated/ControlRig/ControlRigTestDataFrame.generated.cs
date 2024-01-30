using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct ControlRigTestDataFrame
{
    // DoubleProperty /Script/ControlRig.ControlRigTestDataFrame:AbsoluteTime
    static readonly int AbsoluteTime_Offset;
    public double AbsoluteTime;
    
    // DoubleProperty /Script/ControlRig.ControlRigTestDataFrame:DeltaTime
    static readonly int DeltaTime_Offset;
    public double DeltaTime;
    
    // StructProperty /Script/ControlRig.ControlRigTestDataFrame:Pose
    static readonly int Pose_Offset;
    public UnrealSharp.ControlRig.RigPose Pose;
    
    
    public static readonly int NativeDataSize;
    static ControlRigTestDataFrame()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("ControlRigTestDataFrame");
        
        AbsoluteTime_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AbsoluteTime");
        DeltaTime_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DeltaTime");
        Pose_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Pose");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public ControlRigTestDataFrame(IntPtr InNativeStruct)
    {
        unsafe
        {
            AbsoluteTime = BlittableMarshaller<double>.FromNative(IntPtr.Add(InNativeStruct, AbsoluteTime_Offset), 0, null);
            DeltaTime = BlittableMarshaller<double>.FromNative(IntPtr.Add(InNativeStruct, DeltaTime_Offset), 0, null);
            Pose = UnrealSharp.ControlRig.RigPoseMarshaler.FromNative(IntPtr.Add(InNativeStruct, Pose_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<double>.ToNative(IntPtr.Add(Buffer, AbsoluteTime_Offset), 0, null, AbsoluteTime);
            BlittableMarshaller<double>.ToNative(IntPtr.Add(Buffer, DeltaTime_Offset), 0, null, DeltaTime);
            UnrealSharp.ControlRig.RigPoseMarshaler.ToNative(IntPtr.Add(Buffer, Pose_Offset), 0, null, Pose);
        }
    }
}

public static class ControlRigTestDataFrameMarshaler
{
    public static ControlRigTestDataFrame FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new ControlRigTestDataFrame(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, ControlRigTestDataFrame obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return ControlRigTestDataFrame.NativeDataSize;
    }
}