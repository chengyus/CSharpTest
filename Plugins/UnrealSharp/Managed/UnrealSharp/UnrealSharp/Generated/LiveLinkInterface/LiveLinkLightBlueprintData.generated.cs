using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.LiveLinkInterface;

[UStruct]
public partial struct LiveLinkLightBlueprintData
{
    // StructProperty /Script/LiveLinkInterface.LiveLinkLightBlueprintData:StaticData
    static readonly int StaticData_Offset;
    public UnrealSharp.LiveLinkInterface.LiveLinkLightStaticData StaticData;
    
    // StructProperty /Script/LiveLinkInterface.LiveLinkLightBlueprintData:FrameData
    static readonly int FrameData_Offset;
    public UnrealSharp.LiveLinkInterface.LiveLinkLightFrameData FrameData;
    
    
    public static readonly int NativeDataSize;
    static LiveLinkLightBlueprintData()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("LiveLinkLightBlueprintData");
        
        StaticData_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "StaticData");
        FrameData_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FrameData");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public LiveLinkLightBlueprintData(IntPtr InNativeStruct)
    {
        unsafe
        {
            StaticData = UnrealSharp.LiveLinkInterface.LiveLinkLightStaticDataMarshaler.FromNative(IntPtr.Add(InNativeStruct, StaticData_Offset), 0, null);
            FrameData = UnrealSharp.LiveLinkInterface.LiveLinkLightFrameDataMarshaler.FromNative(IntPtr.Add(InNativeStruct, FrameData_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.LiveLinkInterface.LiveLinkLightStaticDataMarshaler.ToNative(IntPtr.Add(Buffer, StaticData_Offset), 0, null, StaticData);
            UnrealSharp.LiveLinkInterface.LiveLinkLightFrameDataMarshaler.ToNative(IntPtr.Add(Buffer, FrameData_Offset), 0, null, FrameData);
        }
    }
}

public static class LiveLinkLightBlueprintDataMarshaler
{
    public static LiveLinkLightBlueprintData FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new LiveLinkLightBlueprintData(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, LiveLinkLightBlueprintData obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return LiveLinkLightBlueprintData.NativeDataSize;
    }
}