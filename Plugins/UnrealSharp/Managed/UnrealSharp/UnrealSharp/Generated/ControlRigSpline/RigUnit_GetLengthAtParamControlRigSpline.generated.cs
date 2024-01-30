using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRigSpline;

[UStruct]
public partial struct RigUnit_GetLengthAtParamControlRigSpline
{
    // StructProperty /Script/ControlRigSpline.RigUnit_GetLengthAtParamControlRigSpline:Spline
    static readonly int Spline_Offset;
    public UnrealSharp.ControlRigSpline.ControlRigSpline Spline;
    
    // FloatProperty /Script/ControlRigSpline.RigUnit_GetLengthAtParamControlRigSpline:U
    static readonly int U_Offset;
    public float U;
    
    // FloatProperty /Script/ControlRigSpline.RigUnit_GetLengthAtParamControlRigSpline:Length
    static readonly int Length_Offset;
    public float Length;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_GetLengthAtParamControlRigSpline()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_GetLengthAtParamControlRigSpline");
        
        Spline_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Spline");
        U_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "U");
        Length_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Length");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_GetLengthAtParamControlRigSpline(IntPtr InNativeStruct)
    {
        unsafe
        {
            Spline = UnrealSharp.ControlRigSpline.ControlRigSplineMarshaler.FromNative(IntPtr.Add(InNativeStruct, Spline_Offset), 0, null);
            U = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, U_Offset), 0, null);
            Length = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Length_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.ControlRigSpline.ControlRigSplineMarshaler.ToNative(IntPtr.Add(Buffer, Spline_Offset), 0, null, Spline);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, U_Offset), 0, null, U);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Length_Offset), 0, null, Length);
        }
    }
}

public static class RigUnit_GetLengthAtParamControlRigSplineMarshaler
{
    public static RigUnit_GetLengthAtParamControlRigSpline FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_GetLengthAtParamControlRigSpline(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_GetLengthAtParamControlRigSpline obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_GetLengthAtParamControlRigSpline.NativeDataSize;
    }
}