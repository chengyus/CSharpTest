using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Synthesis;

[UStruct]
public partial struct SourceEffectMotionFilterModulationSettings
{
    // EnumProperty /Script/Synthesis.SourceEffectMotionFilterModulationSettings:ModulationSource
    static readonly int ModulationSource_Offset;
    public UnrealSharp.Synthesis.ESourceEffectMotionFilterModSource ModulationSource;
    
    // StructProperty /Script/Synthesis.SourceEffectMotionFilterModulationSettings:ModulationInputRange
    static readonly int ModulationInputRange_Offset;
    public System.DoubleNumerics.Vector2 ModulationInputRange;
    
    // StructProperty /Script/Synthesis.SourceEffectMotionFilterModulationSettings:ModulationOutputMinimumRange
    static readonly int ModulationOutputMinimumRange_Offset;
    public System.DoubleNumerics.Vector2 ModulationOutputMinimumRange;
    
    // StructProperty /Script/Synthesis.SourceEffectMotionFilterModulationSettings:ModulationOutputMaximumRange
    static readonly int ModulationOutputMaximumRange_Offset;
    public System.DoubleNumerics.Vector2 ModulationOutputMaximumRange;
    
    // FloatProperty /Script/Synthesis.SourceEffectMotionFilterModulationSettings:UpdateEaseMS
    static readonly int UpdateEaseMS_Offset;
    public float UpdateEaseMS;
    
    
    public static readonly int NativeDataSize;
    static SourceEffectMotionFilterModulationSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("SourceEffectMotionFilterModulationSettings");
        
        ModulationSource_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ModulationSource");
        ModulationInputRange_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ModulationInputRange");
        ModulationOutputMinimumRange_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ModulationOutputMinimumRange");
        ModulationOutputMaximumRange_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ModulationOutputMaximumRange");
        UpdateEaseMS_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "UpdateEaseMS");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public SourceEffectMotionFilterModulationSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            ModulationSource = BlittableMarshaller<UnrealSharp.Synthesis.ESourceEffectMotionFilterModSource>.FromNative(IntPtr.Add(InNativeStruct, ModulationSource_Offset), 0, null);
            ModulationInputRange = BlittableMarshaller<System.DoubleNumerics.Vector2>.FromNative(IntPtr.Add(InNativeStruct, ModulationInputRange_Offset), 0, null);
            ModulationOutputMinimumRange = BlittableMarshaller<System.DoubleNumerics.Vector2>.FromNative(IntPtr.Add(InNativeStruct, ModulationOutputMinimumRange_Offset), 0, null);
            ModulationOutputMaximumRange = BlittableMarshaller<System.DoubleNumerics.Vector2>.FromNative(IntPtr.Add(InNativeStruct, ModulationOutputMaximumRange_Offset), 0, null);
            UpdateEaseMS = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, UpdateEaseMS_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.Synthesis.ESourceEffectMotionFilterModSource>.ToNative(IntPtr.Add(Buffer, ModulationSource_Offset), 0, null, ModulationSource);
            BlittableMarshaller<System.DoubleNumerics.Vector2>.ToNative(IntPtr.Add(Buffer, ModulationInputRange_Offset), 0, null, ModulationInputRange);
            BlittableMarshaller<System.DoubleNumerics.Vector2>.ToNative(IntPtr.Add(Buffer, ModulationOutputMinimumRange_Offset), 0, null, ModulationOutputMinimumRange);
            BlittableMarshaller<System.DoubleNumerics.Vector2>.ToNative(IntPtr.Add(Buffer, ModulationOutputMaximumRange_Offset), 0, null, ModulationOutputMaximumRange);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, UpdateEaseMS_Offset), 0, null, UpdateEaseMS);
        }
    }
}

public static class SourceEffectMotionFilterModulationSettingsMarshaler
{
    public static SourceEffectMotionFilterModulationSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new SourceEffectMotionFilterModulationSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, SourceEffectMotionFilterModulationSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return SourceEffectMotionFilterModulationSettings.NativeDataSize;
    }
}