using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_PoseGetDelta
{
    // StructProperty /Script/ControlRig.RigUnit_PoseGetDelta:PoseA
    static readonly int PoseA_Offset;
    public UnrealSharp.ControlRig.RigPose PoseA;
    
    // StructProperty /Script/ControlRig.RigUnit_PoseGetDelta:PoseB
    static readonly int PoseB_Offset;
    public UnrealSharp.ControlRig.RigPose PoseB;
    
    // FloatProperty /Script/ControlRig.RigUnit_PoseGetDelta:PositionThreshold
    static readonly int PositionThreshold_Offset;
    public float PositionThreshold;
    
    // FloatProperty /Script/ControlRig.RigUnit_PoseGetDelta:RotationThreshold
    static readonly int RotationThreshold_Offset;
    public float RotationThreshold;
    
    // FloatProperty /Script/ControlRig.RigUnit_PoseGetDelta:ScaleThreshold
    static readonly int ScaleThreshold_Offset;
    public float ScaleThreshold;
    
    // FloatProperty /Script/ControlRig.RigUnit_PoseGetDelta:CurveThreshold
    static readonly int CurveThreshold_Offset;
    public float CurveThreshold;
    
    // EnumProperty /Script/ControlRig.RigUnit_PoseGetDelta:ElementType
    static readonly int ElementType_Offset;
    public UnrealSharp.ControlRig.ERigElementType ElementType;
    
    // EnumProperty /Script/ControlRig.RigUnit_PoseGetDelta:Space
    static readonly int Space_Offset;
    public UnrealSharp.RigVM.ERigVMTransformSpace Space;
    
    // StructProperty /Script/ControlRig.RigUnit_PoseGetDelta:ItemsToCompare
    static readonly int ItemsToCompare_Offset;
    public UnrealSharp.ControlRig.RigElementKeyCollection ItemsToCompare;
    
    // BoolProperty /Script/ControlRig.RigUnit_PoseGetDelta:PosesAreEqual
    static readonly int PosesAreEqual_Offset;
    public bool PosesAreEqual;
    
    // StructProperty /Script/ControlRig.RigUnit_PoseGetDelta:ItemsWithDelta
    static readonly int ItemsWithDelta_Offset;
    public UnrealSharp.ControlRig.RigElementKeyCollection ItemsWithDelta;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_PoseGetDelta()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_PoseGetDelta");
        
        PoseA_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PoseA");
        PoseB_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PoseB");
        PositionThreshold_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PositionThreshold");
        RotationThreshold_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RotationThreshold");
        ScaleThreshold_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ScaleThreshold");
        CurveThreshold_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CurveThreshold");
        ElementType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ElementType");
        Space_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Space");
        ItemsToCompare_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ItemsToCompare");
        PosesAreEqual_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PosesAreEqual");
        ItemsWithDelta_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ItemsWithDelta");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_PoseGetDelta(IntPtr InNativeStruct)
    {
        unsafe
        {
            PoseA = UnrealSharp.ControlRig.RigPoseMarshaler.FromNative(IntPtr.Add(InNativeStruct, PoseA_Offset), 0, null);
            PoseB = UnrealSharp.ControlRig.RigPoseMarshaler.FromNative(IntPtr.Add(InNativeStruct, PoseB_Offset), 0, null);
            PositionThreshold = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, PositionThreshold_Offset), 0, null);
            RotationThreshold = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, RotationThreshold_Offset), 0, null);
            ScaleThreshold = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ScaleThreshold_Offset), 0, null);
            CurveThreshold = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, CurveThreshold_Offset), 0, null);
            ElementType = BlittableMarshaller<UnrealSharp.ControlRig.ERigElementType>.FromNative(IntPtr.Add(InNativeStruct, ElementType_Offset), 0, null);
            Space = BlittableMarshaller<UnrealSharp.RigVM.ERigVMTransformSpace>.FromNative(IntPtr.Add(InNativeStruct, Space_Offset), 0, null);
            ItemsToCompare = UnrealSharp.ControlRig.RigElementKeyCollectionMarshaler.FromNative(IntPtr.Add(InNativeStruct, ItemsToCompare_Offset), 0, null);
            PosesAreEqual = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, PosesAreEqual_Offset), 0, null);
            ItemsWithDelta = UnrealSharp.ControlRig.RigElementKeyCollectionMarshaler.FromNative(IntPtr.Add(InNativeStruct, ItemsWithDelta_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.ControlRig.RigPoseMarshaler.ToNative(IntPtr.Add(Buffer, PoseA_Offset), 0, null, PoseA);
            UnrealSharp.ControlRig.RigPoseMarshaler.ToNative(IntPtr.Add(Buffer, PoseB_Offset), 0, null, PoseB);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, PositionThreshold_Offset), 0, null, PositionThreshold);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, RotationThreshold_Offset), 0, null, RotationThreshold);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ScaleThreshold_Offset), 0, null, ScaleThreshold);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, CurveThreshold_Offset), 0, null, CurveThreshold);
            BlittableMarshaller<UnrealSharp.ControlRig.ERigElementType>.ToNative(IntPtr.Add(Buffer, ElementType_Offset), 0, null, ElementType);
            BlittableMarshaller<UnrealSharp.RigVM.ERigVMTransformSpace>.ToNative(IntPtr.Add(Buffer, Space_Offset), 0, null, Space);
            UnrealSharp.ControlRig.RigElementKeyCollectionMarshaler.ToNative(IntPtr.Add(Buffer, ItemsToCompare_Offset), 0, null, ItemsToCompare);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, PosesAreEqual_Offset), 0, null, PosesAreEqual);
            UnrealSharp.ControlRig.RigElementKeyCollectionMarshaler.ToNative(IntPtr.Add(Buffer, ItemsWithDelta_Offset), 0, null, ItemsWithDelta);
        }
    }
}

public static class RigUnit_PoseGetDeltaMarshaler
{
    public static RigUnit_PoseGetDelta FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_PoseGetDelta(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_PoseGetDelta obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_PoseGetDelta.NativeDataSize;
    }
}