using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_DebugPose
{
    // StructProperty /Script/ControlRig.RigUnit_DebugPose:ExecuteContext
    static readonly int ExecuteContext_Offset;
    public UnrealSharp.ControlRig.ControlRigExecuteContext ExecuteContext;
    
    // StructProperty /Script/ControlRig.RigUnit_DebugPose:Pose
    static readonly int Pose_Offset;
    public UnrealSharp.ControlRig.RigPose Pose;
    
    // FloatProperty /Script/ControlRig.RigUnit_DebugPose:Scale
    static readonly int Scale_Offset;
    public float Scale;
    
    // StructProperty /Script/ControlRig.RigUnit_DebugPose:Color
    static readonly int Color_Offset;
    public UnrealSharp.CoreUObject.LinearColor Color;
    
    // FloatProperty /Script/ControlRig.RigUnit_DebugPose:Thickness
    static readonly int Thickness_Offset;
    public float Thickness;
    
    // StructProperty /Script/ControlRig.RigUnit_DebugPose:WorldOffset
    static readonly int WorldOffset_Offset;
    public UnrealSharp.Transform WorldOffset;
    
    // BoolProperty /Script/ControlRig.RigUnit_DebugPose:bEnabled
    static readonly int bEnabled_Offset;
    public bool Enabled;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_DebugPose()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_DebugPose");
        
        ExecuteContext_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ExecuteContext");
        Pose_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Pose");
        Scale_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Scale");
        Color_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Color");
        Thickness_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Thickness");
        WorldOffset_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "WorldOffset");
        bEnabled_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bEnabled");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_DebugPose(IntPtr InNativeStruct)
    {
        unsafe
        {
            ExecuteContext = UnrealSharp.ControlRig.ControlRigExecuteContextMarshaler.FromNative(IntPtr.Add(InNativeStruct, ExecuteContext_Offset), 0, null);
            Pose = UnrealSharp.ControlRig.RigPoseMarshaler.FromNative(IntPtr.Add(InNativeStruct, Pose_Offset), 0, null);
            Scale = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Scale_Offset), 0, null);
            Color = BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.FromNative(IntPtr.Add(InNativeStruct, Color_Offset), 0, null);
            Thickness = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Thickness_Offset), 0, null);
            WorldOffset = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, WorldOffset_Offset), 0, null);
            Enabled = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bEnabled_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.ControlRig.ControlRigExecuteContextMarshaler.ToNative(IntPtr.Add(Buffer, ExecuteContext_Offset), 0, null, ExecuteContext);
            UnrealSharp.ControlRig.RigPoseMarshaler.ToNative(IntPtr.Add(Buffer, Pose_Offset), 0, null, Pose);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Scale_Offset), 0, null, Scale);
            BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.ToNative(IntPtr.Add(Buffer, Color_Offset), 0, null, Color);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Thickness_Offset), 0, null, Thickness);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, WorldOffset_Offset), 0, null, WorldOffset);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bEnabled_Offset), 0, null, Enabled);
        }
    }
}

public static class RigUnit_DebugPoseMarshaler
{
    public static RigUnit_DebugPose FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_DebugPose(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_DebugPose obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_DebugPose.NativeDataSize;
    }
}