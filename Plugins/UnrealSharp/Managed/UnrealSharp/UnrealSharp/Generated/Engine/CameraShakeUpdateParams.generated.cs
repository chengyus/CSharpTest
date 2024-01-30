using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct CameraShakeUpdateParams
{
    // FloatProperty /Script/Engine.CameraShakeUpdateParams:DeltaTime
    static readonly int DeltaTime_Offset;
    public float DeltaTime;
    
    // FloatProperty /Script/Engine.CameraShakeUpdateParams:ShakeScale
    static readonly int ShakeScale_Offset;
    public float ShakeScale;
    
    // FloatProperty /Script/Engine.CameraShakeUpdateParams:DynamicScale
    static readonly int DynamicScale_Offset;
    public float DynamicScale;
    
    // StructProperty /Script/Engine.CameraShakeUpdateParams:POV
    static readonly int POV_Offset;
    public UnrealSharp.Engine.MinimalViewInfo POV;
    
    
    public static readonly int NativeDataSize;
    static CameraShakeUpdateParams()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("CameraShakeUpdateParams");
        
        DeltaTime_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DeltaTime");
        ShakeScale_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ShakeScale");
        DynamicScale_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DynamicScale");
        POV_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "POV");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public CameraShakeUpdateParams(IntPtr InNativeStruct)
    {
        unsafe
        {
            DeltaTime = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, DeltaTime_Offset), 0, null);
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
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, DeltaTime_Offset), 0, null, DeltaTime);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ShakeScale_Offset), 0, null, ShakeScale);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, DynamicScale_Offset), 0, null, DynamicScale);
            UnrealSharp.Engine.MinimalViewInfoMarshaler.ToNative(IntPtr.Add(Buffer, POV_Offset), 0, null, POV);
        }
    }
}

public static class CameraShakeUpdateParamsMarshaler
{
    public static CameraShakeUpdateParams FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new CameraShakeUpdateParams(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, CameraShakeUpdateParams obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return CameraShakeUpdateParams.NativeDataSize;
    }
}