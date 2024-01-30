using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct SoundModulationDefaultSettings
{
    // StructProperty /Script/Engine.SoundModulationDefaultSettings:VolumeModulationDestination
    static readonly int VolumeModulationDestination_Offset;
    public UnrealSharp.Engine.SoundModulationDestinationSettings VolumeModulationDestination;
    
    // StructProperty /Script/Engine.SoundModulationDefaultSettings:PitchModulationDestination
    static readonly int PitchModulationDestination_Offset;
    public UnrealSharp.Engine.SoundModulationDestinationSettings PitchModulationDestination;
    
    // StructProperty /Script/Engine.SoundModulationDefaultSettings:HighpassModulationDestination
    static readonly int HighpassModulationDestination_Offset;
    public UnrealSharp.Engine.SoundModulationDestinationSettings HighpassModulationDestination;
    
    // StructProperty /Script/Engine.SoundModulationDefaultSettings:LowpassModulationDestination
    static readonly int LowpassModulationDestination_Offset;
    public UnrealSharp.Engine.SoundModulationDestinationSettings LowpassModulationDestination;
    
    
    public static readonly int NativeDataSize;
    static SoundModulationDefaultSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("SoundModulationDefaultSettings");
        
        VolumeModulationDestination_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "VolumeModulationDestination");
        PitchModulationDestination_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PitchModulationDestination");
        HighpassModulationDestination_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "HighpassModulationDestination");
        LowpassModulationDestination_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LowpassModulationDestination");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public SoundModulationDefaultSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            VolumeModulationDestination = UnrealSharp.Engine.SoundModulationDestinationSettingsMarshaler.FromNative(IntPtr.Add(InNativeStruct, VolumeModulationDestination_Offset), 0, null);
            PitchModulationDestination = UnrealSharp.Engine.SoundModulationDestinationSettingsMarshaler.FromNative(IntPtr.Add(InNativeStruct, PitchModulationDestination_Offset), 0, null);
            HighpassModulationDestination = UnrealSharp.Engine.SoundModulationDestinationSettingsMarshaler.FromNative(IntPtr.Add(InNativeStruct, HighpassModulationDestination_Offset), 0, null);
            LowpassModulationDestination = UnrealSharp.Engine.SoundModulationDestinationSettingsMarshaler.FromNative(IntPtr.Add(InNativeStruct, LowpassModulationDestination_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.Engine.SoundModulationDestinationSettingsMarshaler.ToNative(IntPtr.Add(Buffer, VolumeModulationDestination_Offset), 0, null, VolumeModulationDestination);
            UnrealSharp.Engine.SoundModulationDestinationSettingsMarshaler.ToNative(IntPtr.Add(Buffer, PitchModulationDestination_Offset), 0, null, PitchModulationDestination);
            UnrealSharp.Engine.SoundModulationDestinationSettingsMarshaler.ToNative(IntPtr.Add(Buffer, HighpassModulationDestination_Offset), 0, null, HighpassModulationDestination);
            UnrealSharp.Engine.SoundModulationDestinationSettingsMarshaler.ToNative(IntPtr.Add(Buffer, LowpassModulationDestination_Offset), 0, null, LowpassModulationDestination);
        }
    }
}

public static class SoundModulationDefaultSettingsMarshaler
{
    public static SoundModulationDefaultSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new SoundModulationDefaultSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, SoundModulationDefaultSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return SoundModulationDefaultSettings.NativeDataSize;
    }
}