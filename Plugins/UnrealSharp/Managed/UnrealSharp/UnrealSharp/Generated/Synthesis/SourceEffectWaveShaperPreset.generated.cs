// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Synthesis;

[UClass]
public partial class SourceEffectWaveShaperPreset : UnrealSharp.Engine.SoundEffectSourcePreset
{
    
    static SourceEffectWaveShaperPreset()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("SourceEffectWaveShaperPreset");
        
        Settings_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Settings");
        
        SetSettings_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetSettings");
        SetSettings_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetSettings_NativeFunction);
        SetSettings_InSettings_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetSettings_NativeFunction, "InSettings");
        
        
    }
    
    protected SourceEffectWaveShaperPreset(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // StructProperty /Script/Synthesis.SourceEffectWaveShaperPreset:Settings
    static readonly int Settings_Offset;
    
    public UnrealSharp.Synthesis.SourceEffectWaveShaperSettings Settings
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<UnrealSharp.Synthesis.SourceEffectWaveShaperSettings>.FromNative(IntPtr.Add(NativeObject, Settings_Offset), 0, this);
        }
    }
    
    // Function /Script/Synthesis.SourceEffectWaveShaperPreset:SetSettings
    static readonly IntPtr SetSettings_NativeFunction;
    static readonly int SetSettings_ParamsSize;
    static readonly int SetSettings_InSettings_Offset;
    
    public void SetSettings(UnrealSharp.Synthesis.SourceEffectWaveShaperSettings inSettings)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetSettings_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<UnrealSharp.Synthesis.SourceEffectWaveShaperSettings>.ToNative(IntPtr.Add(ParamsBuffer, SetSettings_InSettings_Offset), 0, null, inSettings);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetSettings_NativeFunction, ParamsBuffer);
            
            
        }
    }
    
    
}