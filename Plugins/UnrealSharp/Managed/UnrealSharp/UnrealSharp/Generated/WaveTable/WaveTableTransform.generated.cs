using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.WaveTable;

[UStruct]
public partial struct WaveTableTransform
{
    // EnumProperty /Script/WaveTable.WaveTableTransform:Curve
    static readonly int Curve_Offset;
    public UnrealSharp.WaveTable.EWaveTableCurve Curve;
    
    // FloatProperty /Script/WaveTable.WaveTableTransform:Scalar
    static readonly int Scalar_Offset;
    public float Scalar;
    
    // ObjectProperty /Script/WaveTable.WaveTableTransform:CurveShared
    static readonly int CurveShared_Offset;
    public UnrealSharp.Engine.CurveFloat CurveShared;
    
    
    public static readonly int NativeDataSize;
    static WaveTableTransform()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("WaveTableTransform");
        
        Curve_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Curve");
        Scalar_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Scalar");
        CurveShared_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CurveShared");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public WaveTableTransform(IntPtr InNativeStruct)
    {
        unsafe
        {
            Curve = BlittableMarshaller<UnrealSharp.WaveTable.EWaveTableCurve>.FromNative(IntPtr.Add(InNativeStruct, Curve_Offset), 0, null);
            Scalar = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Scalar_Offset), 0, null);
            CurveShared = ObjectMarshaller<UnrealSharp.Engine.CurveFloat>.FromNative(IntPtr.Add(InNativeStruct, CurveShared_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.WaveTable.EWaveTableCurve>.ToNative(IntPtr.Add(Buffer, Curve_Offset), 0, null, Curve);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Scalar_Offset), 0, null, Scalar);
            ObjectMarshaller<UnrealSharp.Engine.CurveFloat>.ToNative(IntPtr.Add(Buffer, CurveShared_Offset), 0, null, CurveShared);
        }
    }
}

public static class WaveTableTransformMarshaler
{
    public static WaveTableTransform FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new WaveTableTransform(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, WaveTableTransform obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return WaveTableTransform.NativeDataSize;
    }
}