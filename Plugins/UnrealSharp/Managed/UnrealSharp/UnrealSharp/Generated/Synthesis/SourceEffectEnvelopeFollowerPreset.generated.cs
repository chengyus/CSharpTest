// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Synthesis;

[UClass]
public partial class SourceEffectEnvelopeFollowerPreset : UnrealSharp.Engine.SoundEffectSourcePreset
{
    
    static SourceEffectEnvelopeFollowerPreset()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("SourceEffectEnvelopeFollowerPreset");
        
        Settings_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Settings");
        
        UnregisterEnvelopeFollowerListener_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "UnregisterEnvelopeFollowerListener");
        UnregisterEnvelopeFollowerListener_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(UnregisterEnvelopeFollowerListener_NativeFunction);
        UnregisterEnvelopeFollowerListener_EnvelopeFollowerListener_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(UnregisterEnvelopeFollowerListener_NativeFunction, "EnvelopeFollowerListener");
        SetSettings_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetSettings");
        SetSettings_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetSettings_NativeFunction);
        SetSettings_InSettings_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetSettings_NativeFunction, "InSettings");
        RegisterEnvelopeFollowerListener_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "RegisterEnvelopeFollowerListener");
        RegisterEnvelopeFollowerListener_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(RegisterEnvelopeFollowerListener_NativeFunction);
        RegisterEnvelopeFollowerListener_EnvelopeFollowerListener_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(RegisterEnvelopeFollowerListener_NativeFunction, "EnvelopeFollowerListener");
        
        
    }
    
    protected SourceEffectEnvelopeFollowerPreset(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // StructProperty /Script/Synthesis.SourceEffectEnvelopeFollowerPreset:Settings
    static readonly int Settings_Offset;
    
    public UnrealSharp.Synthesis.SourceEffectEnvelopeFollowerSettings Settings
    {
        get
        {
            CheckObjectForValidity();
            return UnrealSharp.Synthesis.SourceEffectEnvelopeFollowerSettingsMarshaler.FromNative(IntPtr.Add(NativeObject, Settings_Offset), 0, this);
        }
    }
    
    // Function /Script/Synthesis.SourceEffectEnvelopeFollowerPreset:UnregisterEnvelopeFollowerListener
    static readonly IntPtr UnregisterEnvelopeFollowerListener_NativeFunction;
    static readonly int UnregisterEnvelopeFollowerListener_ParamsSize;
    static readonly int UnregisterEnvelopeFollowerListener_EnvelopeFollowerListener_Offset;
    
    public void UnregisterEnvelopeFollowerListener(UnrealSharp.Synthesis.EnvelopeFollowerListener envelopeFollowerListener)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[UnregisterEnvelopeFollowerListener_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.Synthesis.EnvelopeFollowerListener>.ToNative(IntPtr.Add(ParamsBuffer, UnregisterEnvelopeFollowerListener_EnvelopeFollowerListener_Offset), 0, null, envelopeFollowerListener);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, UnregisterEnvelopeFollowerListener_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/Synthesis.SourceEffectEnvelopeFollowerPreset:SetSettings
    static readonly IntPtr SetSettings_NativeFunction;
    static readonly int SetSettings_ParamsSize;
    static readonly int SetSettings_InSettings_Offset;
    
    public void SetSettings(UnrealSharp.Synthesis.SourceEffectEnvelopeFollowerSettings inSettings)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetSettings_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            UnrealSharp.Synthesis.SourceEffectEnvelopeFollowerSettingsMarshaler.ToNative(IntPtr.Add(ParamsBuffer, SetSettings_InSettings_Offset), 0, null, inSettings);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetSettings_NativeFunction, ParamsBuffer);
            
            
        }
    }
    
    // Function /Script/Synthesis.SourceEffectEnvelopeFollowerPreset:RegisterEnvelopeFollowerListener
    static readonly IntPtr RegisterEnvelopeFollowerListener_NativeFunction;
    static readonly int RegisterEnvelopeFollowerListener_ParamsSize;
    static readonly int RegisterEnvelopeFollowerListener_EnvelopeFollowerListener_Offset;
    
    public void RegisterEnvelopeFollowerListener(UnrealSharp.Synthesis.EnvelopeFollowerListener envelopeFollowerListener)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[RegisterEnvelopeFollowerListener_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.Synthesis.EnvelopeFollowerListener>.ToNative(IntPtr.Add(ParamsBuffer, RegisterEnvelopeFollowerListener_EnvelopeFollowerListener_Offset), 0, null, envelopeFollowerListener);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, RegisterEnvelopeFollowerListener_NativeFunction, ParamsBuffer);
            
        }
    }
    
    
}