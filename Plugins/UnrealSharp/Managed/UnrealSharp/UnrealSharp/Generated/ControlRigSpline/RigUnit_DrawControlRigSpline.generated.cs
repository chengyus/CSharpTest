using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRigSpline;

[UStruct]
public partial struct RigUnit_DrawControlRigSpline
{
    // StructProperty /Script/ControlRigSpline.RigUnit_DrawControlRigSpline:Spline
    static readonly int Spline_Offset;
    public UnrealSharp.ControlRigSpline.ControlRigSpline Spline;
    
    // StructProperty /Script/ControlRigSpline.RigUnit_DrawControlRigSpline:Color
    static readonly int Color_Offset;
    public UnrealSharp.CoreUObject.LinearColor Color;
    
    // FloatProperty /Script/ControlRigSpline.RigUnit_DrawControlRigSpline:Thickness
    static readonly int Thickness_Offset;
    public float Thickness;
    
    // IntProperty /Script/ControlRigSpline.RigUnit_DrawControlRigSpline:Detail
    static readonly int Detail_Offset;
    public int Detail;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_DrawControlRigSpline()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_DrawControlRigSpline");
        
        Spline_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Spline");
        Color_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Color");
        Thickness_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Thickness");
        Detail_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Detail");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_DrawControlRigSpline(IntPtr InNativeStruct)
    {
        unsafe
        {
            Spline = UnrealSharp.ControlRigSpline.ControlRigSplineMarshaler.FromNative(IntPtr.Add(InNativeStruct, Spline_Offset), 0, null);
            Color = BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.FromNative(IntPtr.Add(InNativeStruct, Color_Offset), 0, null);
            Thickness = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Thickness_Offset), 0, null);
            Detail = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, Detail_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.ControlRigSpline.ControlRigSplineMarshaler.ToNative(IntPtr.Add(Buffer, Spline_Offset), 0, null, Spline);
            BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.ToNative(IntPtr.Add(Buffer, Color_Offset), 0, null, Color);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Thickness_Offset), 0, null, Thickness);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, Detail_Offset), 0, null, Detail);
        }
    }
}

public static class RigUnit_DrawControlRigSplineMarshaler
{
    public static RigUnit_DrawControlRigSpline FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_DrawControlRigSpline(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_DrawControlRigSpline obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_DrawControlRigSpline.NativeDataSize;
    }
}