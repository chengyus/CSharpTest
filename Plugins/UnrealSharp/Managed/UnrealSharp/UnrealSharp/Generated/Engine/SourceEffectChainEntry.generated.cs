using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct SourceEffectChainEntry
{
    // ObjectProperty /Script/Engine.SourceEffectChainEntry:Preset
    static readonly int Preset_Offset;
    public UnrealSharp.Engine.SoundEffectSourcePreset Preset;
    
    // BoolProperty /Script/Engine.SourceEffectChainEntry:bBypass
    static readonly int bBypass_Offset;
    static readonly IntPtr bBypass_NativeProperty;
    public bool Bypass;
    
    
    public static readonly int NativeDataSize;
    static SourceEffectChainEntry()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("SourceEffectChainEntry");
        
        Preset_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Preset");
        bBypass_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bBypass");
        bBypass_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bBypass");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public SourceEffectChainEntry(IntPtr InNativeStruct)
    {
        unsafe
        {
            Preset = ObjectMarshaller<UnrealSharp.Engine.SoundEffectSourcePreset>.FromNative(IntPtr.Add(InNativeStruct, Preset_Offset), 0, null);
            Bypass = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bBypass_NativeProperty, bBypass_Offset);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            ObjectMarshaller<UnrealSharp.Engine.SoundEffectSourcePreset>.ToNative(IntPtr.Add(Buffer, Preset_Offset), 0, null, Preset);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bBypass_NativeProperty, bBypass_Offset, Bypass);
        }
    }
}

public static class SourceEffectChainEntryMarshaler
{
    public static SourceEffectChainEntry FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new SourceEffectChainEntry(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, SourceEffectChainEntry obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return SourceEffectChainEntry.NativeDataSize;
    }
}