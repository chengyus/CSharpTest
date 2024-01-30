using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRigSpline;

[UStruct]
public partial struct RigUnit_GetLengthControlRigSpline
{
    // StructProperty /Script/ControlRigSpline.RigUnit_GetLengthControlRigSpline:Spline
    static readonly int Spline_Offset;
    public UnrealSharp.ControlRigSpline.ControlRigSpline Spline;
    
    // FloatProperty /Script/ControlRigSpline.RigUnit_GetLengthControlRigSpline:Length
    static readonly int Length_Offset;
    public float Length;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_GetLengthControlRigSpline()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_GetLengthControlRigSpline");
        
        Spline_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Spline");
        Length_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Length");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_GetLengthControlRigSpline(IntPtr InNativeStruct)
    {
        unsafe
        {
            Spline = UnrealSharp.ControlRigSpline.ControlRigSplineMarshaler.FromNative(IntPtr.Add(InNativeStruct, Spline_Offset), 0, null);
            Length = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Length_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.ControlRigSpline.ControlRigSplineMarshaler.ToNative(IntPtr.Add(Buffer, Spline_Offset), 0, null, Spline);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Length_Offset), 0, null, Length);
        }
    }
}

public static class RigUnit_GetLengthControlRigSplineMarshaler
{
    public static RigUnit_GetLengthControlRigSpline FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_GetLengthControlRigSpline(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_GetLengthControlRigSpline obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_GetLengthControlRigSpline.NativeDataSize;
    }
}