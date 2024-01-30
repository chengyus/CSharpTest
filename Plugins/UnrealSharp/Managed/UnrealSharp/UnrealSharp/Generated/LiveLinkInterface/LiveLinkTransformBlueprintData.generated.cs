using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.LiveLinkInterface;

[UStruct]
public partial struct LiveLinkTransformBlueprintData
{
    // StructProperty /Script/LiveLinkInterface.LiveLinkTransformBlueprintData:StaticData
    static readonly int StaticData_Offset;
    public UnrealSharp.LiveLinkInterface.LiveLinkTransformStaticData StaticData;
    
    // StructProperty /Script/LiveLinkInterface.LiveLinkTransformBlueprintData:FrameData
    static readonly int FrameData_Offset;
    public UnrealSharp.LiveLinkInterface.LiveLinkTransformFrameData FrameData;
    
    
    public static readonly int NativeDataSize;
    static LiveLinkTransformBlueprintData()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("LiveLinkTransformBlueprintData");
        
        StaticData_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "StaticData");
        FrameData_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FrameData");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public LiveLinkTransformBlueprintData(IntPtr InNativeStruct)
    {
        unsafe
        {
            StaticData = UnrealSharp.LiveLinkInterface.LiveLinkTransformStaticDataMarshaler.FromNative(IntPtr.Add(InNativeStruct, StaticData_Offset), 0, null);
            FrameData = UnrealSharp.LiveLinkInterface.LiveLinkTransformFrameDataMarshaler.FromNative(IntPtr.Add(InNativeStruct, FrameData_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.LiveLinkInterface.LiveLinkTransformStaticDataMarshaler.ToNative(IntPtr.Add(Buffer, StaticData_Offset), 0, null, StaticData);
            UnrealSharp.LiveLinkInterface.LiveLinkTransformFrameDataMarshaler.ToNative(IntPtr.Add(Buffer, FrameData_Offset), 0, null, FrameData);
        }
    }
}

public static class LiveLinkTransformBlueprintDataMarshaler
{
    public static LiveLinkTransformBlueprintData FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new LiveLinkTransformBlueprintData(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, LiveLinkTransformBlueprintData obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return LiveLinkTransformBlueprintData.NativeDataSize;
    }
}