using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct SoundModulationDefaultRoutingSettings
{
    // EnumProperty /Script/Engine.SoundModulationDefaultRoutingSettings:VolumeRouting
    static readonly int VolumeRouting_Offset;
    public UnrealSharp.Engine.EModulationRouting VolumeRouting;
    
    // EnumProperty /Script/Engine.SoundModulationDefaultRoutingSettings:PitchRouting
    static readonly int PitchRouting_Offset;
    public UnrealSharp.Engine.EModulationRouting PitchRouting;
    
    // EnumProperty /Script/Engine.SoundModulationDefaultRoutingSettings:HighpassRouting
    static readonly int HighpassRouting_Offset;
    public UnrealSharp.Engine.EModulationRouting HighpassRouting;
    
    // EnumProperty /Script/Engine.SoundModulationDefaultRoutingSettings:LowpassRouting
    static readonly int LowpassRouting_Offset;
    public UnrealSharp.Engine.EModulationRouting LowpassRouting;
    
    
    public static readonly int NativeDataSize;
    static SoundModulationDefaultRoutingSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("SoundModulationDefaultRoutingSettings");
        
        VolumeRouting_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "VolumeRouting");
        PitchRouting_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PitchRouting");
        HighpassRouting_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "HighpassRouting");
        LowpassRouting_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LowpassRouting");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public SoundModulationDefaultRoutingSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            VolumeRouting = BlittableMarshaller<UnrealSharp.Engine.EModulationRouting>.FromNative(IntPtr.Add(InNativeStruct, VolumeRouting_Offset), 0, null);
            PitchRouting = BlittableMarshaller<UnrealSharp.Engine.EModulationRouting>.FromNative(IntPtr.Add(InNativeStruct, PitchRouting_Offset), 0, null);
            HighpassRouting = BlittableMarshaller<UnrealSharp.Engine.EModulationRouting>.FromNative(IntPtr.Add(InNativeStruct, HighpassRouting_Offset), 0, null);
            LowpassRouting = BlittableMarshaller<UnrealSharp.Engine.EModulationRouting>.FromNative(IntPtr.Add(InNativeStruct, LowpassRouting_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.Engine.EModulationRouting>.ToNative(IntPtr.Add(Buffer, VolumeRouting_Offset), 0, null, VolumeRouting);
            BlittableMarshaller<UnrealSharp.Engine.EModulationRouting>.ToNative(IntPtr.Add(Buffer, PitchRouting_Offset), 0, null, PitchRouting);
            BlittableMarshaller<UnrealSharp.Engine.EModulationRouting>.ToNative(IntPtr.Add(Buffer, HighpassRouting_Offset), 0, null, HighpassRouting);
            BlittableMarshaller<UnrealSharp.Engine.EModulationRouting>.ToNative(IntPtr.Add(Buffer, LowpassRouting_Offset), 0, null, LowpassRouting);
        }
    }
}

public static class SoundModulationDefaultRoutingSettingsMarshaler
{
    public static SoundModulationDefaultRoutingSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new SoundModulationDefaultRoutingSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, SoundModulationDefaultRoutingSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return SoundModulationDefaultRoutingSettings.NativeDataSize;
    }
}