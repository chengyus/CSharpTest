using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct CurveScaledPayload
{
    // FloatProperty /Script/Engine.CurveScaledPayload:Factor
    static readonly int Factor_Offset;
    public float Factor;
    
    // FloatProperty /Script/Engine.CurveScaledPayload:Origin
    static readonly int Origin_Offset;
    public float Origin;
    
    
    public static readonly int NativeDataSize;
    static CurveScaledPayload()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("CurveScaledPayload");
        
        Factor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Factor");
        Origin_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Origin");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public CurveScaledPayload(IntPtr InNativeStruct)
    {
        unsafe
        {
            Factor = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Factor_Offset), 0, null);
            Origin = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Origin_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Factor_Offset), 0, null, Factor);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Origin_Offset), 0, null, Origin);
        }
    }
}

public static class CurveScaledPayloadMarshaler
{
    public static CurveScaledPayload FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new CurveScaledPayload(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, CurveScaledPayload obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return CurveScaledPayload.NativeDataSize;
    }
}