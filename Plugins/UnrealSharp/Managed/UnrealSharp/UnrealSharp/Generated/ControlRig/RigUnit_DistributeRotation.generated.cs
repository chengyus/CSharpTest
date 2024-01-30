using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_DistributeRotation
{
    // NameProperty /Script/ControlRig.RigUnit_DistributeRotation:StartBone
    static readonly int StartBone_Offset;
    public Name StartBone;
    
    // NameProperty /Script/ControlRig.RigUnit_DistributeRotation:EndBone
    static readonly int EndBone_Offset;
    public Name EndBone;
    
    // EnumProperty /Script/ControlRig.RigUnit_DistributeRotation:RotationEaseType
    static readonly int RotationEaseType_Offset;
    public UnrealSharp.RigVM.ERigVMAnimEasingType RotationEaseType;
    
    // FloatProperty /Script/ControlRig.RigUnit_DistributeRotation:Weight
    static readonly int Weight_Offset;
    public float Weight;
    
    // BoolProperty /Script/ControlRig.RigUnit_DistributeRotation:bPropagateToChildren
    static readonly int bPropagateToChildren_Offset;
    public bool PropagateToChildren;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_DistributeRotation()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_DistributeRotation");
        
        StartBone_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "StartBone");
        EndBone_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "EndBone");
        RotationEaseType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RotationEaseType");
        Weight_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Weight");
        bPropagateToChildren_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bPropagateToChildren");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_DistributeRotation(IntPtr InNativeStruct)
    {
        unsafe
        {
            StartBone = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, StartBone_Offset), 0, null);
            EndBone = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, EndBone_Offset), 0, null);
            RotationEaseType = BlittableMarshaller<UnrealSharp.RigVM.ERigVMAnimEasingType>.FromNative(IntPtr.Add(InNativeStruct, RotationEaseType_Offset), 0, null);
            Weight = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Weight_Offset), 0, null);
            PropagateToChildren = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bPropagateToChildren_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, StartBone_Offset), 0, null, StartBone);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, EndBone_Offset), 0, null, EndBone);
            BlittableMarshaller<UnrealSharp.RigVM.ERigVMAnimEasingType>.ToNative(IntPtr.Add(Buffer, RotationEaseType_Offset), 0, null, RotationEaseType);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Weight_Offset), 0, null, Weight);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bPropagateToChildren_Offset), 0, null, PropagateToChildren);
        }
    }
}

public static class RigUnit_DistributeRotationMarshaler
{
    public static RigUnit_DistributeRotation FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_DistributeRotation(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_DistributeRotation obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_DistributeRotation.NativeDataSize;
    }
}