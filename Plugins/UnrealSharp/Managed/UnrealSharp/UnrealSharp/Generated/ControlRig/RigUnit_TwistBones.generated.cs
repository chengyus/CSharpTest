using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_TwistBones
{
    // NameProperty /Script/ControlRig.RigUnit_TwistBones:StartBone
    static readonly int StartBone_Offset;
    public Name StartBone;
    
    // NameProperty /Script/ControlRig.RigUnit_TwistBones:EndBone
    static readonly int EndBone_Offset;
    public Name EndBone;
    
    // StructProperty /Script/ControlRig.RigUnit_TwistBones:TwistAxis
    static readonly int TwistAxis_Offset;
    public System.DoubleNumerics.Vector3 TwistAxis;
    
    // StructProperty /Script/ControlRig.RigUnit_TwistBones:PoleAxis
    static readonly int PoleAxis_Offset;
    public System.DoubleNumerics.Vector3 PoleAxis;
    
    // EnumProperty /Script/ControlRig.RigUnit_TwistBones:TwistEaseType
    static readonly int TwistEaseType_Offset;
    public UnrealSharp.RigVM.ERigVMAnimEasingType TwistEaseType;
    
    // FloatProperty /Script/ControlRig.RigUnit_TwistBones:Weight
    static readonly int Weight_Offset;
    public float Weight;
    
    // BoolProperty /Script/ControlRig.RigUnit_TwistBones:bPropagateToChildren
    static readonly int bPropagateToChildren_Offset;
    public bool PropagateToChildren;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_TwistBones()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_TwistBones");
        
        StartBone_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "StartBone");
        EndBone_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "EndBone");
        TwistAxis_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TwistAxis");
        PoleAxis_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PoleAxis");
        TwistEaseType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TwistEaseType");
        Weight_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Weight");
        bPropagateToChildren_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bPropagateToChildren");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_TwistBones(IntPtr InNativeStruct)
    {
        unsafe
        {
            StartBone = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, StartBone_Offset), 0, null);
            EndBone = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, EndBone_Offset), 0, null);
            TwistAxis = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, TwistAxis_Offset), 0, null);
            PoleAxis = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, PoleAxis_Offset), 0, null);
            TwistEaseType = BlittableMarshaller<UnrealSharp.RigVM.ERigVMAnimEasingType>.FromNative(IntPtr.Add(InNativeStruct, TwistEaseType_Offset), 0, null);
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
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, TwistAxis_Offset), 0, null, TwistAxis);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, PoleAxis_Offset), 0, null, PoleAxis);
            BlittableMarshaller<UnrealSharp.RigVM.ERigVMAnimEasingType>.ToNative(IntPtr.Add(Buffer, TwistEaseType_Offset), 0, null, TwistEaseType);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Weight_Offset), 0, null, Weight);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bPropagateToChildren_Offset), 0, null, PropagateToChildren);
        }
    }
}

public static class RigUnit_TwistBonesMarshaler
{
    public static RigUnit_TwistBones FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_TwistBones(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_TwistBones obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_TwistBones.NativeDataSize;
    }
}