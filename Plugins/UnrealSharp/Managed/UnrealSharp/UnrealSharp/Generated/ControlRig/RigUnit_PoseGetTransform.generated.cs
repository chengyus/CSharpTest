using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_PoseGetTransform
{
    // StructProperty /Script/ControlRig.RigUnit_PoseGetTransform:Pose
    static readonly int Pose_Offset;
    public UnrealSharp.ControlRig.RigPose Pose;
    
    // StructProperty /Script/ControlRig.RigUnit_PoseGetTransform:Item
    static readonly int Item_Offset;
    public UnrealSharp.ControlRig.RigElementKey Item;
    
    // EnumProperty /Script/ControlRig.RigUnit_PoseGetTransform:Space
    static readonly int Space_Offset;
    public UnrealSharp.RigVM.ERigVMTransformSpace Space;
    
    // BoolProperty /Script/ControlRig.RigUnit_PoseGetTransform:Valid
    static readonly int Valid_Offset;
    public bool Valid;
    
    // StructProperty /Script/ControlRig.RigUnit_PoseGetTransform:Transform
    static readonly int Transform_Offset;
    public UnrealSharp.Transform Transform;
    
    // FloatProperty /Script/ControlRig.RigUnit_PoseGetTransform:CurveValue
    static readonly int CurveValue_Offset;
    public float CurveValue;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_PoseGetTransform()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_PoseGetTransform");
        
        Pose_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Pose");
        Item_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Item");
        Space_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Space");
        Valid_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Valid");
        Transform_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Transform");
        CurveValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CurveValue");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_PoseGetTransform(IntPtr InNativeStruct)
    {
        unsafe
        {
            Pose = UnrealSharp.ControlRig.RigPoseMarshaler.FromNative(IntPtr.Add(InNativeStruct, Pose_Offset), 0, null);
            Item = UnrealSharp.ControlRig.RigElementKeyMarshaler.FromNative(IntPtr.Add(InNativeStruct, Item_Offset), 0, null);
            Space = BlittableMarshaller<UnrealSharp.RigVM.ERigVMTransformSpace>.FromNative(IntPtr.Add(InNativeStruct, Space_Offset), 0, null);
            Valid = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, Valid_Offset), 0, null);
            Transform = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, Transform_Offset), 0, null);
            CurveValue = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, CurveValue_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.ControlRig.RigPoseMarshaler.ToNative(IntPtr.Add(Buffer, Pose_Offset), 0, null, Pose);
            UnrealSharp.ControlRig.RigElementKeyMarshaler.ToNative(IntPtr.Add(Buffer, Item_Offset), 0, null, Item);
            BlittableMarshaller<UnrealSharp.RigVM.ERigVMTransformSpace>.ToNative(IntPtr.Add(Buffer, Space_Offset), 0, null, Space);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, Valid_Offset), 0, null, Valid);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, Transform_Offset), 0, null, Transform);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, CurveValue_Offset), 0, null, CurveValue);
        }
    }
}

public static class RigUnit_PoseGetTransformMarshaler
{
    public static RigUnit_PoseGetTransform FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_PoseGetTransform(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_PoseGetTransform obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_PoseGetTransform.NativeDataSize;
    }
}