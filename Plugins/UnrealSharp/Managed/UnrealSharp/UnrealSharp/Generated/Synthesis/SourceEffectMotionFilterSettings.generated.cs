using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Synthesis;

[UStruct]
public partial struct SourceEffectMotionFilterSettings
{
    // EnumProperty /Script/Synthesis.SourceEffectMotionFilterSettings:MotionFilterTopology
    static readonly int MotionFilterTopology_Offset;
    public UnrealSharp.Synthesis.ESourceEffectMotionFilterTopology MotionFilterTopology;
    
    // FloatProperty /Script/Synthesis.SourceEffectMotionFilterSettings:MotionFilterMix
    static readonly int MotionFilterMix_Offset;
    public float MotionFilterMix;
    
    // StructProperty /Script/Synthesis.SourceEffectMotionFilterSettings:FilterASettings
    static readonly int FilterASettings_Offset;
    public UnrealSharp.Synthesis.SourceEffectIndividualFilterSettings FilterASettings;
    
    // StructProperty /Script/Synthesis.SourceEffectMotionFilterSettings:FilterBSettings
    static readonly int FilterBSettings_Offset;
    public UnrealSharp.Synthesis.SourceEffectIndividualFilterSettings FilterBSettings;
    
    // FloatProperty /Script/Synthesis.SourceEffectMotionFilterSettings:DryVolumeDb
    static readonly int DryVolumeDb_Offset;
    public float DryVolumeDb;
    
    
    public static readonly int NativeDataSize;
    static SourceEffectMotionFilterSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("SourceEffectMotionFilterSettings");
        
        MotionFilterTopology_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MotionFilterTopology");
        MotionFilterMix_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MotionFilterMix");
        FilterASettings_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FilterASettings");
        FilterBSettings_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FilterBSettings");
        DryVolumeDb_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DryVolumeDb");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public SourceEffectMotionFilterSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            MotionFilterTopology = BlittableMarshaller<UnrealSharp.Synthesis.ESourceEffectMotionFilterTopology>.FromNative(IntPtr.Add(InNativeStruct, MotionFilterTopology_Offset), 0, null);
            MotionFilterMix = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MotionFilterMix_Offset), 0, null);
            FilterASettings = UnrealSharp.Synthesis.SourceEffectIndividualFilterSettingsMarshaler.FromNative(IntPtr.Add(InNativeStruct, FilterASettings_Offset), 0, null);
            FilterBSettings = UnrealSharp.Synthesis.SourceEffectIndividualFilterSettingsMarshaler.FromNative(IntPtr.Add(InNativeStruct, FilterBSettings_Offset), 0, null);
            DryVolumeDb = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, DryVolumeDb_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.Synthesis.ESourceEffectMotionFilterTopology>.ToNative(IntPtr.Add(Buffer, MotionFilterTopology_Offset), 0, null, MotionFilterTopology);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MotionFilterMix_Offset), 0, null, MotionFilterMix);
            UnrealSharp.Synthesis.SourceEffectIndividualFilterSettingsMarshaler.ToNative(IntPtr.Add(Buffer, FilterASettings_Offset), 0, null, FilterASettings);
            UnrealSharp.Synthesis.SourceEffectIndividualFilterSettingsMarshaler.ToNative(IntPtr.Add(Buffer, FilterBSettings_Offset), 0, null, FilterBSettings);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, DryVolumeDb_Offset), 0, null, DryVolumeDb);
        }
    }
}

public static class SourceEffectMotionFilterSettingsMarshaler
{
    public static SourceEffectMotionFilterSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new SourceEffectMotionFilterSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, SourceEffectMotionFilterSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return SourceEffectMotionFilterSettings.NativeDataSize;
    }
}