using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.LiveLinkInterface;

[UStruct]
public partial struct LiveLinkBasicBlueprintData
{
    // StructProperty /Script/LiveLinkInterface.LiveLinkBasicBlueprintData:StaticData
    static readonly int StaticData_Offset;
    public UnrealSharp.LiveLinkInterface.LiveLinkBaseStaticData StaticData;
    
    // StructProperty /Script/LiveLinkInterface.LiveLinkBasicBlueprintData:FrameData
    static readonly int FrameData_Offset;
    public UnrealSharp.LiveLinkInterface.LiveLinkBaseFrameData FrameData;
    
    
    public static readonly int NativeDataSize;
    static LiveLinkBasicBlueprintData()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("LiveLinkBasicBlueprintData");
        
        StaticData_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "StaticData");
        FrameData_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FrameData");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public LiveLinkBasicBlueprintData(IntPtr InNativeStruct)
    {
        unsafe
        {
            StaticData = UnrealSharp.LiveLinkInterface.LiveLinkBaseStaticDataMarshaler.FromNative(IntPtr.Add(InNativeStruct, StaticData_Offset), 0, null);
            FrameData = UnrealSharp.LiveLinkInterface.LiveLinkBaseFrameDataMarshaler.FromNative(IntPtr.Add(InNativeStruct, FrameData_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.LiveLinkInterface.LiveLinkBaseStaticDataMarshaler.ToNative(IntPtr.Add(Buffer, StaticData_Offset), 0, null, StaticData);
            UnrealSharp.LiveLinkInterface.LiveLinkBaseFrameDataMarshaler.ToNative(IntPtr.Add(Buffer, FrameData_Offset), 0, null, FrameData);
        }
    }
}

public static class LiveLinkBasicBlueprintDataMarshaler
{
    public static LiveLinkBasicBlueprintData FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new LiveLinkBasicBlueprintData(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, LiveLinkBasicBlueprintData obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return LiveLinkBasicBlueprintData.NativeDataSize;
    }
}