using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_TwoBoneIKSimple
{
    // NameProperty /Script/ControlRig.RigUnit_TwoBoneIKSimple:BoneA
    static readonly int BoneA_Offset;
    public Name BoneA;
    
    // NameProperty /Script/ControlRig.RigUnit_TwoBoneIKSimple:BoneB
    static readonly int BoneB_Offset;
    public Name BoneB;
    
    // NameProperty /Script/ControlRig.RigUnit_TwoBoneIKSimple:EffectorBone
    static readonly int EffectorBone_Offset;
    public Name EffectorBone;
    
    // StructProperty /Script/ControlRig.RigUnit_TwoBoneIKSimple:Effector
    static readonly int Effector_Offset;
    public UnrealSharp.Transform Effector;
    
    // StructProperty /Script/ControlRig.RigUnit_TwoBoneIKSimple:PrimaryAxis
    static readonly int PrimaryAxis_Offset;
    public System.DoubleNumerics.Vector3 PrimaryAxis;
    
    // StructProperty /Script/ControlRig.RigUnit_TwoBoneIKSimple:SecondaryAxis
    static readonly int SecondaryAxis_Offset;
    public System.DoubleNumerics.Vector3 SecondaryAxis;
    
    // FloatProperty /Script/ControlRig.RigUnit_TwoBoneIKSimple:SecondaryAxisWeight
    static readonly int SecondaryAxisWeight_Offset;
    public float SecondaryAxisWeight;
    
    // StructProperty /Script/ControlRig.RigUnit_TwoBoneIKSimple:PoleVector
    static readonly int PoleVector_Offset;
    public System.DoubleNumerics.Vector3 PoleVector;
    
    // EnumProperty /Script/ControlRig.RigUnit_TwoBoneIKSimple:PoleVectorKind
    static readonly int PoleVectorKind_Offset;
    public UnrealSharp.ControlRig.EControlRigVectorKind PoleVectorKind;
    
    // NameProperty /Script/ControlRig.RigUnit_TwoBoneIKSimple:PoleVectorSpace
    static readonly int PoleVectorSpace_Offset;
    public Name PoleVectorSpace;
    
    // BoolProperty /Script/ControlRig.RigUnit_TwoBoneIKSimple:bEnableStretch
    static readonly int bEnableStretch_Offset;
    public bool EnableStretch;
    
    // FloatProperty /Script/ControlRig.RigUnit_TwoBoneIKSimple:StretchStartRatio
    static readonly int StretchStartRatio_Offset;
    public float StretchStartRatio;
    
    // FloatProperty /Script/ControlRig.RigUnit_TwoBoneIKSimple:StretchMaximumRatio
    static readonly int StretchMaximumRatio_Offset;
    public float StretchMaximumRatio;
    
    // FloatProperty /Script/ControlRig.RigUnit_TwoBoneIKSimple:Weight
    static readonly int Weight_Offset;
    public float Weight;
    
    // FloatProperty /Script/ControlRig.RigUnit_TwoBoneIKSimple:BoneALength
    static readonly int BoneALength_Offset;
    public float BoneALength;
    
    // FloatProperty /Script/ControlRig.RigUnit_TwoBoneIKSimple:BoneBLength
    static readonly int BoneBLength_Offset;
    public float BoneBLength;
    
    // BoolProperty /Script/ControlRig.RigUnit_TwoBoneIKSimple:bPropagateToChildren
    static readonly int bPropagateToChildren_Offset;
    public bool PropagateToChildren;
    
    // StructProperty /Script/ControlRig.RigUnit_TwoBoneIKSimple:DebugSettings
    static readonly int DebugSettings_Offset;
    public UnrealSharp.ControlRig.RigUnit_TwoBoneIKSimple_DebugSettings DebugSettings;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_TwoBoneIKSimple()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_TwoBoneIKSimple");
        
        BoneA_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BoneA");
        BoneB_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BoneB");
        EffectorBone_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "EffectorBone");
        Effector_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Effector");
        PrimaryAxis_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PrimaryAxis");
        SecondaryAxis_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SecondaryAxis");
        SecondaryAxisWeight_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SecondaryAxisWeight");
        PoleVector_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PoleVector");
        PoleVectorKind_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PoleVectorKind");
        PoleVectorSpace_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PoleVectorSpace");
        bEnableStretch_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bEnableStretch");
        StretchStartRatio_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "StretchStartRatio");
        StretchMaximumRatio_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "StretchMaximumRatio");
        Weight_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Weight");
        BoneALength_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BoneALength");
        BoneBLength_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BoneBLength");
        bPropagateToChildren_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bPropagateToChildren");
        DebugSettings_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DebugSettings");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_TwoBoneIKSimple(IntPtr InNativeStruct)
    {
        unsafe
        {
            BoneA = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, BoneA_Offset), 0, null);
            BoneB = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, BoneB_Offset), 0, null);
            EffectorBone = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, EffectorBone_Offset), 0, null);
            Effector = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, Effector_Offset), 0, null);
            PrimaryAxis = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, PrimaryAxis_Offset), 0, null);
            SecondaryAxis = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, SecondaryAxis_Offset), 0, null);
            SecondaryAxisWeight = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, SecondaryAxisWeight_Offset), 0, null);
            PoleVector = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, PoleVector_Offset), 0, null);
            PoleVectorKind = BlittableMarshaller<UnrealSharp.ControlRig.EControlRigVectorKind>.FromNative(IntPtr.Add(InNativeStruct, PoleVectorKind_Offset), 0, null);
            PoleVectorSpace = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, PoleVectorSpace_Offset), 0, null);
            EnableStretch = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bEnableStretch_Offset), 0, null);
            StretchStartRatio = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, StretchStartRatio_Offset), 0, null);
            StretchMaximumRatio = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, StretchMaximumRatio_Offset), 0, null);
            Weight = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Weight_Offset), 0, null);
            BoneALength = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, BoneALength_Offset), 0, null);
            BoneBLength = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, BoneBLength_Offset), 0, null);
            PropagateToChildren = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bPropagateToChildren_Offset), 0, null);
            DebugSettings = UnrealSharp.ControlRig.RigUnit_TwoBoneIKSimple_DebugSettingsMarshaler.FromNative(IntPtr.Add(InNativeStruct, DebugSettings_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, BoneA_Offset), 0, null, BoneA);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, BoneB_Offset), 0, null, BoneB);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, EffectorBone_Offset), 0, null, EffectorBone);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, Effector_Offset), 0, null, Effector);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, PrimaryAxis_Offset), 0, null, PrimaryAxis);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, SecondaryAxis_Offset), 0, null, SecondaryAxis);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, SecondaryAxisWeight_Offset), 0, null, SecondaryAxisWeight);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, PoleVector_Offset), 0, null, PoleVector);
            BlittableMarshaller<UnrealSharp.ControlRig.EControlRigVectorKind>.ToNative(IntPtr.Add(Buffer, PoleVectorKind_Offset), 0, null, PoleVectorKind);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, PoleVectorSpace_Offset), 0, null, PoleVectorSpace);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bEnableStretch_Offset), 0, null, EnableStretch);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, StretchStartRatio_Offset), 0, null, StretchStartRatio);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, StretchMaximumRatio_Offset), 0, null, StretchMaximumRatio);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Weight_Offset), 0, null, Weight);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, BoneALength_Offset), 0, null, BoneALength);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, BoneBLength_Offset), 0, null, BoneBLength);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bPropagateToChildren_Offset), 0, null, PropagateToChildren);
            UnrealSharp.ControlRig.RigUnit_TwoBoneIKSimple_DebugSettingsMarshaler.ToNative(IntPtr.Add(Buffer, DebugSettings_Offset), 0, null, DebugSettings);
        }
    }
}

public static class RigUnit_TwoBoneIKSimpleMarshaler
{
    public static RigUnit_TwoBoneIKSimple FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_TwoBoneIKSimple(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_TwoBoneIKSimple obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_TwoBoneIKSimple.NativeDataSize;
    }
}