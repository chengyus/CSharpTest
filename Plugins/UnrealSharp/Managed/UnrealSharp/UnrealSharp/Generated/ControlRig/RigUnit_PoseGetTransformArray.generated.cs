using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_PoseGetTransformArray
{
    // StructProperty /Script/ControlRig.RigUnit_PoseGetTransformArray:Pose
    static readonly int Pose_Offset;
    public UnrealSharp.ControlRig.RigPose Pose;
    
    // EnumProperty /Script/ControlRig.RigUnit_PoseGetTransformArray:Space
    static readonly int Space_Offset;
    public UnrealSharp.RigVM.ERigVMTransformSpace Space;
    
    // BoolProperty /Script/ControlRig.RigUnit_PoseGetTransformArray:Valid
    static readonly int Valid_Offset;
    public bool Valid;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_PoseGetTransformArray()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_PoseGetTransformArray");
        
        Pose_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Pose");
        Space_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Space");
        Valid_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Valid");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_PoseGetTransformArray(IntPtr InNativeStruct)
    {
        unsafe
        {
            Pose = UnrealSharp.ControlRig.RigPoseMarshaler.FromNative(IntPtr.Add(InNativeStruct, Pose_Offset), 0, null);
            Space = BlittableMarshaller<UnrealSharp.RigVM.ERigVMTransformSpace>.FromNative(IntPtr.Add(InNativeStruct, Space_Offset), 0, null);
            Valid = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, Valid_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.ControlRig.RigPoseMarshaler.ToNative(IntPtr.Add(Buffer, Pose_Offset), 0, null, Pose);
            BlittableMarshaller<UnrealSharp.RigVM.ERigVMTransformSpace>.ToNative(IntPtr.Add(Buffer, Space_Offset), 0, null, Space);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, Valid_Offset), 0, null, Valid);
        }
    }
}

public static class RigUnit_PoseGetTransformArrayMarshaler
{
    public static RigUnit_PoseGetTransformArray FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_PoseGetTransformArray(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_PoseGetTransformArray obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_PoseGetTransformArray.NativeDataSize;
    }
}