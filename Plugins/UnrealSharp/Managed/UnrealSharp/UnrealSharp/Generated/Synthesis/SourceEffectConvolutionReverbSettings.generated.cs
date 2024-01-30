using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Synthesis;

[UStruct]
public partial struct SourceEffectConvolutionReverbSettings
{
    // FloatProperty /Script/Synthesis.SourceEffectConvolutionReverbSettings:WetVolumeDb
    static readonly int WetVolumeDb_Offset;
    public float WetVolumeDb;
    
    // FloatProperty /Script/Synthesis.SourceEffectConvolutionReverbSettings:DryVolumeDb
    static readonly int DryVolumeDb_Offset;
    public float DryVolumeDb;
    
    // BoolProperty /Script/Synthesis.SourceEffectConvolutionReverbSettings:bBypass
    static readonly int bBypass_Offset;
    public bool Bypass;
    
    
    public static readonly int NativeDataSize;
    static SourceEffectConvolutionReverbSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("SourceEffectConvolutionReverbSettings");
        
        WetVolumeDb_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "WetVolumeDb");
        DryVolumeDb_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DryVolumeDb");
        bBypass_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bBypass");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public SourceEffectConvolutionReverbSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            WetVolumeDb = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, WetVolumeDb_Offset), 0, null);
            DryVolumeDb = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, DryVolumeDb_Offset), 0, null);
            Bypass = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bBypass_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, WetVolumeDb_Offset), 0, null, WetVolumeDb);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, DryVolumeDb_Offset), 0, null, DryVolumeDb);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bBypass_Offset), 0, null, Bypass);
        }
    }
}

public static class SourceEffectConvolutionReverbSettingsMarshaler
{
    public static SourceEffectConvolutionReverbSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new SourceEffectConvolutionReverbSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, SourceEffectConvolutionReverbSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return SourceEffectConvolutionReverbSettings.NativeDataSize;
    }
}