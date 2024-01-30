using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_HierarchyGetPose
{
    // BoolProperty /Script/ControlRig.RigUnit_HierarchyGetPose:Initial
    static readonly int Initial_Offset;
    public bool Initial;
    
    // EnumProperty /Script/ControlRig.RigUnit_HierarchyGetPose:ElementType
    static readonly int ElementType_Offset;
    public UnrealSharp.ControlRig.ERigElementType ElementType;
    
    // StructProperty /Script/ControlRig.RigUnit_HierarchyGetPose:ItemsToGet
    static readonly int ItemsToGet_Offset;
    public UnrealSharp.ControlRig.RigElementKeyCollection ItemsToGet;
    
    // StructProperty /Script/ControlRig.RigUnit_HierarchyGetPose:Pose
    static readonly int Pose_Offset;
    public UnrealSharp.ControlRig.RigPose Pose;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_HierarchyGetPose()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_HierarchyGetPose");
        
        Initial_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Initial");
        ElementType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ElementType");
        ItemsToGet_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ItemsToGet");
        Pose_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Pose");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_HierarchyGetPose(IntPtr InNativeStruct)
    {
        unsafe
        {
            Initial = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, Initial_Offset), 0, null);
            ElementType = BlittableMarshaller<UnrealSharp.ControlRig.ERigElementType>.FromNative(IntPtr.Add(InNativeStruct, ElementType_Offset), 0, null);
            ItemsToGet = UnrealSharp.ControlRig.RigElementKeyCollectionMarshaler.FromNative(IntPtr.Add(InNativeStruct, ItemsToGet_Offset), 0, null);
            Pose = UnrealSharp.ControlRig.RigPoseMarshaler.FromNative(IntPtr.Add(InNativeStruct, Pose_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, Initial_Offset), 0, null, Initial);
            BlittableMarshaller<UnrealSharp.ControlRig.ERigElementType>.ToNative(IntPtr.Add(Buffer, ElementType_Offset), 0, null, ElementType);
            UnrealSharp.ControlRig.RigElementKeyCollectionMarshaler.ToNative(IntPtr.Add(Buffer, ItemsToGet_Offset), 0, null, ItemsToGet);
            UnrealSharp.ControlRig.RigPoseMarshaler.ToNative(IntPtr.Add(Buffer, Pose_Offset), 0, null, Pose);
        }
    }
}

public static class RigUnit_HierarchyGetPoseMarshaler
{
    public static RigUnit_HierarchyGetPose FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_HierarchyGetPose(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_HierarchyGetPose obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_HierarchyGetPose.NativeDataSize;
    }
}