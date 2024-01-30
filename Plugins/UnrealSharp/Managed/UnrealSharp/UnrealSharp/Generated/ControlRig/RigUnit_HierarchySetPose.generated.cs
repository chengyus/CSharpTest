using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_HierarchySetPose
{
    // StructProperty /Script/ControlRig.RigUnit_HierarchySetPose:Pose
    static readonly int Pose_Offset;
    public UnrealSharp.ControlRig.RigPose Pose;
    
    // EnumProperty /Script/ControlRig.RigUnit_HierarchySetPose:ElementType
    static readonly int ElementType_Offset;
    public UnrealSharp.ControlRig.ERigElementType ElementType;
    
    // EnumProperty /Script/ControlRig.RigUnit_HierarchySetPose:Space
    static readonly int Space_Offset;
    public UnrealSharp.RigVM.ERigVMTransformSpace Space;
    
    // StructProperty /Script/ControlRig.RigUnit_HierarchySetPose:ItemsToSet
    static readonly int ItemsToSet_Offset;
    public UnrealSharp.ControlRig.RigElementKeyCollection ItemsToSet;
    
    // FloatProperty /Script/ControlRig.RigUnit_HierarchySetPose:Weight
    static readonly int Weight_Offset;
    public float Weight;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_HierarchySetPose()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_HierarchySetPose");
        
        Pose_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Pose");
        ElementType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ElementType");
        Space_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Space");
        ItemsToSet_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ItemsToSet");
        Weight_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Weight");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_HierarchySetPose(IntPtr InNativeStruct)
    {
        unsafe
        {
            Pose = UnrealSharp.ControlRig.RigPoseMarshaler.FromNative(IntPtr.Add(InNativeStruct, Pose_Offset), 0, null);
            ElementType = BlittableMarshaller<UnrealSharp.ControlRig.ERigElementType>.FromNative(IntPtr.Add(InNativeStruct, ElementType_Offset), 0, null);
            Space = BlittableMarshaller<UnrealSharp.RigVM.ERigVMTransformSpace>.FromNative(IntPtr.Add(InNativeStruct, Space_Offset), 0, null);
            ItemsToSet = UnrealSharp.ControlRig.RigElementKeyCollectionMarshaler.FromNative(IntPtr.Add(InNativeStruct, ItemsToSet_Offset), 0, null);
            Weight = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Weight_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.ControlRig.RigPoseMarshaler.ToNative(IntPtr.Add(Buffer, Pose_Offset), 0, null, Pose);
            BlittableMarshaller<UnrealSharp.ControlRig.ERigElementType>.ToNative(IntPtr.Add(Buffer, ElementType_Offset), 0, null, ElementType);
            BlittableMarshaller<UnrealSharp.RigVM.ERigVMTransformSpace>.ToNative(IntPtr.Add(Buffer, Space_Offset), 0, null, Space);
            UnrealSharp.ControlRig.RigElementKeyCollectionMarshaler.ToNative(IntPtr.Add(Buffer, ItemsToSet_Offset), 0, null, ItemsToSet);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Weight_Offset), 0, null, Weight);
        }
    }
}

public static class RigUnit_HierarchySetPoseMarshaler
{
    public static RigUnit_HierarchySetPose FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_HierarchySetPose(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_HierarchySetPose obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_HierarchySetPose.NativeDataSize;
    }
}