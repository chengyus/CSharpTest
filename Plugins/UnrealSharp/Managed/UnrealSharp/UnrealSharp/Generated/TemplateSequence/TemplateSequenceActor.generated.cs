// This file is automatically generated
using UnrealSharp.MovieScene;
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.TemplateSequence;

[UClass]
public partial class TemplateSequenceActor : UnrealSharp.Engine.Actor, IMovieScenePlaybackClient
{
    
    static TemplateSequenceActor()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("TemplateSequenceActor");
        
        PlaybackSettings_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PlaybackSettings");
        SequencePlayer_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SequencePlayer");
        TemplateSequence_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TemplateSequence");
        BindingOverride_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BindingOverride");
        
        SetSequence_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetSequence");
        SetSequence_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetSequence_NativeFunction);
        SetSequence_InSequence_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetSequence_NativeFunction, "InSequence");
        SetBinding_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetBinding");
        SetBinding_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetBinding_NativeFunction);
        SetBinding_Actor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetBinding_NativeFunction, "Actor");
        SetBinding_bOverridesDefault_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetBinding_NativeFunction, "bOverridesDefault");
        LoadSequence_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "LoadSequence");
        LoadSequence_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(LoadSequence_NativeFunction);
        LoadSequence_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(LoadSequence_NativeFunction, "ReturnValue");
        GetSequence_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetSequence");
        GetSequence_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetSequence_NativeFunction);
        GetSequence_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetSequence_NativeFunction, "ReturnValue");
        
        
    }
    
    protected TemplateSequenceActor(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // StructProperty /Script/TemplateSequence.TemplateSequenceActor:PlaybackSettings
    static readonly int PlaybackSettings_Offset;
    
    public UnrealSharp.MovieScene.MovieSceneSequencePlaybackSettings PlaybackSettings
    {
        get
        {
            CheckObjectForValidity();
            return UnrealSharp.MovieScene.MovieSceneSequencePlaybackSettingsMarshaler.FromNative(IntPtr.Add(NativeObject, PlaybackSettings_Offset), 0, this);
        }
    }
    
    // ObjectProperty /Script/TemplateSequence.TemplateSequenceActor:SequencePlayer
    static readonly int SequencePlayer_Offset;
    
    public UnrealSharp.TemplateSequence.TemplateSequencePlayer SequencePlayer
    {
        get
        {
            CheckObjectForValidity();
            return ObjectMarshaller<UnrealSharp.TemplateSequence.TemplateSequencePlayer>.FromNative(IntPtr.Add(NativeObject, SequencePlayer_Offset), 0, this);
        }
    }
    
    // StructProperty /Script/TemplateSequence.TemplateSequenceActor:TemplateSequence
    static readonly int TemplateSequence_Offset;
    
    public UnrealSharp.CoreUObject.SoftObjectPath TemplateSequence
    {
        get
        {
            CheckObjectForValidity();
            return UnrealSharp.CoreUObject.SoftObjectPathMarshaler.FromNative(IntPtr.Add(NativeObject, TemplateSequence_Offset), 0, this);
        }
    }
    
    // StructProperty /Script/TemplateSequence.TemplateSequenceActor:BindingOverride
    static readonly int BindingOverride_Offset;
    
    public UnrealSharp.TemplateSequence.TemplateSequenceBindingOverrideData BindingOverride
    {
        get
        {
            CheckObjectForValidity();
            return UnrealSharp.TemplateSequence.TemplateSequenceBindingOverrideDataMarshaler.FromNative(IntPtr.Add(NativeObject, BindingOverride_Offset), 0, this);
        }
    }
    
    // Function /Script/TemplateSequence.TemplateSequenceActor:SetSequence
    static readonly IntPtr SetSequence_NativeFunction;
    static readonly int SetSequence_ParamsSize;
    static readonly int SetSequence_InSequence_Offset;
    
    public void SetSequence(UnrealSharp.TemplateSequence.TemplateSequence inSequence)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetSequence_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.TemplateSequence.TemplateSequence>.ToNative(IntPtr.Add(ParamsBuffer, SetSequence_InSequence_Offset), 0, null, inSequence);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetSequence_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/TemplateSequence.TemplateSequenceActor:SetBinding
    static readonly IntPtr SetBinding_NativeFunction;
    static readonly int SetBinding_ParamsSize;
    static readonly int SetBinding_Actor_Offset;
    static readonly int SetBinding_bOverridesDefault_Offset;
    
    public void SetBinding(UnrealSharp.Engine.Actor actor, bool bOverridesDefault = true)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetBinding_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.Engine.Actor>.ToNative(IntPtr.Add(ParamsBuffer, SetBinding_Actor_Offset), 0, null, actor);
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, SetBinding_bOverridesDefault_Offset), 0, null, bOverridesDefault);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetBinding_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/TemplateSequence.TemplateSequenceActor:LoadSequence
    static readonly IntPtr LoadSequence_NativeFunction;
    static readonly int LoadSequence_ParamsSize;
    static readonly int LoadSequence_ReturnValue_Offset;
    
    public UnrealSharp.TemplateSequence.TemplateSequence LoadSequence()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[LoadSequence_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, LoadSequence_NativeFunction, ParamsBuffer);
            
            UnrealSharp.TemplateSequence.TemplateSequence returnValue;
            returnValue = ObjectMarshaller<UnrealSharp.TemplateSequence.TemplateSequence>.FromNative(IntPtr.Add(ParamsBuffer, LoadSequence_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/TemplateSequence.TemplateSequenceActor:GetSequence
    static readonly IntPtr GetSequence_NativeFunction;
    static readonly int GetSequence_ParamsSize;
    static readonly int GetSequence_ReturnValue_Offset;
    
    public UnrealSharp.TemplateSequence.TemplateSequence GetSequence()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetSequence_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetSequence_NativeFunction, ParamsBuffer);
            
            UnrealSharp.TemplateSequence.TemplateSequence returnValue;
            returnValue = ObjectMarshaller<UnrealSharp.TemplateSequence.TemplateSequence>.FromNative(IntPtr.Add(ParamsBuffer, GetSequence_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    
}