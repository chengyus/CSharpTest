using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Synthesis;

[UStruct]
public partial struct SourceEffectFilterSettings
{
    // EnumProperty /Script/Synthesis.SourceEffectFilterSettings:FilterCircuit
    static readonly int FilterCircuit_Offset;
    public UnrealSharp.Synthesis.ESourceEffectFilterCircuit FilterCircuit;
    
    // EnumProperty /Script/Synthesis.SourceEffectFilterSettings:FilterType
    static readonly int FilterType_Offset;
    public UnrealSharp.Synthesis.ESourceEffectFilterType FilterType;
    
    // FloatProperty /Script/Synthesis.SourceEffectFilterSettings:CutoffFrequency
    static readonly int CutoffFrequency_Offset;
    public float CutoffFrequency;
    
    // FloatProperty /Script/Synthesis.SourceEffectFilterSettings:FilterQ
    static readonly int FilterQ_Offset;
    public float FilterQ;
    
    
    public static readonly int NativeDataSize;
    static SourceEffectFilterSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("SourceEffectFilterSettings");
        
        FilterCircuit_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FilterCircuit");
        FilterType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FilterType");
        CutoffFrequency_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CutoffFrequency");
        FilterQ_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FilterQ");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public SourceEffectFilterSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            FilterCircuit = BlittableMarshaller<UnrealSharp.Synthesis.ESourceEffectFilterCircuit>.FromNative(IntPtr.Add(InNativeStruct, FilterCircuit_Offset), 0, null);
            FilterType = BlittableMarshaller<UnrealSharp.Synthesis.ESourceEffectFilterType>.FromNative(IntPtr.Add(InNativeStruct, FilterType_Offset), 0, null);
            CutoffFrequency = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, CutoffFrequency_Offset), 0, null);
            FilterQ = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, FilterQ_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.Synthesis.ESourceEffectFilterCircuit>.ToNative(IntPtr.Add(Buffer, FilterCircuit_Offset), 0, null, FilterCircuit);
            BlittableMarshaller<UnrealSharp.Synthesis.ESourceEffectFilterType>.ToNative(IntPtr.Add(Buffer, FilterType_Offset), 0, null, FilterType);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, CutoffFrequency_Offset), 0, null, CutoffFrequency);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, FilterQ_Offset), 0, null, FilterQ);
        }
    }
}

public static class SourceEffectFilterSettingsMarshaler
{
    public static SourceEffectFilterSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new SourceEffectFilterSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, SourceEffectFilterSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return SourceEffectFilterSettings.NativeDataSize;
    }
}