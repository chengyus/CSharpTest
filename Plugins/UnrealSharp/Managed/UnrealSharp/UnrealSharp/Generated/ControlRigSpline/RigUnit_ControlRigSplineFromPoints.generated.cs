using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRigSpline;

[UStruct]
public partial struct RigUnit_ControlRigSplineFromPoints
{
    // EnumProperty /Script/ControlRigSpline.RigUnit_ControlRigSplineFromPoints:SplineMode
    static readonly int SplineMode_Offset;
    public UnrealSharp.ControlRigSpline.ESplineType SplineMode;
    
    // BoolProperty /Script/ControlRigSpline.RigUnit_ControlRigSplineFromPoints:bClosed
    static readonly int bClosed_Offset;
    public bool Closed;
    
    // IntProperty /Script/ControlRigSpline.RigUnit_ControlRigSplineFromPoints:SamplesPerSegment
    static readonly int SamplesPerSegment_Offset;
    public int SamplesPerSegment;
    
    // FloatProperty /Script/ControlRigSpline.RigUnit_ControlRigSplineFromPoints:Compression
    static readonly int Compression_Offset;
    public float Compression;
    
    // FloatProperty /Script/ControlRigSpline.RigUnit_ControlRigSplineFromPoints:Stretch
    static readonly int Stretch_Offset;
    public float Stretch;
    
    // StructProperty /Script/ControlRigSpline.RigUnit_ControlRigSplineFromPoints:Spline
    static readonly int Spline_Offset;
    public UnrealSharp.ControlRigSpline.ControlRigSpline Spline;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_ControlRigSplineFromPoints()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_ControlRigSplineFromPoints");
        
        SplineMode_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SplineMode");
        bClosed_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bClosed");
        SamplesPerSegment_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SamplesPerSegment");
        Compression_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Compression");
        Stretch_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Stretch");
        Spline_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Spline");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_ControlRigSplineFromPoints(IntPtr InNativeStruct)
    {
        unsafe
        {
            SplineMode = BlittableMarshaller<UnrealSharp.ControlRigSpline.ESplineType>.FromNative(IntPtr.Add(InNativeStruct, SplineMode_Offset), 0, null);
            Closed = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bClosed_Offset), 0, null);
            SamplesPerSegment = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, SamplesPerSegment_Offset), 0, null);
            Compression = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Compression_Offset), 0, null);
            Stretch = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Stretch_Offset), 0, null);
            Spline = UnrealSharp.ControlRigSpline.ControlRigSplineMarshaler.FromNative(IntPtr.Add(InNativeStruct, Spline_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.ControlRigSpline.ESplineType>.ToNative(IntPtr.Add(Buffer, SplineMode_Offset), 0, null, SplineMode);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bClosed_Offset), 0, null, Closed);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, SamplesPerSegment_Offset), 0, null, SamplesPerSegment);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Compression_Offset), 0, null, Compression);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Stretch_Offset), 0, null, Stretch);
            UnrealSharp.ControlRigSpline.ControlRigSplineMarshaler.ToNative(IntPtr.Add(Buffer, Spline_Offset), 0, null, Spline);
        }
    }
}

public static class RigUnit_ControlRigSplineFromPointsMarshaler
{
    public static RigUnit_ControlRigSplineFromPoints FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_ControlRigSplineFromPoints(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_ControlRigSplineFromPoints obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_ControlRigSplineFromPoints.NativeDataSize;
    }
}