using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct CameraShakeStopParams
{
    // BoolProperty /Script/Engine.CameraShakeStopParams:bImmediately
    static readonly int bImmediately_Offset;
    public bool Immediately;
    
    
    public static readonly int NativeDataSize;
    static CameraShakeStopParams()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("CameraShakeStopParams");
        
        bImmediately_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bImmediately");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public CameraShakeStopParams(IntPtr InNativeStruct)
    {
        unsafe
        {
            Immediately = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bImmediately_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bImmediately_Offset), 0, null, Immediately);
        }
    }
}

public static class CameraShakeStopParamsMarshaler
{
    public static CameraShakeStopParams FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new CameraShakeStopParams(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, CameraShakeStopParams obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return CameraShakeStopParams.NativeDataSize;
    }
}