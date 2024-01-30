using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRigSpline;

[UStruct]
public partial struct RigUnit_SetSplineTransforms
{
    // StructProperty /Script/ControlRigSpline.RigUnit_SetSplineTransforms:Spline
    static readonly int Spline_Offset;
    public UnrealSharp.ControlRigSpline.ControlRigSpline Spline;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_SetSplineTransforms()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_SetSplineTransforms");
        
        Spline_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Spline");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_SetSplineTransforms(IntPtr InNativeStruct)
    {
        unsafe
        {
            Spline = UnrealSharp.ControlRigSpline.ControlRigSplineMarshaler.FromNative(IntPtr.Add(InNativeStruct, Spline_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.ControlRigSpline.ControlRigSplineMarshaler.ToNative(IntPtr.Add(Buffer, Spline_Offset), 0, null, Spline);
        }
    }
}

public static class RigUnit_SetSplineTransformsMarshaler
{
    public static RigUnit_SetSplineTransforms FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_SetSplineTransforms(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_SetSplineTransforms obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_SetSplineTransforms.NativeDataSize;
    }
}