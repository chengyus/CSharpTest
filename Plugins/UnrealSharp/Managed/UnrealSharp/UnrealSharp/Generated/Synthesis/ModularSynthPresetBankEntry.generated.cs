using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Synthesis;

[UStruct]
public partial struct ModularSynthPresetBankEntry
{
    // StructProperty /Script/Synthesis.ModularSynthPresetBankEntry:Preset
    static readonly int Preset_Offset;
    public UnrealSharp.Synthesis.ModularSynthPreset Preset;
    
    
    public static readonly int NativeDataSize;
    static ModularSynthPresetBankEntry()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("ModularSynthPresetBankEntry");
        
        Preset_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Preset");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public ModularSynthPresetBankEntry(IntPtr InNativeStruct)
    {
        unsafe
        {
            Preset = UnrealSharp.Synthesis.ModularSynthPresetMarshaler.FromNative(IntPtr.Add(InNativeStruct, Preset_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.Synthesis.ModularSynthPresetMarshaler.ToNative(IntPtr.Add(Buffer, Preset_Offset), 0, null, Preset);
        }
    }
}

public static class ModularSynthPresetBankEntryMarshaler
{
    public static ModularSynthPresetBankEntry FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new ModularSynthPresetBankEntry(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, ModularSynthPresetBankEntry obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return ModularSynthPresetBankEntry.NativeDataSize;
    }
}