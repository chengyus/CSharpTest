// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AudioMixer;

[UClass]
public partial class SubmixEffectSubmixEQPreset : UnrealSharp.Engine.SoundEffectSubmixPreset
{
    
    static SubmixEffectSubmixEQPreset()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("SubmixEffectSubmixEQPreset");
        
        Settings_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Settings");
        
        SetSettings_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetSettings");
        SetSettings_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetSettings_NativeFunction);
        SetSettings_InSettings_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetSettings_NativeFunction, "InSettings");
        
        
    }
    
    protected SubmixEffectSubmixEQPreset(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // StructProperty /Script/AudioMixer.SubmixEffectSubmixEQPreset:Settings
    static readonly int Settings_Offset;
    
    public UnrealSharp.AudioMixer.SubmixEffectSubmixEQSettings Settings
    {
        get
        {
            CheckObjectForValidity();
            return UnrealSharp.AudioMixer.SubmixEffectSubmixEQSettingsMarshaler.FromNative(IntPtr.Add(NativeObject, Settings_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            UnrealSharp.AudioMixer.SubmixEffectSubmixEQSettingsMarshaler.ToNative(IntPtr.Add(NativeObject, Settings_Offset), 0, this, value);
        }
    }
    
    // Function /Script/AudioMixer.SubmixEffectSubmixEQPreset:SetSettings
    static readonly IntPtr SetSettings_NativeFunction;
    static readonly int SetSettings_ParamsSize;
    static readonly int SetSettings_InSettings_Offset;
    
    public void SetSettings(UnrealSharp.AudioMixer.SubmixEffectSubmixEQSettings inSettings)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetSettings_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            UnrealSharp.AudioMixer.SubmixEffectSubmixEQSettingsMarshaler.ToNative(IntPtr.Add(ParamsBuffer, SetSettings_InSettings_Offset), 0, null, inSettings);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetSettings_NativeFunction, ParamsBuffer);
            
            
        }
    }
    
    
}