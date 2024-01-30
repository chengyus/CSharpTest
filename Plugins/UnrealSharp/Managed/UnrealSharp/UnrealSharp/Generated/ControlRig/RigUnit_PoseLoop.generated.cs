using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_PoseLoop
{
    // StructProperty /Script/ControlRig.RigUnit_PoseLoop:Pose
    static readonly int Pose_Offset;
    public UnrealSharp.ControlRig.RigPose Pose;
    
    // StructProperty /Script/ControlRig.RigUnit_PoseLoop:Item
    static readonly int Item_Offset;
    public UnrealSharp.ControlRig.RigElementKey Item;
    
    // StructProperty /Script/ControlRig.RigUnit_PoseLoop:GlobalTransform
    static readonly int GlobalTransform_Offset;
    public UnrealSharp.Transform GlobalTransform;
    
    // StructProperty /Script/ControlRig.RigUnit_PoseLoop:LocalTransform
    static readonly int LocalTransform_Offset;
    public UnrealSharp.Transform LocalTransform;
    
    // FloatProperty /Script/ControlRig.RigUnit_PoseLoop:CurveValue
    static readonly int CurveValue_Offset;
    public float CurveValue;
    
    // IntProperty /Script/ControlRig.RigUnit_PoseLoop:Index
    static readonly int Index_Offset;
    public int Index;
    
    // IntProperty /Script/ControlRig.RigUnit_PoseLoop:Count
    static readonly int Count_Offset;
    public int Count;
    
    // FloatProperty /Script/ControlRig.RigUnit_PoseLoop:Ratio
    static readonly int Ratio_Offset;
    public float Ratio;
    
    // StructProperty /Script/ControlRig.RigUnit_PoseLoop:Completed
    static readonly int Completed_Offset;
    public UnrealSharp.ControlRig.ControlRigExecuteContext Completed;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_PoseLoop()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_PoseLoop");
        
        Pose_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Pose");
        Item_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Item");
        GlobalTransform_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "GlobalTransform");
        LocalTransform_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LocalTransform");
        CurveValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CurveValue");
        Index_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Index");
        Count_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Count");
        Ratio_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Ratio");
        Completed_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Completed");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_PoseLoop(IntPtr InNativeStruct)
    {
        unsafe
        {
            Pose = UnrealSharp.ControlRig.RigPoseMarshaler.FromNative(IntPtr.Add(InNativeStruct, Pose_Offset), 0, null);
            Item = UnrealSharp.ControlRig.RigElementKeyMarshaler.FromNative(IntPtr.Add(InNativeStruct, Item_Offset), 0, null);
            GlobalTransform = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, GlobalTransform_Offset), 0, null);
            LocalTransform = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, LocalTransform_Offset), 0, null);
            CurveValue = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, CurveValue_Offset), 0, null);
            Index = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, Index_Offset), 0, null);
            Count = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, Count_Offset), 0, null);
            Ratio = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Ratio_Offset), 0, null);
            Completed = UnrealSharp.ControlRig.ControlRigExecuteContextMarshaler.FromNative(IntPtr.Add(InNativeStruct, Completed_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.ControlRig.RigPoseMarshaler.ToNative(IntPtr.Add(Buffer, Pose_Offset), 0, null, Pose);
            UnrealSharp.ControlRig.RigElementKeyMarshaler.ToNative(IntPtr.Add(Buffer, Item_Offset), 0, null, Item);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, GlobalTransform_Offset), 0, null, GlobalTransform);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, LocalTransform_Offset), 0, null, LocalTransform);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, CurveValue_Offset), 0, null, CurveValue);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, Index_Offset), 0, null, Index);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, Count_Offset), 0, null, Count);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Ratio_Offset), 0, null, Ratio);
            UnrealSharp.ControlRig.ControlRigExecuteContextMarshaler.ToNative(IntPtr.Add(Buffer, Completed_Offset), 0, null, Completed);
        }
    }
}

public static class RigUnit_PoseLoopMarshaler
{
    public static RigUnit_PoseLoop FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_PoseLoop(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_PoseLoop obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_PoseLoop.NativeDataSize;
    }
}