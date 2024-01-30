using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct CameraShakeStartParams
{
    // BoolProperty /Script/Engine.CameraShakeStartParams:bIsRestarting
    static readonly int bIsRestarting_Offset;
    public bool IsRestarting;
    
    
    public static readonly int NativeDataSize;
    static CameraShakeStartParams()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("CameraShakeStartParams");
        
        bIsRestarting_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIsRestarting");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public CameraShakeStartParams(IntPtr InNativeStruct)
    {
        unsafe
        {
            IsRestarting = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIsRestarting_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bIsRestarting_Offset), 0, null, IsRestarting);
        }
    }
}

public static class CameraShakeStartParamsMarshaler
{
    public static CameraShakeStartParams FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new CameraShakeStartParams(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, CameraShakeStartParams obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return CameraShakeStartParams.NativeDataSize;
    }
}