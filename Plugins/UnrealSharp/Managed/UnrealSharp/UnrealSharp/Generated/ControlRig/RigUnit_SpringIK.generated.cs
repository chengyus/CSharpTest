using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_SpringIK
{
    // NameProperty /Script/ControlRig.RigUnit_SpringIK:StartBone
    static readonly int StartBone_Offset;
    public Name StartBone;
    
    // NameProperty /Script/ControlRig.RigUnit_SpringIK:EndBone
    static readonly int EndBone_Offset;
    public Name EndBone;
    
    // FloatProperty /Script/ControlRig.RigUnit_SpringIK:HierarchyStrength
    static readonly int HierarchyStrength_Offset;
    public float HierarchyStrength;
    
    // FloatProperty /Script/ControlRig.RigUnit_SpringIK:EffectorStrength
    static readonly int EffectorStrength_Offset;
    public float EffectorStrength;
    
    // FloatProperty /Script/ControlRig.RigUnit_SpringIK:EffectorRatio
    static readonly int EffectorRatio_Offset;
    public float EffectorRatio;
    
    // FloatProperty /Script/ControlRig.RigUnit_SpringIK:RootStrength
    static readonly int RootStrength_Offset;
    public float RootStrength;
    
    // FloatProperty /Script/ControlRig.RigUnit_SpringIK:RootRatio
    static readonly int RootRatio_Offset;
    public float RootRatio;
    
    // FloatProperty /Script/ControlRig.RigUnit_SpringIK:Damping
    static readonly int Damping_Offset;
    public float Damping;
    
    // StructProperty /Script/ControlRig.RigUnit_SpringIK:PoleVector
    static readonly int PoleVector_Offset;
    public System.DoubleNumerics.Vector3 PoleVector;
    
    // BoolProperty /Script/ControlRig.RigUnit_SpringIK:bFlipPolePlane
    static readonly int bFlipPolePlane_Offset;
    public bool FlipPolePlane;
    
    // EnumProperty /Script/ControlRig.RigUnit_SpringIK:PoleVectorKind
    static readonly int PoleVectorKind_Offset;
    public UnrealSharp.ControlRig.EControlRigVectorKind PoleVectorKind;
    
    // NameProperty /Script/ControlRig.RigUnit_SpringIK:PoleVectorSpace
    static readonly int PoleVectorSpace_Offset;
    public Name PoleVectorSpace;
    
    // StructProperty /Script/ControlRig.RigUnit_SpringIK:PrimaryAxis
    static readonly int PrimaryAxis_Offset;
    public System.DoubleNumerics.Vector3 PrimaryAxis;
    
    // StructProperty /Script/ControlRig.RigUnit_SpringIK:SecondaryAxis
    static readonly int SecondaryAxis_Offset;
    public System.DoubleNumerics.Vector3 SecondaryAxis;
    
    // BoolProperty /Script/ControlRig.RigUnit_SpringIK:bLiveSimulation
    static readonly int bLiveSimulation_Offset;
    public bool LiveSimulation;
    
    // IntProperty /Script/ControlRig.RigUnit_SpringIK:Iterations
    static readonly int Iterations_Offset;
    public int Iterations;
    
    // BoolProperty /Script/ControlRig.RigUnit_SpringIK:bLimitLocalPosition
    static readonly int bLimitLocalPosition_Offset;
    public bool LimitLocalPosition;
    
    // BoolProperty /Script/ControlRig.RigUnit_SpringIK:bPropagateToChildren
    static readonly int bPropagateToChildren_Offset;
    public bool PropagateToChildren;
    
    // StructProperty /Script/ControlRig.RigUnit_SpringIK:DebugSettings
    static readonly int DebugSettings_Offset;
    public UnrealSharp.ControlRig.RigUnit_SpringIK_DebugSettings DebugSettings;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_SpringIK()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_SpringIK");
        
        StartBone_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "StartBone");
        EndBone_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "EndBone");
        HierarchyStrength_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "HierarchyStrength");
        EffectorStrength_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "EffectorStrength");
        EffectorRatio_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "EffectorRatio");
        RootStrength_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RootStrength");
        RootRatio_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RootRatio");
        Damping_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Damping");
        PoleVector_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PoleVector");
        bFlipPolePlane_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bFlipPolePlane");
        PoleVectorKind_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PoleVectorKind");
        PoleVectorSpace_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PoleVectorSpace");
        PrimaryAxis_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PrimaryAxis");
        SecondaryAxis_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SecondaryAxis");
        bLiveSimulation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bLiveSimulation");
        Iterations_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Iterations");
        bLimitLocalPosition_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bLimitLocalPosition");
        bPropagateToChildren_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bPropagateToChildren");
        DebugSettings_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DebugSettings");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_SpringIK(IntPtr InNativeStruct)
    {
        unsafe
        {
            StartBone = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, StartBone_Offset), 0, null);
            EndBone = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, EndBone_Offset), 0, null);
            HierarchyStrength = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, HierarchyStrength_Offset), 0, null);
            EffectorStrength = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, EffectorStrength_Offset), 0, null);
            EffectorRatio = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, EffectorRatio_Offset), 0, null);
            RootStrength = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, RootStrength_Offset), 0, null);
            RootRatio = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, RootRatio_Offset), 0, null);
            Damping = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Damping_Offset), 0, null);
            PoleVector = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, PoleVector_Offset), 0, null);
            FlipPolePlane = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bFlipPolePlane_Offset), 0, null);
            PoleVectorKind = BlittableMarshaller<UnrealSharp.ControlRig.EControlRigVectorKind>.FromNative(IntPtr.Add(InNativeStruct, PoleVectorKind_Offset), 0, null);
            PoleVectorSpace = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, PoleVectorSpace_Offset), 0, null);
            PrimaryAxis = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, PrimaryAxis_Offset), 0, null);
            SecondaryAxis = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, SecondaryAxis_Offset), 0, null);
            LiveSimulation = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bLiveSimulation_Offset), 0, null);
            Iterations = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, Iterations_Offset), 0, null);
            LimitLocalPosition = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bLimitLocalPosition_Offset), 0, null);
            PropagateToChildren = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bPropagateToChildren_Offset), 0, null);
            DebugSettings = UnrealSharp.ControlRig.RigUnit_SpringIK_DebugSettingsMarshaler.FromNative(IntPtr.Add(InNativeStruct, DebugSettings_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, StartBone_Offset), 0, null, StartBone);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, EndBone_Offset), 0, null, EndBone);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, HierarchyStrength_Offset), 0, null, HierarchyStrength);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, EffectorStrength_Offset), 0, null, EffectorStrength);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, EffectorRatio_Offset), 0, null, EffectorRatio);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, RootStrength_Offset), 0, null, RootStrength);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, RootRatio_Offset), 0, null, RootRatio);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Damping_Offset), 0, null, Damping);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, PoleVector_Offset), 0, null, PoleVector);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bFlipPolePlane_Offset), 0, null, FlipPolePlane);
            BlittableMarshaller<UnrealSharp.ControlRig.EControlRigVectorKind>.ToNative(IntPtr.Add(Buffer, PoleVectorKind_Offset), 0, null, PoleVectorKind);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, PoleVectorSpace_Offset), 0, null, PoleVectorSpace);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, PrimaryAxis_Offset), 0, null, PrimaryAxis);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, SecondaryAxis_Offset), 0, null, SecondaryAxis);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bLiveSimulation_Offset), 0, null, LiveSimulation);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, Iterations_Offset), 0, null, Iterations);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bLimitLocalPosition_Offset), 0, null, LimitLocalPosition);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bPropagateToChildren_Offset), 0, null, PropagateToChildren);
            UnrealSharp.ControlRig.RigUnit_SpringIK_DebugSettingsMarshaler.ToNative(IntPtr.Add(Buffer, DebugSettings_Offset), 0, null, DebugSettings);
        }
    }
}

public static class RigUnit_SpringIKMarshaler
{
    public static RigUnit_SpringIK FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_SpringIK(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_SpringIK obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_SpringIK.NativeDataSize;
    }
}