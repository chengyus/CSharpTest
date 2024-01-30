using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct ColorGradingSettings
{
    // StructProperty /Script/Engine.ColorGradingSettings:Global
    static readonly int Global_Offset;
    public UnrealSharp.Engine.ColorGradePerRangeSettings Global;
    
    // StructProperty /Script/Engine.ColorGradingSettings:Shadows
    static readonly int Shadows_Offset;
    public UnrealSharp.Engine.ColorGradePerRangeSettings Shadows;
    
    // StructProperty /Script/Engine.ColorGradingSettings:Midtones
    static readonly int Midtones_Offset;
    public UnrealSharp.Engine.ColorGradePerRangeSettings Midtones;
    
    // StructProperty /Script/Engine.ColorGradingSettings:Highlights
    static readonly int Highlights_Offset;
    public UnrealSharp.Engine.ColorGradePerRangeSettings Highlights;
    
    // FloatProperty /Script/Engine.ColorGradingSettings:ShadowsMax
    static readonly int ShadowsMax_Offset;
    public float ShadowsMax;
    
    // FloatProperty /Script/Engine.ColorGradingSettings:HighlightsMin
    static readonly int HighlightsMin_Offset;
    public float HighlightsMin;
    
    // FloatProperty /Script/Engine.ColorGradingSettings:HighlightsMax
    static readonly int HighlightsMax_Offset;
    public float HighlightsMax;
    
    
    public static readonly int NativeDataSize;
    static ColorGradingSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("ColorGradingSettings");
        
        Global_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Global");
        Shadows_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Shadows");
        Midtones_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Midtones");
        Highlights_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Highlights");
        ShadowsMax_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ShadowsMax");
        HighlightsMin_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "HighlightsMin");
        HighlightsMax_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "HighlightsMax");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public ColorGradingSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            Global = BlittableMarshaller<UnrealSharp.Engine.ColorGradePerRangeSettings>.FromNative(IntPtr.Add(InNativeStruct, Global_Offset), 0, null);
            Shadows = BlittableMarshaller<UnrealSharp.Engine.ColorGradePerRangeSettings>.FromNative(IntPtr.Add(InNativeStruct, Shadows_Offset), 0, null);
            Midtones = BlittableMarshaller<UnrealSharp.Engine.ColorGradePerRangeSettings>.FromNative(IntPtr.Add(InNativeStruct, Midtones_Offset), 0, null);
            Highlights = BlittableMarshaller<UnrealSharp.Engine.ColorGradePerRangeSettings>.FromNative(IntPtr.Add(InNativeStruct, Highlights_Offset), 0, null);
            ShadowsMax = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ShadowsMax_Offset), 0, null);
            HighlightsMin = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, HighlightsMin_Offset), 0, null);
            HighlightsMax = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, HighlightsMax_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.Engine.ColorGradePerRangeSettings>.ToNative(IntPtr.Add(Buffer, Global_Offset), 0, null, Global);
            BlittableMarshaller<UnrealSharp.Engine.ColorGradePerRangeSettings>.ToNative(IntPtr.Add(Buffer, Shadows_Offset), 0, null, Shadows);
            BlittableMarshaller<UnrealSharp.Engine.ColorGradePerRangeSettings>.ToNative(IntPtr.Add(Buffer, Midtones_Offset), 0, null, Midtones);
            BlittableMarshaller<UnrealSharp.Engine.ColorGradePerRangeSettings>.ToNative(IntPtr.Add(Buffer, Highlights_Offset), 0, null, Highlights);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ShadowsMax_Offset), 0, null, ShadowsMax);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, HighlightsMin_Offset), 0, null, HighlightsMin);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, HighlightsMax_Offset), 0, null, HighlightsMax);
        }
    }
}

public static class ColorGradingSettingsMarshaler
{
    public static ColorGradingSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new ColorGradingSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, ColorGradingSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return ColorGradingSettings.NativeDataSize;
    }
}