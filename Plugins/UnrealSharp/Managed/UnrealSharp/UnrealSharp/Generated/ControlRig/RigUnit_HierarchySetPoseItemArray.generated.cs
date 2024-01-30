using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_HierarchySetPoseItemArray
{
    // StructProperty /Script/ControlRig.RigUnit_HierarchySetPoseItemArray:Pose
    static readonly int Pose_Offset;
    public UnrealSharp.ControlRig.RigPose Pose;
    
    // EnumProperty /Script/ControlRig.RigUnit_HierarchySetPoseItemArray:ElementType
    static readonly int ElementType_Offset;
    public UnrealSharp.ControlRig.ERigElementType ElementType;
    
    // EnumProperty /Script/ControlRig.RigUnit_HierarchySetPoseItemArray:Space
    static readonly int Space_Offset;
    public UnrealSharp.RigVM.ERigVMTransformSpace Space;
    
    // FloatProperty /Script/ControlRig.RigUnit_HierarchySetPoseItemArray:Weight
    static readonly int Weight_Offset;
    public float Weight;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_HierarchySetPoseItemArray()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_HierarchySetPoseItemArray");
        
        Pose_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Pose");
        ElementType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ElementType");
        Space_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Space");
        Weight_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Weight");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_HierarchySetPoseItemArray(IntPtr InNativeStruct)
    {
        unsafe
        {
            Pose = UnrealSharp.ControlRig.RigPoseMarshaler.FromNative(IntPtr.Add(InNativeStruct, Pose_Offset), 0, null);
            ElementType = BlittableMarshaller<UnrealSharp.ControlRig.ERigElementType>.FromNative(IntPtr.Add(InNativeStruct, ElementType_Offset), 0, null);
            Space = BlittableMarshaller<UnrealSharp.RigVM.ERigVMTransformSpace>.FromNative(IntPtr.Add(InNativeStruct, Space_Offset), 0, null);
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
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Weight_Offset), 0, null, Weight);
        }
    }
}

public static class RigUnit_HierarchySetPoseItemArrayMarshaler
{
    public static RigUnit_HierarchySetPoseItemArray FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_HierarchySetPoseItemArray(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_HierarchySetPoseItemArray obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_HierarchySetPoseItemArray.NativeDataSize;
    }
}