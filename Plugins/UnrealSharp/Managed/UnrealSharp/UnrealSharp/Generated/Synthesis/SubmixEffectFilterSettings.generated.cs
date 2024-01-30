using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Synthesis;

[UStruct]
public partial struct SubmixEffectFilterSettings
{
    // EnumProperty /Script/Synthesis.SubmixEffectFilterSettings:FilterType
    static readonly int FilterType_Offset;
    public UnrealSharp.Synthesis.ESubmixFilterType FilterType;
    
    // EnumProperty /Script/Synthesis.SubmixEffectFilterSettings:FilterAlgorithm
    static readonly int FilterAlgorithm_Offset;
    public UnrealSharp.Synthesis.ESubmixFilterAlgorithm FilterAlgorithm;
    
    // FloatProperty /Script/Synthesis.SubmixEffectFilterSettings:FilterFrequency
    static readonly int FilterFrequency_Offset;
    public float FilterFrequency;
    
    // FloatProperty /Script/Synthesis.SubmixEffectFilterSettings:FilterQ
    static readonly int FilterQ_Offset;
    public float FilterQ;
    
    
    public static readonly int NativeDataSize;
    static SubmixEffectFilterSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("SubmixEffectFilterSettings");
        
        FilterType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FilterType");
        FilterAlgorithm_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FilterAlgorithm");
        FilterFrequency_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FilterFrequency");
        FilterQ_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FilterQ");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public SubmixEffectFilterSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            FilterType = BlittableMarshaller<UnrealSharp.Synthesis.ESubmixFilterType>.FromNative(IntPtr.Add(InNativeStruct, FilterType_Offset), 0, null);
            FilterAlgorithm = BlittableMarshaller<UnrealSharp.Synthesis.ESubmixFilterAlgorithm>.FromNative(IntPtr.Add(InNativeStruct, FilterAlgorithm_Offset), 0, null);
            FilterFrequency = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, FilterFrequency_Offset), 0, null);
            FilterQ = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, FilterQ_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.Synthesis.ESubmixFilterType>.ToNative(IntPtr.Add(Buffer, FilterType_Offset), 0, null, FilterType);
            BlittableMarshaller<UnrealSharp.Synthesis.ESubmixFilterAlgorithm>.ToNative(IntPtr.Add(Buffer, FilterAlgorithm_Offset), 0, null, FilterAlgorithm);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, FilterFrequency_Offset), 0, null, FilterFrequency);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, FilterQ_Offset), 0, null, FilterQ);
        }
    }
}

public static class SubmixEffectFilterSettingsMarshaler
{
    public static SubmixEffectFilterSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new SubmixEffectFilterSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, SubmixEffectFilterSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return SubmixEffectFilterSettings.NativeDataSize;
    }
}