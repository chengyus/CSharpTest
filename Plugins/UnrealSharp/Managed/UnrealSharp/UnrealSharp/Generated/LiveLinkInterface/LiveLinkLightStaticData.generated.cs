using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.LiveLinkInterface;

[UStruct]
public partial struct LiveLinkLightStaticData
{
    // BoolProperty /Script/LiveLinkInterface.LiveLinkLightStaticData:bIsTemperatureSupported
    static readonly int bIsTemperatureSupported_Offset;
    public bool IsTemperatureSupported;
    
    // BoolProperty /Script/LiveLinkInterface.LiveLinkLightStaticData:bIsIntensitySupported
    static readonly int bIsIntensitySupported_Offset;
    public bool IsIntensitySupported;
    
    // BoolProperty /Script/LiveLinkInterface.LiveLinkLightStaticData:bIsLightColorSupported
    static readonly int bIsLightColorSupported_Offset;
    public bool IsLightColorSupported;
    
    // BoolProperty /Script/LiveLinkInterface.LiveLinkLightStaticData:bIsInnerConeAngleSupported
    static readonly int bIsInnerConeAngleSupported_Offset;
    public bool IsInnerConeAngleSupported;
    
    // BoolProperty /Script/LiveLinkInterface.LiveLinkLightStaticData:bIsOuterConeAngleSupported
    static readonly int bIsOuterConeAngleSupported_Offset;
    public bool IsOuterConeAngleSupported;
    
    // BoolProperty /Script/LiveLinkInterface.LiveLinkLightStaticData:bIsAttenuationRadiusSupported
    static readonly int bIsAttenuationRadiusSupported_Offset;
    public bool IsAttenuationRadiusSupported;
    
    // BoolProperty /Script/LiveLinkInterface.LiveLinkLightStaticData:bIsSourceLenghtSupported
    static readonly int bIsSourceLenghtSupported_Offset;
    public bool IsSourceLenghtSupported;
    
    // BoolProperty /Script/LiveLinkInterface.LiveLinkLightStaticData:bIsSourceRadiusSupported
    static readonly int bIsSourceRadiusSupported_Offset;
    public bool IsSourceRadiusSupported;
    
    // BoolProperty /Script/LiveLinkInterface.LiveLinkLightStaticData:bIsSoftSourceRadiusSupported
    static readonly int bIsSoftSourceRadiusSupported_Offset;
    public bool IsSoftSourceRadiusSupported;
    
    
    public static readonly int NativeDataSize;
    static LiveLinkLightStaticData()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("LiveLinkLightStaticData");
        
        bIsTemperatureSupported_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIsTemperatureSupported");
        bIsIntensitySupported_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIsIntensitySupported");
        bIsLightColorSupported_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIsLightColorSupported");
        bIsInnerConeAngleSupported_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIsInnerConeAngleSupported");
        bIsOuterConeAngleSupported_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIsOuterConeAngleSupported");
        bIsAttenuationRadiusSupported_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIsAttenuationRadiusSupported");
        bIsSourceLenghtSupported_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIsSourceLenghtSupported");
        bIsSourceRadiusSupported_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIsSourceRadiusSupported");
        bIsSoftSourceRadiusSupported_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIsSoftSourceRadiusSupported");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public LiveLinkLightStaticData(IntPtr InNativeStruct)
    {
        unsafe
        {
            IsTemperatureSupported = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIsTemperatureSupported_Offset), 0, null);
            IsIntensitySupported = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIsIntensitySupported_Offset), 0, null);
            IsLightColorSupported = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIsLightColorSupported_Offset), 0, null);
            IsInnerConeAngleSupported = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIsInnerConeAngleSupported_Offset), 0, null);
            IsOuterConeAngleSupported = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIsOuterConeAngleSupported_Offset), 0, null);
            IsAttenuationRadiusSupported = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIsAttenuationRadiusSupported_Offset), 0, null);
            IsSourceLenghtSupported = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIsSourceLenghtSupported_Offset), 0, null);
            IsSourceRadiusSupported = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIsSourceRadiusSupported_Offset), 0, null);
            IsSoftSourceRadiusSupported = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIsSoftSourceRadiusSupported_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bIsTemperatureSupported_Offset), 0, null, IsTemperatureSupported);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bIsIntensitySupported_Offset), 0, null, IsIntensitySupported);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bIsLightColorSupported_Offset), 0, null, IsLightColorSupported);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bIsInnerConeAngleSupported_Offset), 0, null, IsInnerConeAngleSupported);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bIsOuterConeAngleSupported_Offset), 0, null, IsOuterConeAngleSupported);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bIsAttenuationRadiusSupported_Offset), 0, null, IsAttenuationRadiusSupported);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bIsSourceLenghtSupported_Offset), 0, null, IsSourceLenghtSupported);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bIsSourceRadiusSupported_Offset), 0, null, IsSourceRadiusSupported);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bIsSoftSourceRadiusSupported_Offset), 0, null, IsSoftSourceRadiusSupported);
        }
    }
}

public static class LiveLinkLightStaticDataMarshaler
{
    public static LiveLinkLightStaticData FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new LiveLinkLightStaticData(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, LiveLinkLightStaticData obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return LiveLinkLightStaticData.NativeDataSize;
    }
}