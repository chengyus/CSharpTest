using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRigSpline;

[UStruct]
public partial struct RigUnit_PositionFromControlRigSpline
{
    // StructProperty /Script/ControlRigSpline.RigUnit_PositionFromControlRigSpline:Spline
    static readonly int Spline_Offset;
    public UnrealSharp.ControlRigSpline.ControlRigSpline Spline;
    
    // FloatProperty /Script/ControlRigSpline.RigUnit_PositionFromControlRigSpline:U
    static readonly int U_Offset;
    public float U;
    
    // StructProperty /Script/ControlRigSpline.RigUnit_PositionFromControlRigSpline:Position
    static readonly int Position_Offset;
    public System.DoubleNumerics.Vector3 Position;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_PositionFromControlRigSpline()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_PositionFromControlRigSpline");
        
        Spline_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Spline");
        U_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "U");
        Position_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Position");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_PositionFromControlRigSpline(IntPtr InNativeStruct)
    {
        unsafe
        {
            Spline = UnrealSharp.ControlRigSpline.ControlRigSplineMarshaler.FromNative(IntPtr.Add(InNativeStruct, Spline_Offset), 0, null);
            U = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, U_Offset), 0, null);
            Position = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Position_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.ControlRigSpline.ControlRigSplineMarshaler.ToNative(IntPtr.Add(Buffer, Spline_Offset), 0, null, Spline);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, U_Offset), 0, null, U);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Position_Offset), 0, null, Position);
        }
    }
}

public static class RigUnit_PositionFromControlRigSplineMarshaler
{
    public static RigUnit_PositionFromControlRigSpline FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_PositionFromControlRigSpline(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_PositionFromControlRigSpline obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_PositionFromControlRigSpline.NativeDataSize;
    }
}