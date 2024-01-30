using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct VoiceSettings
{
    // ObjectProperty /Script/Engine.VoiceSettings:ComponentToAttachTo
    static readonly int ComponentToAttachTo_Offset;
    public UnrealSharp.Engine.SceneComponent ComponentToAttachTo;
    
    // ObjectProperty /Script/Engine.VoiceSettings:AttenuationSettings
    static readonly int AttenuationSettings_Offset;
    public UnrealSharp.Engine.SoundAttenuation AttenuationSettings;
    
    // ObjectProperty /Script/Engine.VoiceSettings:SourceEffectChain
    static readonly int SourceEffectChain_Offset;
    public UnrealSharp.Engine.SoundEffectSourcePresetChain SourceEffectChain;
    
    
    public static readonly int NativeDataSize;
    static VoiceSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("VoiceSettings");
        
        ComponentToAttachTo_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ComponentToAttachTo");
        AttenuationSettings_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AttenuationSettings");
        SourceEffectChain_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SourceEffectChain");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public VoiceSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            ComponentToAttachTo = ObjectMarshaller<UnrealSharp.Engine.SceneComponent>.FromNative(IntPtr.Add(InNativeStruct, ComponentToAttachTo_Offset), 0, null);
            AttenuationSettings = ObjectMarshaller<UnrealSharp.Engine.SoundAttenuation>.FromNative(IntPtr.Add(InNativeStruct, AttenuationSettings_Offset), 0, null);
            SourceEffectChain = ObjectMarshaller<UnrealSharp.Engine.SoundEffectSourcePresetChain>.FromNative(IntPtr.Add(InNativeStruct, SourceEffectChain_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            ObjectMarshaller<UnrealSharp.Engine.SceneComponent>.ToNative(IntPtr.Add(Buffer, ComponentToAttachTo_Offset), 0, null, ComponentToAttachTo);
            ObjectMarshaller<UnrealSharp.Engine.SoundAttenuation>.ToNative(IntPtr.Add(Buffer, AttenuationSettings_Offset), 0, null, AttenuationSettings);
            ObjectMarshaller<UnrealSharp.Engine.SoundEffectSourcePresetChain>.ToNative(IntPtr.Add(Buffer, SourceEffectChain_Offset), 0, null, SourceEffectChain);
        }
    }
}

public static class VoiceSettingsMarshaler
{
    public static VoiceSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new VoiceSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, VoiceSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return VoiceSettings.NativeDataSize;
    }
}