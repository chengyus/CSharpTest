// This file is automatically generated
using UnrealSharp.MovieScene;
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.LevelSequence;

[UClass]
public partial class LevelSequenceActor : UnrealSharp.Engine.Actor, IMovieScenePlaybackClient, IMovieSceneBindingOwnerInterface, IWorldPartitionObjectResolver
{
    
    static LevelSequenceActor()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("LevelSequenceActor");
        
        PlaybackSettings_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PlaybackSettings");
        SequencePlayer_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SequencePlayer");
        LevelSequenceAsset_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LevelSequenceAsset");
        CameraSettings_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CameraSettings");
        BurnInOptions_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BurnInOptions");
        BindingOverrides_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BindingOverrides");
        bOverrideInstanceData_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverrideInstanceData");
        bOverrideInstanceData_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverrideInstanceData");
        bReplicatePlayback_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bReplicatePlayback");
        bReplicatePlayback_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bReplicatePlayback");
        DefaultInstanceData_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DefaultInstanceData");
        
        ShowBurnin_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "ShowBurnin");
        SetSequence_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetSequence");
        SetSequence_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetSequence_NativeFunction);
        SetSequence_InSequence_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetSequence_NativeFunction, "InSequence");
        SetBindingByTag_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetBindingByTag");
        SetBindingByTag_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetBindingByTag_NativeFunction);
        SetBindingByTag_BindingTag_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetBindingByTag_NativeFunction, "BindingTag");
        SetBindingByTag_Actors_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetBindingByTag_NativeFunction, "Actors");
        SetBindingByTag_Actors_ElementSize = FArrayPropertyExporter.CallGetArrayElementSize(SetBindingByTag_NativeFunction, "Actors");
        SetBindingByTag_bAllowBindingsFromAsset_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetBindingByTag_NativeFunction, "bAllowBindingsFromAsset");
        SetBinding_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetBinding");
        SetBinding_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetBinding_NativeFunction);
        SetBinding_Binding_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetBinding_NativeFunction, "Binding");
        SetBinding_Actors_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetBinding_NativeFunction, "Actors");
        SetBinding_Actors_ElementSize = FArrayPropertyExporter.CallGetArrayElementSize(SetBinding_NativeFunction, "Actors");
        SetBinding_bAllowBindingsFromAsset_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetBinding_NativeFunction, "bAllowBindingsFromAsset");
        ResetBindings_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "ResetBindings");
        ResetBinding_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "ResetBinding");
        ResetBinding_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(ResetBinding_NativeFunction);
        ResetBinding_Binding_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ResetBinding_NativeFunction, "Binding");
        RemoveBindingByTag_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "RemoveBindingByTag");
        RemoveBindingByTag_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(RemoveBindingByTag_NativeFunction);
        RemoveBindingByTag_Tag_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(RemoveBindingByTag_NativeFunction, "Tag");
        RemoveBindingByTag_Actor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(RemoveBindingByTag_NativeFunction, "Actor");
        RemoveBinding_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "RemoveBinding");
        RemoveBinding_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(RemoveBinding_NativeFunction);
        RemoveBinding_Binding_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(RemoveBinding_NativeFunction, "Binding");
        RemoveBinding_Actor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(RemoveBinding_NativeFunction, "Actor");
        HideBurnin_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "HideBurnin");
        GetSequence_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetSequence");
        GetSequence_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetSequence_NativeFunction);
        GetSequence_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetSequence_NativeFunction, "ReturnValue");
        FindNamedBindings_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "FindNamedBindings");
        FindNamedBindings_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(FindNamedBindings_NativeFunction);
        FindNamedBindings_Tag_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(FindNamedBindings_NativeFunction, "Tag");
        FindNamedBindings_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(FindNamedBindings_NativeFunction, "ReturnValue");
        FindNamedBindings_ReturnValue_ElementSize = FArrayPropertyExporter.CallGetArrayElementSize(FindNamedBindings_NativeFunction, "ReturnValue");
        FindNamedBinding_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "FindNamedBinding");
        FindNamedBinding_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(FindNamedBinding_NativeFunction);
        FindNamedBinding_Tag_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(FindNamedBinding_NativeFunction, "Tag");
        FindNamedBinding_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(FindNamedBinding_NativeFunction, "ReturnValue");
        AddBindingByTag_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AddBindingByTag");
        AddBindingByTag_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AddBindingByTag_NativeFunction);
        AddBindingByTag_BindingTag_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddBindingByTag_NativeFunction, "BindingTag");
        AddBindingByTag_Actor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddBindingByTag_NativeFunction, "Actor");
        AddBindingByTag_bAllowBindingsFromAsset_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddBindingByTag_NativeFunction, "bAllowBindingsFromAsset");
        AddBinding_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AddBinding");
        AddBinding_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AddBinding_NativeFunction);
        AddBinding_Binding_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddBinding_NativeFunction, "Binding");
        AddBinding_Actor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddBinding_NativeFunction, "Actor");
        AddBinding_bAllowBindingsFromAsset_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddBinding_NativeFunction, "bAllowBindingsFromAsset");
        
        
    }
    
    protected LevelSequenceActor(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // StructProperty /Script/LevelSequence.LevelSequenceActor:PlaybackSettings
    static readonly int PlaybackSettings_Offset;
    
    public UnrealSharp.MovieScene.MovieSceneSequencePlaybackSettings PlaybackSettings
    {
        get
        {
            CheckObjectForValidity();
            return UnrealSharp.MovieScene.MovieSceneSequencePlaybackSettingsMarshaler.FromNative(IntPtr.Add(NativeObject, PlaybackSettings_Offset), 0, this);
        }
    }
    
    // ObjectProperty /Script/LevelSequence.LevelSequenceActor:SequencePlayer
    static readonly int SequencePlayer_Offset;
    
    public UnrealSharp.LevelSequence.LevelSequencePlayer SequencePlayer
    {
        get
        {
            CheckObjectForValidity();
            return ObjectMarshaller<UnrealSharp.LevelSequence.LevelSequencePlayer>.FromNative(IntPtr.Add(NativeObject, SequencePlayer_Offset), 0, this);
        }
    }
    
    // ObjectProperty /Script/LevelSequence.LevelSequenceActor:LevelSequenceAsset
    static readonly int LevelSequenceAsset_Offset;
    
    public UnrealSharp.LevelSequence.LevelSequence LevelSequenceAsset
    {
        get
        {
            CheckObjectForValidity();
            return ObjectMarshaller<UnrealSharp.LevelSequence.LevelSequence>.FromNative(IntPtr.Add(NativeObject, LevelSequenceAsset_Offset), 0, this);
        }
    }
    
    // StructProperty /Script/LevelSequence.LevelSequenceActor:CameraSettings
    static readonly int CameraSettings_Offset;
    
    public UnrealSharp.LevelSequence.LevelSequenceCameraSettings CameraSettings
    {
        get
        {
            CheckObjectForValidity();
            return UnrealSharp.LevelSequence.LevelSequenceCameraSettingsMarshaler.FromNative(IntPtr.Add(NativeObject, CameraSettings_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            UnrealSharp.LevelSequence.LevelSequenceCameraSettingsMarshaler.ToNative(IntPtr.Add(NativeObject, CameraSettings_Offset), 0, this, value);
        }
    }
    
    // ObjectProperty /Script/LevelSequence.LevelSequenceActor:BurnInOptions
    static readonly int BurnInOptions_Offset;
    
    public UnrealSharp.LevelSequence.LevelSequenceBurnInOptions BurnInOptions
    {
        get
        {
            CheckObjectForValidity();
            return ObjectMarshaller<UnrealSharp.LevelSequence.LevelSequenceBurnInOptions>.FromNative(IntPtr.Add(NativeObject, BurnInOptions_Offset), 0, this);
        }
    }
    
    // ObjectProperty /Script/LevelSequence.LevelSequenceActor:BindingOverrides
    static readonly int BindingOverrides_Offset;
    
    public UnrealSharp.MovieScene.MovieSceneBindingOverrides BindingOverrides
    {
        get
        {
            CheckObjectForValidity();
            return ObjectMarshaller<UnrealSharp.MovieScene.MovieSceneBindingOverrides>.FromNative(IntPtr.Add(NativeObject, BindingOverrides_Offset), 0, this);
        }
    }
    
    // BoolProperty /Script/LevelSequence.LevelSequenceActor:bOverrideInstanceData
    static readonly int bOverrideInstanceData_Offset;
    static readonly IntPtr bOverrideInstanceData_NativeProperty;
    
    public bool bOverrideInstanceData
    {
        get
        {
            CheckObjectForValidity();
            return FBoolPropertyExporter.CallGetBitfieldValueFromProperty(NativeObject, bOverrideInstanceData_NativeProperty, bOverrideInstanceData_Offset);
        }
        set
        {
            CheckObjectForValidity();
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(NativeObject, bOverrideInstanceData_NativeProperty, bOverrideInstanceData_Offset, value);
        }
    }
    
    // BoolProperty /Script/LevelSequence.LevelSequenceActor:bReplicatePlayback
    static readonly int bReplicatePlayback_Offset;
    static readonly IntPtr bReplicatePlayback_NativeProperty;
    
    public bool bReplicatePlayback
    {
        get
        {
            CheckObjectForValidity();
            return FBoolPropertyExporter.CallGetBitfieldValueFromProperty(NativeObject, bReplicatePlayback_NativeProperty, bReplicatePlayback_Offset);
        }
        set
        {
            CheckObjectForValidity();
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(NativeObject, bReplicatePlayback_NativeProperty, bReplicatePlayback_Offset, value);
        }
    }
    
    // ObjectProperty /Script/LevelSequence.LevelSequenceActor:DefaultInstanceData
    static readonly int DefaultInstanceData_Offset;
    
    public UnrealSharp.CoreUObject.Object DefaultInstanceData
    {
        get
        {
            CheckObjectForValidity();
            return ObjectMarshaller<UnrealSharp.CoreUObject.Object>.FromNative(IntPtr.Add(NativeObject, DefaultInstanceData_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            ObjectMarshaller<UnrealSharp.CoreUObject.Object>.ToNative(IntPtr.Add(NativeObject, DefaultInstanceData_Offset), 0, this, value);
        }
    }
    
    // Function /Script/LevelSequence.LevelSequenceActor:ShowBurnin
    static readonly IntPtr ShowBurnin_NativeFunction;
    
    public void ShowBurnin()
    {
        unsafe
        {
            UObjectExporter.CallInvokeNativeFunction(NativeObject, ShowBurnin_NativeFunction, IntPtr.Zero);
        }
    }
    
    // Function /Script/LevelSequence.LevelSequenceActor:SetSequence
    static readonly IntPtr SetSequence_NativeFunction;
    static readonly int SetSequence_ParamsSize;
    static readonly int SetSequence_InSequence_Offset;
    
    public void SetSequence(UnrealSharp.LevelSequence.LevelSequence inSequence)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetSequence_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.LevelSequence.LevelSequence>.ToNative(IntPtr.Add(ParamsBuffer, SetSequence_InSequence_Offset), 0, null, inSequence);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetSequence_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/LevelSequence.LevelSequenceActor:SetBindingByTag
    static readonly IntPtr SetBindingByTag_NativeFunction;
    static readonly int SetBindingByTag_ParamsSize;
    static readonly int SetBindingByTag_BindingTag_Offset;
    static readonly int SetBindingByTag_Actors_Offset;
    static readonly int SetBindingByTag_Actors_ElementSize;
    static readonly int SetBindingByTag_bAllowBindingsFromAsset_Offset;
    
    public void SetBindingByTag(Name bindingTag, System.Collections.Generic.IList<UnrealSharp.Engine.Actor> actors, bool bAllowBindingsFromAsset = false)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetBindingByTag_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(ParamsBuffer, SetBindingByTag_BindingTag_Offset), 0, null, bindingTag);
            IntPtr Actors_NativeBuffer = IntPtr.Add(ParamsBuffer, SetBindingByTag_Actors_Offset);
            UnrealArrayCopyMarshaler<UnrealSharp.Engine.Actor> Actors_Marshaler = new UnrealArrayCopyMarshaler<UnrealSharp.Engine.Actor>(1, ObjectMarshaller<UnrealSharp.Engine.Actor>.ToNative, ObjectMarshaller<UnrealSharp.Engine.Actor>.FromNative, SetBindingByTag_Actors_ElementSize);
            Actors_Marshaler.ToNative(Actors_NativeBuffer, 0, null, actors);
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, SetBindingByTag_bAllowBindingsFromAsset_Offset), 0, null, bAllowBindingsFromAsset);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetBindingByTag_NativeFunction, ParamsBuffer);
            
            
        }
    }
    
    // Function /Script/LevelSequence.LevelSequenceActor:SetBinding
    static readonly IntPtr SetBinding_NativeFunction;
    static readonly int SetBinding_ParamsSize;
    static readonly int SetBinding_Binding_Offset;
    static readonly int SetBinding_Actors_Offset;
    static readonly int SetBinding_Actors_ElementSize;
    static readonly int SetBinding_bAllowBindingsFromAsset_Offset;
    
    public void SetBinding(UnrealSharp.MovieScene.MovieSceneObjectBindingID binding, System.Collections.Generic.IList<UnrealSharp.Engine.Actor> actors, bool bAllowBindingsFromAsset = false)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetBinding_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            UnrealSharp.MovieScene.MovieSceneObjectBindingIDMarshaler.ToNative(IntPtr.Add(ParamsBuffer, SetBinding_Binding_Offset), 0, null, binding);
            IntPtr Actors_NativeBuffer = IntPtr.Add(ParamsBuffer, SetBinding_Actors_Offset);
            UnrealArrayCopyMarshaler<UnrealSharp.Engine.Actor> Actors_Marshaler = new UnrealArrayCopyMarshaler<UnrealSharp.Engine.Actor>(1, ObjectMarshaller<UnrealSharp.Engine.Actor>.ToNative, ObjectMarshaller<UnrealSharp.Engine.Actor>.FromNative, SetBinding_Actors_ElementSize);
            Actors_Marshaler.ToNative(Actors_NativeBuffer, 0, null, actors);
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, SetBinding_bAllowBindingsFromAsset_Offset), 0, null, bAllowBindingsFromAsset);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetBinding_NativeFunction, ParamsBuffer);
            
            
        }
    }
    
    // Function /Script/LevelSequence.LevelSequenceActor:ResetBindings
    static readonly IntPtr ResetBindings_NativeFunction;
    
    public void ResetBindings()
    {
        unsafe
        {
            UObjectExporter.CallInvokeNativeFunction(NativeObject, ResetBindings_NativeFunction, IntPtr.Zero);
        }
    }
    
    // Function /Script/LevelSequence.LevelSequenceActor:ResetBinding
    static readonly IntPtr ResetBinding_NativeFunction;
    static readonly int ResetBinding_ParamsSize;
    static readonly int ResetBinding_Binding_Offset;
    
    public void ResetBinding(UnrealSharp.MovieScene.MovieSceneObjectBindingID binding)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[ResetBinding_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            UnrealSharp.MovieScene.MovieSceneObjectBindingIDMarshaler.ToNative(IntPtr.Add(ParamsBuffer, ResetBinding_Binding_Offset), 0, null, binding);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, ResetBinding_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/LevelSequence.LevelSequenceActor:RemoveBindingByTag
    static readonly IntPtr RemoveBindingByTag_NativeFunction;
    static readonly int RemoveBindingByTag_ParamsSize;
    static readonly int RemoveBindingByTag_Tag_Offset;
    static readonly int RemoveBindingByTag_Actor_Offset;
    
    public void RemoveBindingByTag(Name tag, UnrealSharp.Engine.Actor actor)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[RemoveBindingByTag_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(ParamsBuffer, RemoveBindingByTag_Tag_Offset), 0, null, tag);
            ObjectMarshaller<UnrealSharp.Engine.Actor>.ToNative(IntPtr.Add(ParamsBuffer, RemoveBindingByTag_Actor_Offset), 0, null, actor);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, RemoveBindingByTag_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/LevelSequence.LevelSequenceActor:RemoveBinding
    static readonly IntPtr RemoveBinding_NativeFunction;
    static readonly int RemoveBinding_ParamsSize;
    static readonly int RemoveBinding_Binding_Offset;
    static readonly int RemoveBinding_Actor_Offset;
    
    public void RemoveBinding(UnrealSharp.MovieScene.MovieSceneObjectBindingID binding, UnrealSharp.Engine.Actor actor)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[RemoveBinding_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            UnrealSharp.MovieScene.MovieSceneObjectBindingIDMarshaler.ToNative(IntPtr.Add(ParamsBuffer, RemoveBinding_Binding_Offset), 0, null, binding);
            ObjectMarshaller<UnrealSharp.Engine.Actor>.ToNative(IntPtr.Add(ParamsBuffer, RemoveBinding_Actor_Offset), 0, null, actor);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, RemoveBinding_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/LevelSequence.LevelSequenceActor:HideBurnin
    static readonly IntPtr HideBurnin_NativeFunction;
    
    public void HideBurnin()
    {
        unsafe
        {
            UObjectExporter.CallInvokeNativeFunction(NativeObject, HideBurnin_NativeFunction, IntPtr.Zero);
        }
    }
    
    // Function /Script/LevelSequence.LevelSequenceActor:GetSequence
    static readonly IntPtr GetSequence_NativeFunction;
    static readonly int GetSequence_ParamsSize;
    static readonly int GetSequence_ReturnValue_Offset;
    
    public UnrealSharp.LevelSequence.LevelSequence GetSequence()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetSequence_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetSequence_NativeFunction, ParamsBuffer);
            
            UnrealSharp.LevelSequence.LevelSequence returnValue;
            returnValue = ObjectMarshaller<UnrealSharp.LevelSequence.LevelSequence>.FromNative(IntPtr.Add(ParamsBuffer, GetSequence_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/LevelSequence.LevelSequenceActor:FindNamedBindings
    static readonly IntPtr FindNamedBindings_NativeFunction;
    static readonly int FindNamedBindings_ParamsSize;
    static readonly int FindNamedBindings_Tag_Offset;
    static readonly int FindNamedBindings_ReturnValue_Offset;
    static readonly int FindNamedBindings_ReturnValue_ElementSize;
    
    public System.Collections.Generic.IList<UnrealSharp.MovieScene.MovieSceneObjectBindingID> FindNamedBindings(Name tag)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[FindNamedBindings_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(ParamsBuffer, FindNamedBindings_Tag_Offset), 0, null, tag);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, FindNamedBindings_NativeFunction, ParamsBuffer);
            
            System.Collections.Generic.IList<UnrealSharp.MovieScene.MovieSceneObjectBindingID> returnValue;
            IntPtr ReturnValue_NativeBuffer = IntPtr.Add(ParamsBuffer, FindNamedBindings_ReturnValue_Offset);
            UnrealArrayCopyMarshaler<UnrealSharp.MovieScene.MovieSceneObjectBindingID> ReturnValue_Marshaler = new UnrealArrayCopyMarshaler<UnrealSharp.MovieScene.MovieSceneObjectBindingID> (1, UnrealSharp.MovieScene.MovieSceneObjectBindingIDMarshaler.ToNative, UnrealSharp.MovieScene.MovieSceneObjectBindingIDMarshaler.FromNative, FindNamedBindings_ReturnValue_ElementSize);
            returnValue = ReturnValue_Marshaler.FromNative(ReturnValue_NativeBuffer, 0, null);
            UnrealArrayCopyMarshaler<UnrealSharp.MovieScene.MovieSceneObjectBindingID>.DestructInstance(ReturnValue_NativeBuffer, 0);
            
            return returnValue;
        }
    }
    
    // Function /Script/LevelSequence.LevelSequenceActor:FindNamedBinding
    static readonly IntPtr FindNamedBinding_NativeFunction;
    static readonly int FindNamedBinding_ParamsSize;
    static readonly int FindNamedBinding_Tag_Offset;
    static readonly int FindNamedBinding_ReturnValue_Offset;
    
    public UnrealSharp.MovieScene.MovieSceneObjectBindingID FindNamedBinding(Name tag)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[FindNamedBinding_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(ParamsBuffer, FindNamedBinding_Tag_Offset), 0, null, tag);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, FindNamedBinding_NativeFunction, ParamsBuffer);
            
            UnrealSharp.MovieScene.MovieSceneObjectBindingID returnValue;
            returnValue = UnrealSharp.MovieScene.MovieSceneObjectBindingIDMarshaler.FromNative(IntPtr.Add(ParamsBuffer, FindNamedBinding_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/LevelSequence.LevelSequenceActor:AddBindingByTag
    static readonly IntPtr AddBindingByTag_NativeFunction;
    static readonly int AddBindingByTag_ParamsSize;
    static readonly int AddBindingByTag_BindingTag_Offset;
    static readonly int AddBindingByTag_Actor_Offset;
    static readonly int AddBindingByTag_bAllowBindingsFromAsset_Offset;
    
    public void AddBindingByTag(Name bindingTag, UnrealSharp.Engine.Actor actor, bool bAllowBindingsFromAsset = false)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AddBindingByTag_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(ParamsBuffer, AddBindingByTag_BindingTag_Offset), 0, null, bindingTag);
            ObjectMarshaller<UnrealSharp.Engine.Actor>.ToNative(IntPtr.Add(ParamsBuffer, AddBindingByTag_Actor_Offset), 0, null, actor);
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, AddBindingByTag_bAllowBindingsFromAsset_Offset), 0, null, bAllowBindingsFromAsset);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, AddBindingByTag_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/LevelSequence.LevelSequenceActor:AddBinding
    static readonly IntPtr AddBinding_NativeFunction;
    static readonly int AddBinding_ParamsSize;
    static readonly int AddBinding_Binding_Offset;
    static readonly int AddBinding_Actor_Offset;
    static readonly int AddBinding_bAllowBindingsFromAsset_Offset;
    
    public void AddBinding(UnrealSharp.MovieScene.MovieSceneObjectBindingID binding, UnrealSharp.Engine.Actor actor, bool bAllowBindingsFromAsset = false)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AddBinding_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            UnrealSharp.MovieScene.MovieSceneObjectBindingIDMarshaler.ToNative(IntPtr.Add(ParamsBuffer, AddBinding_Binding_Offset), 0, null, binding);
            ObjectMarshaller<UnrealSharp.Engine.Actor>.ToNative(IntPtr.Add(ParamsBuffer, AddBinding_Actor_Offset), 0, null, actor);
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, AddBinding_bAllowBindingsFromAsset_Offset), 0, null, bAllowBindingsFromAsset);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, AddBinding_NativeFunction, ParamsBuffer);
            
        }
    }
    
    
}