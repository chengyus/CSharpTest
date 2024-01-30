// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AudioMixer;

[UClass]
public partial class SubmixEffectReverbPreset : UnrealSharp.Engine.SoundEffectSubmixPreset
{
    
    static SubmixEffectReverbPreset()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("SubmixEffectReverbPreset");
        
        Settings_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Settings");
        
        SetSettingsWithReverbEffect_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetSettingsWithReverbEffect");
        SetSettingsWithReverbEffect_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetSettingsWithReverbEffect_NativeFunction);
        SetSettingsWithReverbEffect_InReverbEffect_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetSettingsWithReverbEffect_NativeFunction, "InReverbEffect");
        SetSettingsWithReverbEffect_WetLevel_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetSettingsWithReverbEffect_NativeFunction, "WetLevel");
        SetSettingsWithReverbEffect_DryLevel_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetSettingsWithReverbEffect_NativeFunction, "DryLevel");
        SetSettings_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetSettings");
        SetSettings_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetSettings_NativeFunction);
        SetSettings_InSettings_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetSettings_NativeFunction, "InSettings");
        
        
    }
    
    protected SubmixEffectReverbPreset(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // StructProperty /Script/AudioMixer.SubmixEffectReverbPreset:Settings
    static readonly int Settings_Offset;
    
    public UnrealSharp.AudioMixer.SubmixEffectReverbSettings Settings
    {
        get
        {
            CheckObjectForValidity();
            return UnrealSharp.AudioMixer.SubmixEffectReverbSettingsMarshaler.FromNative(IntPtr.Add(NativeObject, Settings_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            UnrealSharp.AudioMixer.SubmixEffectReverbSettingsMarshaler.ToNative(IntPtr.Add(NativeObject, Settings_Offset), 0, this, value);
        }
    }
    
    // Function /Script/AudioMixer.SubmixEffectReverbPreset:SetSettingsWithReverbEffect
    static readonly IntPtr SetSettingsWithReverbEffect_NativeFunction;
    static readonly int SetSettingsWithReverbEffect_ParamsSize;
    static readonly int SetSettingsWithReverbEffect_InReverbEffect_Offset;
    static readonly int SetSettingsWithReverbEffect_WetLevel_Offset;
    static readonly int SetSettingsWithReverbEffect_DryLevel_Offset;
    
    public void SetSettingsWithReverbEffect(UnrealSharp.Engine.ReverbEffect inReverbEffect, float wetLevel, float dryLevel = 0.000000f)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetSettingsWithReverbEffect_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.Engine.ReverbEffect>.ToNative(IntPtr.Add(ParamsBuffer, SetSettingsWithReverbEffect_InReverbEffect_Offset), 0, null, inReverbEffect);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, SetSettingsWithReverbEffect_WetLevel_Offset), 0, null, wetLevel);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, SetSettingsWithReverbEffect_DryLevel_Offset), 0, null, dryLevel);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetSettingsWithReverbEffect_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/AudioMixer.SubmixEffectReverbPreset:SetSettings
    static readonly IntPtr SetSettings_NativeFunction;
    static readonly int SetSettings_ParamsSize;
    static readonly int SetSettings_InSettings_Offset;
    
    public void SetSettings(UnrealSharp.AudioMixer.SubmixEffectReverbSettings inSettings)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetSettings_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            UnrealSharp.AudioMixer.SubmixEffectReverbSettingsMarshaler.ToNative(IntPtr.Add(ParamsBuffer, SetSettings_InSettings_Offset), 0, null, inSettings);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetSettings_NativeFunction, ParamsBuffer);
            
            
        }
    }
    
    
}