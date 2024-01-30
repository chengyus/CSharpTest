using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRigSpline;

[UStruct]
public partial struct RigUnit_FitChainToSplineCurveItemArray
{
    // StructProperty /Script/ControlRigSpline.RigUnit_FitChainToSplineCurveItemArray:Spline
    static readonly int Spline_Offset;
    public UnrealSharp.ControlRigSpline.ControlRigSpline Spline;
    
    // EnumProperty /Script/ControlRigSpline.RigUnit_FitChainToSplineCurveItemArray:Alignment
    static readonly int Alignment_Offset;
    public UnrealSharp.ControlRig.EControlRigCurveAlignment Alignment;
    
    // FloatProperty /Script/ControlRigSpline.RigUnit_FitChainToSplineCurveItemArray:Minimum
    static readonly int Minimum_Offset;
    public float Minimum;
    
    // FloatProperty /Script/ControlRigSpline.RigUnit_FitChainToSplineCurveItemArray:Maximum
    static readonly int Maximum_Offset;
    public float Maximum;
    
    // IntProperty /Script/ControlRigSpline.RigUnit_FitChainToSplineCurveItemArray:SamplingPrecision
    static readonly int SamplingPrecision_Offset;
    public int SamplingPrecision;
    
    // StructProperty /Script/ControlRigSpline.RigUnit_FitChainToSplineCurveItemArray:PrimaryAxis
    static readonly int PrimaryAxis_Offset;
    public System.DoubleNumerics.Vector3 PrimaryAxis;
    
    // StructProperty /Script/ControlRigSpline.RigUnit_FitChainToSplineCurveItemArray:SecondaryAxis
    static readonly int SecondaryAxis_Offset;
    public System.DoubleNumerics.Vector3 SecondaryAxis;
    
    // StructProperty /Script/ControlRigSpline.RigUnit_FitChainToSplineCurveItemArray:PoleVectorPosition
    static readonly int PoleVectorPosition_Offset;
    public System.DoubleNumerics.Vector3 PoleVectorPosition;
    
    // EnumProperty /Script/ControlRigSpline.RigUnit_FitChainToSplineCurveItemArray:RotationEaseType
    static readonly int RotationEaseType_Offset;
    public UnrealSharp.RigVM.ERigVMAnimEasingType RotationEaseType;
    
    // FloatProperty /Script/ControlRigSpline.RigUnit_FitChainToSplineCurveItemArray:Weight
    static readonly int Weight_Offset;
    public float Weight;
    
    // BoolProperty /Script/ControlRigSpline.RigUnit_FitChainToSplineCurveItemArray:bPropagateToChildren
    static readonly int bPropagateToChildren_Offset;
    public bool PropagateToChildren;
    
    // StructProperty /Script/ControlRigSpline.RigUnit_FitChainToSplineCurveItemArray:DebugSettings
    static readonly int DebugSettings_Offset;
    public UnrealSharp.ControlRig.RigUnit_FitChainToCurve_DebugSettings DebugSettings;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_FitChainToSplineCurveItemArray()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_FitChainToSplineCurveItemArray");
        
        Spline_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Spline");
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
    public RigUnit_FitChainToSplineCurveItemArray(IntPtr InNativeStruct)
    {
        unsafe
        {
            Spline = UnrealSharp.ControlRigSpline.ControlRigSplineMarshaler.FromNative(IntPtr.Add(InNativeStruct, Spline_Offset), 0, null);
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
            UnrealSharp.ControlRigSpline.ControlRigSplineMarshaler.ToNative(IntPtr.Add(Buffer, Spline_Offset), 0, null, Spline);
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

public static class RigUnit_FitChainToSplineCurveItemArrayMarshaler
{
    public static RigUnit_FitChainToSplineCurveItemArray FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_FitChainToSplineCurveItemArray(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_FitChainToSplineCurveItemArray obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_FitChainToSplineCurveItemArray.NativeDataSize;
    }
}