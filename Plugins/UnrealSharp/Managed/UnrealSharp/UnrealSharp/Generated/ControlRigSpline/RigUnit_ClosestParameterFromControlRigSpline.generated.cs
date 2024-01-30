using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRigSpline;

[UStruct]
public partial struct RigUnit_ClosestParameterFromControlRigSpline
{
    // StructProperty /Script/ControlRigSpline.RigUnit_ClosestParameterFromControlRigSpline:Spline
    static readonly int Spline_Offset;
    public UnrealSharp.ControlRigSpline.ControlRigSpline Spline;
    
    // StructProperty /Script/ControlRigSpline.RigUnit_ClosestParameterFromControlRigSpline:Position
    static readonly int Position_Offset;
    public System.DoubleNumerics.Vector3 Position;
    
    // FloatProperty /Script/ControlRigSpline.RigUnit_ClosestParameterFromControlRigSpline:U
    static readonly int U_Offset;
    public float U;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_ClosestParameterFromControlRigSpline()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_ClosestParameterFromControlRigSpline");
        
        Spline_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Spline");
        Position_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Position");
        U_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "U");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_ClosestParameterFromControlRigSpline(IntPtr InNativeStruct)
    {
        unsafe
        {
            Spline = UnrealSharp.ControlRigSpline.ControlRigSplineMarshaler.FromNative(IntPtr.Add(InNativeStruct, Spline_Offset), 0, null);
            Position = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Position_Offset), 0, null);
            U = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, U_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.ControlRigSpline.ControlRigSplineMarshaler.ToNative(IntPtr.Add(Buffer, Spline_Offset), 0, null, Spline);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Position_Offset), 0, null, Position);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, U_Offset), 0, null, U);
        }
    }
}

public static class RigUnit_ClosestParameterFromControlRigSplineMarshaler
{
    public static RigUnit_ClosestParameterFromControlRigSpline FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_ClosestParameterFromControlRigSpline(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_ClosestParameterFromControlRigSpline obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_ClosestParameterFromControlRigSpline.NativeDataSize;
    }
}