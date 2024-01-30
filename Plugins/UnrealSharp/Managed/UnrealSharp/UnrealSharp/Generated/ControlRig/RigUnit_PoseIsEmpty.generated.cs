using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_PoseIsEmpty
{
    // StructProperty /Script/ControlRig.RigUnit_PoseIsEmpty:Pose
    static readonly int Pose_Offset;
    public UnrealSharp.ControlRig.RigPose Pose;
    
    // BoolProperty /Script/ControlRig.RigUnit_PoseIsEmpty:IsEmpty
    static readonly int IsEmpty_Offset;
    public bool IsEmpty;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_PoseIsEmpty()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_PoseIsEmpty");
        
        Pose_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Pose");
        IsEmpty_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "IsEmpty");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_PoseIsEmpty(IntPtr InNativeStruct)
    {
        unsafe
        {
            Pose = UnrealSharp.ControlRig.RigPoseMarshaler.FromNative(IntPtr.Add(InNativeStruct, Pose_Offset), 0, null);
            IsEmpty = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, IsEmpty_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.ControlRig.RigPoseMarshaler.ToNative(IntPtr.Add(Buffer, Pose_Offset), 0, null, Pose);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, IsEmpty_Offset), 0, null, IsEmpty);
        }
    }
}

public static class RigUnit_PoseIsEmptyMarshaler
{
    public static RigUnit_PoseIsEmpty FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_PoseIsEmpty(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_PoseIsEmpty obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_PoseIsEmpty.NativeDataSize;
    }
}