using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_PointSimulation
{
    // FloatProperty /Script/ControlRig.RigUnit_PointSimulation:SimulatedStepsPerSecond
    static readonly int SimulatedStepsPerSecond_Offset;
    public float SimulatedStepsPerSecond;
    
    // EnumProperty /Script/ControlRig.RigUnit_PointSimulation:IntegratorType
    static readonly int IntegratorType_Offset;
    public UnrealSharp.RigVM.ERigVMSimPointIntegrateType IntegratorType;
    
    // FloatProperty /Script/ControlRig.RigUnit_PointSimulation:VerletBlend
    static readonly int VerletBlend_Offset;
    public float VerletBlend;
    
    // BoolProperty /Script/ControlRig.RigUnit_PointSimulation:bLimitLocalPosition
    static readonly int bLimitLocalPosition_Offset;
    public bool LimitLocalPosition;
    
    // BoolProperty /Script/ControlRig.RigUnit_PointSimulation:bPropagateToChildren
    static readonly int bPropagateToChildren_Offset;
    public bool PropagateToChildren;
    
    // StructProperty /Script/ControlRig.RigUnit_PointSimulation:PrimaryAimAxis
    static readonly int PrimaryAimAxis_Offset;
    public System.DoubleNumerics.Vector3 PrimaryAimAxis;
    
    // StructProperty /Script/ControlRig.RigUnit_PointSimulation:SecondaryAimAxis
    static readonly int SecondaryAimAxis_Offset;
    public System.DoubleNumerics.Vector3 SecondaryAimAxis;
    
    // StructProperty /Script/ControlRig.RigUnit_PointSimulation:DebugSettings
    static readonly int DebugSettings_Offset;
    public UnrealSharp.ControlRig.RigUnit_PointSimulation_DebugSettings DebugSettings;
    
    // StructProperty /Script/ControlRig.RigUnit_PointSimulation:Bezier
    static readonly int Bezier_Offset;
    public UnrealSharp.RigVM.RigVMFourPointBezier Bezier;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_PointSimulation()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_PointSimulation");
        
        SimulatedStepsPerSecond_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SimulatedStepsPerSecond");
        IntegratorType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "IntegratorType");
        VerletBlend_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "VerletBlend");
        bLimitLocalPosition_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bLimitLocalPosition");
        bPropagateToChildren_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bPropagateToChildren");
        PrimaryAimAxis_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PrimaryAimAxis");
        SecondaryAimAxis_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SecondaryAimAxis");
        DebugSettings_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DebugSettings");
        Bezier_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Bezier");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_PointSimulation(IntPtr InNativeStruct)
    {
        unsafe
        {
            SimulatedStepsPerSecond = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, SimulatedStepsPerSecond_Offset), 0, null);
            IntegratorType = BlittableMarshaller<UnrealSharp.RigVM.ERigVMSimPointIntegrateType>.FromNative(IntPtr.Add(InNativeStruct, IntegratorType_Offset), 0, null);
            VerletBlend = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, VerletBlend_Offset), 0, null);
            LimitLocalPosition = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bLimitLocalPosition_Offset), 0, null);
            PropagateToChildren = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bPropagateToChildren_Offset), 0, null);
            PrimaryAimAxis = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, PrimaryAimAxis_Offset), 0, null);
            SecondaryAimAxis = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, SecondaryAimAxis_Offset), 0, null);
            DebugSettings = UnrealSharp.ControlRig.RigUnit_PointSimulation_DebugSettingsMarshaler.FromNative(IntPtr.Add(InNativeStruct, DebugSettings_Offset), 0, null);
            Bezier = UnrealSharp.RigVM.RigVMFourPointBezierMarshaler.FromNative(IntPtr.Add(InNativeStruct, Bezier_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, SimulatedStepsPerSecond_Offset), 0, null, SimulatedStepsPerSecond);
            BlittableMarshaller<UnrealSharp.RigVM.ERigVMSimPointIntegrateType>.ToNative(IntPtr.Add(Buffer, IntegratorType_Offset), 0, null, IntegratorType);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, VerletBlend_Offset), 0, null, VerletBlend);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bLimitLocalPosition_Offset), 0, null, LimitLocalPosition);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bPropagateToChildren_Offset), 0, null, PropagateToChildren);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, PrimaryAimAxis_Offset), 0, null, PrimaryAimAxis);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, SecondaryAimAxis_Offset), 0, null, SecondaryAimAxis);
            UnrealSharp.ControlRig.RigUnit_PointSimulation_DebugSettingsMarshaler.ToNative(IntPtr.Add(Buffer, DebugSettings_Offset), 0, null, DebugSettings);
            UnrealSharp.RigVM.RigVMFourPointBezierMarshaler.ToNative(IntPtr.Add(Buffer, Bezier_Offset), 0, null, Bezier);
        }
    }
}

public static class RigUnit_PointSimulationMarshaler
{
    public static RigUnit_PointSimulation FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_PointSimulation(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_PointSimulation obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_PointSimulation.NativeDataSize;
    }
}