using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.LiveLinkInterface;

[UStruct]
public partial struct LiveLinkLightFrameData
{
    // FloatProperty /Script/LiveLinkInterface.LiveLinkLightFrameData:Temperature
    static readonly int Temperature_Offset;
    public float Temperature;
    
    // FloatProperty /Script/LiveLinkInterface.LiveLinkLightFrameData:Intensity
    static readonly int Intensity_Offset;
    public float Intensity;
    
    // StructProperty /Script/LiveLinkInterface.LiveLinkLightFrameData:LightColor
    static readonly int LightColor_Offset;
    public UnrealSharp.CoreUObject.Color LightColor;
    
    // FloatProperty /Script/LiveLinkInterface.LiveLinkLightFrameData:InnerConeAngle
    static readonly int InnerConeAngle_Offset;
    public float InnerConeAngle;
    
    // FloatProperty /Script/LiveLinkInterface.LiveLinkLightFrameData:OuterConeAngle
    static readonly int OuterConeAngle_Offset;
    public float OuterConeAngle;
    
    // FloatProperty /Script/LiveLinkInterface.LiveLinkLightFrameData:AttenuationRadius
    static readonly int AttenuationRadius_Offset;
    public float AttenuationRadius;
    
    // FloatProperty /Script/LiveLinkInterface.LiveLinkLightFrameData:SourceRadius
    static readonly int SourceRadius_Offset;
    public float SourceRadius;
    
    // FloatProperty /Script/LiveLinkInterface.LiveLinkLightFrameData:SoftSourceRadius
    static readonly int SoftSourceRadius_Offset;
    public float SoftSourceRadius;
    
    // FloatProperty /Script/LiveLinkInterface.LiveLinkLightFrameData:SourceLength
    static readonly int SourceLength_Offset;
    public float SourceLength;
    
    
    public static readonly int NativeDataSize;
    static LiveLinkLightFrameData()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("LiveLinkLightFrameData");
        
        Temperature_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Temperature");
        Intensity_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Intensity");
        LightColor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LightColor");
        InnerConeAngle_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "InnerConeAngle");
        OuterConeAngle_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "OuterConeAngle");
        AttenuationRadius_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AttenuationRadius");
        SourceRadius_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SourceRadius");
        SoftSourceRadius_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SoftSourceRadius");
        SourceLength_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SourceLength");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public LiveLinkLightFrameData(IntPtr InNativeStruct)
    {
        unsafe
        {
            Temperature = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Temperature_Offset), 0, null);
            Intensity = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Intensity_Offset), 0, null);
            LightColor = BlittableMarshaller<UnrealSharp.CoreUObject.Color>.FromNative(IntPtr.Add(InNativeStruct, LightColor_Offset), 0, null);
            InnerConeAngle = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, InnerConeAngle_Offset), 0, null);
            OuterConeAngle = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, OuterConeAngle_Offset), 0, null);
            AttenuationRadius = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, AttenuationRadius_Offset), 0, null);
            SourceRadius = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, SourceRadius_Offset), 0, null);
            SoftSourceRadius = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, SoftSourceRadius_Offset), 0, null);
            SourceLength = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, SourceLength_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Temperature_Offset), 0, null, Temperature);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Intensity_Offset), 0, null, Intensity);
            BlittableMarshaller<UnrealSharp.CoreUObject.Color>.ToNative(IntPtr.Add(Buffer, LightColor_Offset), 0, null, LightColor);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, InnerConeAngle_Offset), 0, null, InnerConeAngle);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, OuterConeAngle_Offset), 0, null, OuterConeAngle);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, AttenuationRadius_Offset), 0, null, AttenuationRadius);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, SourceRadius_Offset), 0, null, SourceRadius);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, SoftSourceRadius_Offset), 0, null, SoftSourceRadius);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, SourceLength_Offset), 0, null, SourceLength);
        }
    }
}

public static class LiveLinkLightFrameDataMarshaler
{
    public static LiveLinkLightFrameData FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new LiveLinkLightFrameData(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, LiveLinkLightFrameData obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return LiveLinkLightFrameData.NativeDataSize;
    }
}