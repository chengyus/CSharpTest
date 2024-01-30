using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.LiveLinkInterface;

[UStruct]
public partial struct LiveLinkCameraBlueprintData
{
    // StructProperty /Script/LiveLinkInterface.LiveLinkCameraBlueprintData:StaticData
    static readonly int StaticData_Offset;
    public UnrealSharp.LiveLinkInterface.LiveLinkCameraStaticData StaticData;
    
    // StructProperty /Script/LiveLinkInterface.LiveLinkCameraBlueprintData:FrameData
    static readonly int FrameData_Offset;
    public UnrealSharp.LiveLinkInterface.LiveLinkCameraFrameData FrameData;
    
    
    public static readonly int NativeDataSize;
    static LiveLinkCameraBlueprintData()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("LiveLinkCameraBlueprintData");
        
        StaticData_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "StaticData");
        FrameData_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FrameData");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public LiveLinkCameraBlueprintData(IntPtr InNativeStruct)
    {
        unsafe
        {
            StaticData = UnrealSharp.LiveLinkInterface.LiveLinkCameraStaticDataMarshaler.FromNative(IntPtr.Add(InNativeStruct, StaticData_Offset), 0, null);
            FrameData = UnrealSharp.LiveLinkInterface.LiveLinkCameraFrameDataMarshaler.FromNative(IntPtr.Add(InNativeStruct, FrameData_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.LiveLinkInterface.LiveLinkCameraStaticDataMarshaler.ToNative(IntPtr.Add(Buffer, StaticData_Offset), 0, null, StaticData);
            UnrealSharp.LiveLinkInterface.LiveLinkCameraFrameDataMarshaler.ToNative(IntPtr.Add(Buffer, FrameData_Offset), 0, null, FrameData);
        }
    }
}

public static class LiveLinkCameraBlueprintDataMarshaler
{
    public static LiveLinkCameraBlueprintData FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new LiveLinkCameraBlueprintData(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, LiveLinkCameraBlueprintData obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return LiveLinkCameraBlueprintData.NativeDataSize;
    }
}