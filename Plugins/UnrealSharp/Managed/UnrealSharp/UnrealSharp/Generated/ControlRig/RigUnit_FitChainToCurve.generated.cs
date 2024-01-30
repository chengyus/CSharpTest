using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_FitChainToCurve
{
    // NameProperty /Script/ControlRig.RigUnit_FitChainToCurve:StartBone
    static readonly int StartBone_Offset;
    public Name StartBone;
    
    // NameProperty /Script/ControlRig.RigUnit_FitChainToCurve:EndBone
    static readonly int EndBone_Offset;
    public Name EndBone;
    
    // StructProperty /Script/ControlRig.RigUnit_FitChainToCurve:Bezier
    static readonly int Bezier_Offset;
    public UnrealSharp.RigVM.RigVMFourPointBezier Bezier;
    
    // EnumProperty /Script/ControlRig.RigUnit_FitChainToCurve:Alignment
    static readonly int Alignment_Offset;
    public UnrealSharp.ControlRig.EControlRigCurveAlignment Alignment;
    
    // FloatProperty /Script/ControlRig.RigUnit_FitChainToCurve:Minimum
    static readonly int Minimum_Offset;
    public float Minimum;
    
    // FloatProperty /Script/ControlRig.RigUnit_FitChainToCurve:Maximum
    static readonly int Maximum_Offset;
    public float Maximum;
    
    // IntProperty /Script/ControlRig.RigUnit_FitChainToCurve:SamplingPrecision
    static readonly int SamplingPrecision_Offset;
    public int SamplingPrecision;
    
    // StructProperty /Script/ControlRig.RigUnit_FitChainToCurve:PrimaryAxis
    static readonly int PrimaryAxis_Offset;
    public System.DoubleNumerics.Vector3 PrimaryAxis;
    
    // StructProperty /Script/ControlRig.RigUnit_FitChainToCurve:SecondaryAxis
    static readonly int SecondaryAxis_Offset;
    public System.DoubleNumerics.Vector3 SecondaryAxis;
    
    // StructProperty /Script/ControlRig.RigUnit_FitChainToCurve:PoleVectorPosition
    static readonly int PoleVectorPosition_Offset;
    public System.DoubleNumerics.Vector3 PoleVectorPosition;
    
    // EnumProperty /Script/ControlRig.RigUnit_FitChainToCurve:RotationEaseType
    static readonly int RotationEaseType_Offset;
    public UnrealSharp.RigVM.ERigVMAnimEasingType RotationEaseType;
    
    // FloatProperty /Script/ControlRig.RigUnit_FitChainToCurve:Weight
    static readonly int Weight_Offset;
    public float Weight;
    
    // BoolProperty /Script/ControlRig.RigUnit_FitChainToCurve:bPropagateToChildren
    static readonly int bPropagateToChildren_Offset;
    public bool PropagateToChildren;
    
    // StructProperty /Script/ControlRig.RigUnit_FitChainToCurve:DebugSettings
    static readonly int DebugSettings_Offset;
    public UnrealSharp.ControlRig.RigUnit_FitChainToCurve_DebugSettings DebugSettings;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_FitChainToCurve()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_FitChainToCurve");
        
        StartBone_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "StartBone");
        EndBone_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "EndBone");
        Bezier_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Bezier");
        Alignment_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Alignment");
        Minimum_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Minimum");
        Maximum_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Maximum");
        SamplingPrecision_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SamplingPrecision");
        PrimaryAxis_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PrimaryAxis");
        SecondaryAxis_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SecondaryAxis");
        PoleVectorPosition_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PoleVectorPosition");
        RotationEaseType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RotationEaseType");
        Weight_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Weight");
        bPropagateToChildren_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bPropagateToChildren");
        DebugSettings_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DebugSettings");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_FitChainToCurve(IntPtr InNativeStruct)
    {
        unsafe
        {
            StartBone = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, StartBone_Offset), 0, null);
            EndBone = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, EndBone_Offset), 0, null);
            Bezier = UnrealSharp.RigVM.RigVMFourPointBezierMarshaler.FromNative(IntPtr.Add(InNativeStruct, Bezier_Offset), 0, null);
            Alignment = BlittableMarshaller<UnrealSharp.ControlRig.EControlRigCurveAlignment>.FromNative(IntPtr.Add(InNativeStruct, Alignment_Offset), 0, null);
            Minimum = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Minimum_Offset), 0, null);
            Maximum = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Maximum_Offset), 0, null);
            SamplingPrecision = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, SamplingPrecision_Offset), 0, null);
            PrimaryAxis = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, PrimaryAxis_Offset), 0, null);
            SecondaryAxis = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, SecondaryAxis_Offset), 0, null);
            PoleVectorPosition = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, PoleVectorPosition_Offset), 0, null);
            RotationEaseType = BlittableMarshaller<UnrealSharp.RigVM.ERigVMAnimEasingType>.FromNative(IntPtr.Add(InNativeStruct, RotationEaseType_Offset), 0, null);
            Weight = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Weight_Offset), 0, null);
            PropagateToChildren = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bPropagateToChildren_Offset), 0, null);
            DebugSettings = UnrealSharp.ControlRig.RigUnit_FitChainToCurve_DebugSettingsMarshaler.FromNative(IntPtr.Add(InNativeStruct, DebugSettings_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, StartBone_Offset), 0, null, StartBone);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, EndBone_Offset), 0, null, EndBone);
            UnrealSharp.RigVM.RigVMFourPointBezierMarshaler.ToNative(IntPtr.Add(Buffer, Bezier_Offset), 0, null, Bezier);
            BlittableMarshaller<UnrealSharp.ControlRig.EControlRigCurveAlignment>.ToNative(IntPtr.Add(Buffer, Alignment_Offset), 0, null, Alignment);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Minimum_Offset), 0, null, Minimum);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Maximum_Offset), 0, null, Maximum);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, SamplingPrecision_Offset), 0, null, SamplingPrecision);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, PrimaryAxis_Offset), 0, null, PrimaryAxis);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, SecondaryAxis_Offset), 0, null, SecondaryAxis);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, PoleVectorPosition_Offset), 0, null, PoleVectorPosition);
            BlittableMarshaller<UnrealSharp.RigVM.ERigVMAnimEasingType>.ToNative(IntPtr.Add(Buffer, RotationEaseType_Offset), 0, null, RotationEaseType);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Weight_Offset), 0, null, Weight);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bPropagateToChildren_Offset), 0, null, PropagateToChildren);
            UnrealSharp.ControlRig.RigUnit_FitChainToCurve_DebugSettingsMarshaler.ToNative(IntPtr.Add(Buffer, DebugSettings_Offset), 0, null, DebugSettings);
        }
    }
}

public static class RigUnit_FitChainToCurveMarshaler
{
    public static RigUnit_FitChainToCurve FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_FitChainToCurve(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_FitChainToCurve obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_FitChainToCurve.NativeDataSize;
    }
}