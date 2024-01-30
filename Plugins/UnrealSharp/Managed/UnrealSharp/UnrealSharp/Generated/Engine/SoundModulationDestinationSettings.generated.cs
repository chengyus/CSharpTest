using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct SoundModulationDestinationSettings
{
    // FloatProperty /Script/Engine.SoundModulationDestinationSettings:Value
    static readonly int Value_Offset;
    public float Value;
    
    // ObjectProperty /Script/Engine.SoundModulationDestinationSettings:Modulator
    static readonly int Modulator_Offset;
    public UnrealSharp.AudioExtensions.SoundModulatorBase Modulator;
    
    
    public static readonly int NativeDataSize;
    static SoundModulationDestinationSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("SoundModulationDestinationSettings");
        
        Value_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Value");
        Modulator_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Modulator");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public SoundModulationDestinationSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            Value = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Value_Offset), 0, null);
            Modulator = ObjectMarshaller<UnrealSharp.AudioExtensions.SoundModulatorBase>.FromNative(IntPtr.Add(InNativeStruct, Modulator_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Value_Offset), 0, null, Value);
            ObjectMarshaller<UnrealSharp.AudioExtensions.SoundModulatorBase>.ToNative(IntPtr.Add(Buffer, Modulator_Offset), 0, null, Modulator);
        }
    }
}

public static class SoundModulationDestinationSettingsMarshaler
{
    public static SoundModulationDestinationSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new SoundModulationDestinationSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, SoundModulationDestinationSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return SoundModulationDestinationSettings.NativeDataSize;
    }
}