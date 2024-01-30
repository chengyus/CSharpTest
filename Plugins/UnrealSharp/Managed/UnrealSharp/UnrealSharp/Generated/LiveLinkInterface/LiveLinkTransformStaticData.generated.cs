using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.LiveLinkInterface;

[UStruct]
public partial struct LiveLinkTransformStaticData
{
    // BoolProperty /Script/LiveLinkInterface.LiveLinkTransformStaticData:bIsLocationSupported
    static readonly int bIsLocationSupported_Offset;
    public bool IsLocationSupported;
    
    // BoolProperty /Script/LiveLinkInterface.LiveLinkTransformStaticData:bIsRotationSupported
    static readonly int bIsRotationSupported_Offset;
    public bool IsRotationSupported;
    
    // BoolProperty /Script/LiveLinkInterface.LiveLinkTransformStaticData:bIsScaleSupported
    static readonly int bIsScaleSupported_Offset;
    public bool IsScaleSupported;
    
    
    public static readonly int NativeDataSize;
    static LiveLinkTransformStaticData()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("LiveLinkTransformStaticData");
        
        bIsLocationSupported_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIsLocationSupported");
        bIsRotationSupported_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIsRotationSupported");
        bIsScaleSupported_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIsScaleSupported");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public LiveLinkTransformStaticData(IntPtr InNativeStruct)
    {
        unsafe
        {
            IsLocationSupported = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIsLocationSupported_Offset), 0, null);
            IsRotationSupported = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIsRotationSupported_Offset), 0, null);
            IsScaleSupported = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIsScaleSupported_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bIsLocationSupported_Offset), 0, null, IsLocationSupported);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bIsRotationSupported_Offset), 0, null, IsRotationSupported);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bIsScaleSupported_Offset), 0, null, IsScaleSupported);
        }
    }
}

public static class LiveLinkTransformStaticDataMarshaler
{
    public static LiveLinkTransformStaticData FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new LiveLinkTransformStaticData(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, LiveLinkTransformStaticData obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return LiveLinkTransformStaticData.NativeDataSize;
    }
}