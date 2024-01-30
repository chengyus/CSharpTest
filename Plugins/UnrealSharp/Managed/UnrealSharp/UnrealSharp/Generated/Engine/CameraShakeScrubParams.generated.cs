using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct CameraShakeScrubParams
{
    // FloatProperty /Script/Engine.CameraShakeScrubParams:AbsoluteTime
    static readonly int AbsoluteTime_Offset;
    public float AbsoluteTime;
    
    // FloatProperty /Script/Engine.CameraShakeScrubParams:ShakeScale
    static readonly int ShakeScale_Offset;
    public float ShakeScale;
    
    // FloatProperty /Script/Engine.CameraShakeScrubParams:DynamicScale
    static readonly int DynamicScale_Offset;
    public float DynamicScale;
    
    // StructProperty /Script/Engine.CameraShakeScrubParams:POV
    static readonly int POV_Offset;
    public UnrealSharp.Engine.MinimalViewInfo POV;
    
    
    public static readonly int NativeDataSize;
    static CameraShakeScrubParams()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("CameraShakeScrubParams");
        
        AbsoluteTime_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AbsoluteTime");
        ShakeScale_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ShakeScale");
        DynamicScale_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DynamicScale");
        POV_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "POV");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public CameraShakeScrubParams(IntPtr InNativeStruct)
    {
        unsafe
        {
            AbsoluteTime = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, AbsoluteTime_Offset), 0, null);
            ShakeScale = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ShakeScale_Offset), 0, null);
            DynamicScale = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, DynamicScale_Offset), 0, null);
            POV = UnrealSharp.Engine.MinimalViewInfoMarshaler.FromNative(IntPtr.Add(InNativeStruct, POV_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, AbsoluteTime_Offset), 0, null, AbsoluteTime);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ShakeScale_Offset), 0, null, ShakeScale);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, DynamicScale_Offset), 0, null, DynamicScale);
            UnrealSharp.Engine.MinimalViewInfoMarshaler.ToNative(IntPtr.Add(Buffer, POV_Offset), 0, null, POV);
        }
    }
}

public static class CameraShakeScrubParamsMarshaler
{
    public static CameraShakeScrubParams FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new CameraShakeScrubParams(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, CameraShakeScrubParams obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return CameraShakeScrubParams.NativeDataSize;
    }
}