// This file is automatically generated
using UnrealSharp.MovieScene;
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.MovieSceneTracks;

[UClass]
public partial class MovieSceneAudioSection : UnrealSharp.MovieScene.MovieSceneSection, IMovieSceneEntityProvider
{
    
    static MovieSceneAudioSection()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("MovieSceneAudioSection");
        
        Sound_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Sound");
        
        SetSuppressSubtitles_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetSuppressSubtitles");
        SetSuppressSubtitles_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetSuppressSubtitles_NativeFunction);
        SetSuppressSubtitles_bInSuppressSubtitles_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetSuppressSubtitles_NativeFunction, "bInSuppressSubtitles");
        SetStartOffset_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetStartOffset");
        SetStartOffset_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetStartOffset_NativeFunction);
        SetStartOffset_InStartOffset_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetStartOffset_NativeFunction, "InStartOffset");
        SetSound_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetSound");
        SetSound_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetSound_NativeFunction);
        SetSound_InSound_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetSound_NativeFunction, "InSound");
        SetOverrideAttenuation_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetOverrideAttenuation");
        SetOverrideAttenuation_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetOverrideAttenuation_NativeFunction);
        SetOverrideAttenuation_bInOverrideAttenuation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetOverrideAttenuation_NativeFunction, "bInOverrideAttenuation");
        SetLooping_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetLooping");
        SetLooping_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetLooping_NativeFunction);
        SetLooping_bInLooping_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetLooping_NativeFunction, "bInLooping");
        SetAttenuationSettings_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetAttenuationSettings");
        SetAttenuationSettings_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetAttenuationSettings_NativeFunction);
        SetAttenuationSettings_InAttenuationSettings_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetAttenuationSettings_NativeFunction, "InAttenuationSettings");
        GetSuppressSubtitles_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetSuppressSubtitles");
        GetSuppressSubtitles_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetSuppressSubtitles_NativeFunction);
        GetSuppressSubtitles_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetSuppressSubtitles_NativeFunction, "ReturnValue");
        GetStartOffset_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetStartOffset");
        GetStartOffset_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetStartOffset_NativeFunction);
        GetStartOffset_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetStartOffset_NativeFunction, "ReturnValue");
        GetSound_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetSound");
        GetSound_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetSound_NativeFunction);
        GetSound_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetSound_NativeFunction, "ReturnValue");
        GetOverrideAttenuation_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetOverrideAttenuation");
        GetOverrideAttenuation_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetOverrideAttenuation_NativeFunction);
        GetOverrideAttenuation_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetOverrideAttenuation_NativeFunction, "ReturnValue");
        GetLooping_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetLooping");
        GetLooping_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetLooping_NativeFunction);
        GetLooping_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetLooping_NativeFunction, "ReturnValue");
        GetAttenuationSettings_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetAttenuationSettings");
        GetAttenuationSettings_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetAttenuationSettings_NativeFunction);
        GetAttenuationSettings_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetAttenuationSettings_NativeFunction, "ReturnValue");
        
        
    }
    
    protected MovieSceneAudioSection(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // ObjectProperty /Script/MovieSceneTracks.MovieSceneAudioSection:Sound
    static readonly int Sound_Offset;
    
    public UnrealSharp.Engine.SoundBase Sound
    {
        get
        {
            CheckObjectForValidity();
            return ObjectMarshaller<UnrealSharp.Engine.SoundBase>.FromNative(IntPtr.Add(NativeObject, Sound_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            ObjectMarshaller<UnrealSharp.Engine.SoundBase>.ToNative(IntPtr.Add(NativeObject, Sound_Offset), 0, this, value);
        }
    }
    
    // Function /Script/MovieSceneTracks.MovieSceneAudioSection:SetSuppressSubtitles
    static readonly IntPtr SetSuppressSubtitles_NativeFunction;
    static readonly int SetSuppressSubtitles_ParamsSize;
    static readonly int SetSuppressSubtitles_bInSuppressSubtitles_Offset;
    
    public void SetSuppressSubtitles(bool bInSuppressSubtitles)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetSuppressSubtitles_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, SetSuppressSubtitles_bInSuppressSubtitles_Offset), 0, null, bInSuppressSubtitles);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetSuppressSubtitles_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/MovieSceneTracks.MovieSceneAudioSection:SetStartOffset
    static readonly IntPtr SetStartOffset_NativeFunction;
    static readonly int SetStartOffset_ParamsSize;
    static readonly int SetStartOffset_InStartOffset_Offset;
    
    public void SetStartOffset(UnrealSharp.CoreUObject.FrameNumber inStartOffset)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetStartOffset_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<UnrealSharp.CoreUObject.FrameNumber>.ToNative(IntPtr.Add(ParamsBuffer, SetStartOffset_InStartOffset_Offset), 0, null, inStartOffset);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetStartOffset_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/MovieSceneTracks.MovieSceneAudioSection:SetSound
    static readonly IntPtr SetSound_NativeFunction;
    static readonly int SetSound_ParamsSize;
    static readonly int SetSound_InSound_Offset;
    
    public void SetSound(UnrealSharp.Engine.SoundBase inSound)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetSound_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.Engine.SoundBase>.ToNative(IntPtr.Add(ParamsBuffer, SetSound_InSound_Offset), 0, null, inSound);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetSound_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/MovieSceneTracks.MovieSceneAudioSection:SetOverrideAttenuation
    static readonly IntPtr SetOverrideAttenuation_NativeFunction;
    static readonly int SetOverrideAttenuation_ParamsSize;
    static readonly int SetOverrideAttenuation_bInOverrideAttenuation_Offset;
    
    public void SetOverrideAttenuation(bool bInOverrideAttenuation)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetOverrideAttenuation_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, SetOverrideAttenuation_bInOverrideAttenuation_Offset), 0, null, bInOverrideAttenuation);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetOverrideAttenuation_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/MovieSceneTracks.MovieSceneAudioSection:SetLooping
    static readonly IntPtr SetLooping_NativeFunction;
    static readonly int SetLooping_ParamsSize;
    static readonly int SetLooping_bInLooping_Offset;
    
    public void SetLooping(bool bInLooping)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetLooping_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, SetLooping_bInLooping_Offset), 0, null, bInLooping);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetLooping_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/MovieSceneTracks.MovieSceneAudioSection:SetAttenuationSettings
    static readonly IntPtr SetAttenuationSettings_NativeFunction;
    static readonly int SetAttenuationSettings_ParamsSize;
    static readonly int SetAttenuationSettings_InAttenuationSettings_Offset;
    
    public void SetAttenuationSettings(UnrealSharp.Engine.SoundAttenuation inAttenuationSettings)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetAttenuationSettings_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.Engine.SoundAttenuation>.ToNative(IntPtr.Add(ParamsBuffer, SetAttenuationSettings_InAttenuationSettings_Offset), 0, null, inAttenuationSettings);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetAttenuationSettings_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/MovieSceneTracks.MovieSceneAudioSection:GetSuppressSubtitles
    static readonly IntPtr GetSuppressSubtitles_NativeFunction;
    static readonly int GetSuppressSubtitles_ParamsSize;
    static readonly int GetSuppressSubtitles_ReturnValue_Offset;
    
    public bool GetSuppressSubtitles()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetSuppressSubtitles_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetSuppressSubtitles_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, GetSuppressSubtitles_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/MovieSceneTracks.MovieSceneAudioSection:GetStartOffset
    static readonly IntPtr GetStartOffset_NativeFunction;
    static readonly int GetStartOffset_ParamsSize;
    static readonly int GetStartOffset_ReturnValue_Offset;
    
    public UnrealSharp.CoreUObject.FrameNumber GetStartOffset()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetStartOffset_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetStartOffset_NativeFunction, ParamsBuffer);
            
            UnrealSharp.CoreUObject.FrameNumber returnValue;
            returnValue = BlittableMarshaller<UnrealSharp.CoreUObject.FrameNumber>.FromNative(IntPtr.Add(ParamsBuffer, GetStartOffset_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/MovieSceneTracks.MovieSceneAudioSection:GetSound
    static readonly IntPtr GetSound_NativeFunction;
    static readonly int GetSound_ParamsSize;
    static readonly int GetSound_ReturnValue_Offset;
    
    public UnrealSharp.Engine.SoundBase GetSound()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetSound_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetSound_NativeFunction, ParamsBuffer);
            
            UnrealSharp.Engine.SoundBase returnValue;
            returnValue = ObjectMarshaller<UnrealSharp.Engine.SoundBase>.FromNative(IntPtr.Add(ParamsBuffer, GetSound_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/MovieSceneTracks.MovieSceneAudioSection:GetOverrideAttenuation
    static readonly IntPtr GetOverrideAttenuation_NativeFunction;
    static readonly int GetOverrideAttenuation_ParamsSize;
    static readonly int GetOverrideAttenuation_ReturnValue_Offset;
    
    public bool GetOverrideAttenuation()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetOverrideAttenuation_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetOverrideAttenuation_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, GetOverrideAttenuation_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/MovieSceneTracks.MovieSceneAudioSection:GetLooping
    static readonly IntPtr GetLooping_NativeFunction;
    static readonly int GetLooping_ParamsSize;
    static readonly int GetLooping_ReturnValue_Offset;
    
    public bool GetLooping()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetLooping_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetLooping_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, GetLooping_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/MovieSceneTracks.MovieSceneAudioSection:GetAttenuationSettings
    static readonly IntPtr GetAttenuationSettings_NativeFunction;
    static readonly int GetAttenuationSettings_ParamsSize;
    static readonly int GetAttenuationSettings_ReturnValue_Offset;
    
    public UnrealSharp.Engine.SoundAttenuation GetAttenuationSettings()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetAttenuationSettings_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetAttenuationSettings_NativeFunction, ParamsBuffer);
            
            UnrealSharp.Engine.SoundAttenuation returnValue;
            returnValue = ObjectMarshaller<UnrealSharp.Engine.SoundAttenuation>.FromNative(IntPtr.Add(ParamsBuffer, GetAttenuationSettings_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    
}