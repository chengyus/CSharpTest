using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRigSpline;

[UStruct]
public partial struct RigUnit_SplineConstraint
{
    // StructProperty /Script/ControlRigSpline.RigUnit_SplineConstraint:Spline
    static readonly int Spline_Offset;
    public UnrealSharp.ControlRigSpline.ControlRigSpline Spline;
    
    // EnumProperty /Script/ControlRigSpline.RigUnit_SplineConstraint:Alignment
    static readonly int Alignment_Offset;
    public UnrealSharp.ControlRig.EControlRigCurveAlignment Alignment;
    
    // FloatProperty /Script/ControlRigSpline.RigUnit_SplineConstraint:Minimum
    static readonly int Minimum_Offset;
    public float Minimum;
    
    // FloatProperty /Script/ControlRigSpline.RigUnit_SplineConstraint:Maximum
    static readonly int Maximum_Offset;
    public float Maximum;
    
    // StructProperty /Script/ControlRigSpline.RigUnit_SplineConstraint:PrimaryAxis
    static readonly int PrimaryAxis_Offset;
    public System.DoubleNumerics.Vector3 PrimaryAxis;
    
    // StructProperty /Script/ControlRigSpline.RigUnit_SplineConstraint:SecondaryAxis
    static readonly int SecondaryAxis_Offset;
    public System.DoubleNumerics.Vector3 SecondaryAxis;
    
    // BoolProperty /Script/ControlRigSpline.RigUnit_SplineConstraint:bPropagateToChildren
    static readonly int bPropagateToChildren_Offset;
    public bool PropagateToChildren;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_SplineConstraint()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_SplineConstraint");
        
        Spline_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Spline");
        Alignment_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Alignment");
        Minimum_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Minimum");
        Maximum_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Maximum");
        PrimaryAxis_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PrimaryAxis");
        SecondaryAxis_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SecondaryAxis");
        bPropagateToChildren_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bPropagateToChildren");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_SplineConstraint(IntPtr InNativeStruct)
    {
        unsafe
        {
            Spline = UnrealSharp.ControlRigSpline.ControlRigSplineMarshaler.FromNative(IntPtr.Add(InNativeStruct, Spline_Offset), 0, null);
            Alignment = BlittableMarshaller<UnrealSharp.ControlRig.EControlRigCurveAlignment>.FromNative(IntPtr.Add(InNativeStruct, Alignment_Offset), 0, null);
            Minimum = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Minimum_Offset), 0, null);
            Maximum = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Maximum_Offset), 0, null);
            PrimaryAxis = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, PrimaryAxis_Offset), 0, null);
            SecondaryAxis = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, SecondaryAxis_Offset), 0, null);
            PropagateToChildren = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bPropagateToChildren_Offset), 0, null);
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
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, PrimaryAxis_Offset), 0, null, PrimaryAxis);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, SecondaryAxis_Offset), 0, null, SecondaryAxis);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bPropagateToChildren_Offset), 0, null, PropagateToChildren);
        }
    }
}

public static class RigUnit_SplineConstraintMarshaler
{
    public static RigUnit_SplineConstraint FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_SplineConstraint(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_SplineConstraint obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_SplineConstraint.NativeDataSize;
    }
}