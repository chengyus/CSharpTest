// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.SequencerScripting;

[UClass]
public partial class MovieSceneScriptingActorReferenceChannel : UnrealSharp.SequencerScripting.MovieSceneScriptingChannel
{
    
    static MovieSceneScriptingActorReferenceChannel()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("MovieSceneScriptingActorReferenceChannel");
        
        
        SetDefault_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetDefault");
        SetDefault_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetDefault_NativeFunction);
        SetDefault_InDefaultValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetDefault_NativeFunction, "InDefaultValue");
        RemoveKey_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "RemoveKey");
        RemoveKey_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(RemoveKey_NativeFunction);
        RemoveKey_Key_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(RemoveKey_NativeFunction, "Key");
        RemoveDefault_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "RemoveDefault");
        HasDefault_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "HasDefault");
        HasDefault_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(HasDefault_NativeFunction);
        HasDefault_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(HasDefault_NativeFunction, "ReturnValue");
        GetKeys_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetKeys");
        GetKeys_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetKeys_NativeFunction);
        GetKeys_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetKeys_NativeFunction, "ReturnValue");
        GetKeys_ReturnValue_ElementSize = FArrayPropertyExporter.CallGetArrayElementSize(GetKeys_NativeFunction, "ReturnValue");
        GetDefault_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetDefault");
        GetDefault_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetDefault_NativeFunction);
        GetDefault_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetDefault_NativeFunction, "ReturnValue");
        AddKey_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AddKey");
        AddKey_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AddKey_NativeFunction);
        AddKey_InTime_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddKey_NativeFunction, "InTime");
        AddKey_NewValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddKey_NativeFunction, "NewValue");
        AddKey_SubFrame_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddKey_NativeFunction, "SubFrame");
        AddKey_TimeUnit_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddKey_NativeFunction, "TimeUnit");
        AddKey_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddKey_NativeFunction, "ReturnValue");
        
        
    }
    
    protected MovieSceneScriptingActorReferenceChannel(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // Function /Script/SequencerScripting.MovieSceneScriptingActorReferenceChannel:SetDefault
    static readonly IntPtr SetDefault_NativeFunction;
    static readonly int SetDefault_ParamsSize;
    static readonly int SetDefault_InDefaultValue_Offset;
    
    public void SetDefault(UnrealSharp.MovieScene.MovieSceneObjectBindingID inDefaultValue)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetDefault_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            UnrealSharp.MovieScene.MovieSceneObjectBindingIDMarshaler.ToNative(IntPtr.Add(ParamsBuffer, SetDefault_InDefaultValue_Offset), 0, null, inDefaultValue);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetDefault_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/SequencerScripting.MovieSceneScriptingActorReferenceChannel:RemoveKey
    static readonly IntPtr RemoveKey_NativeFunction;
    static readonly int RemoveKey_ParamsSize;
    static readonly int RemoveKey_Key_Offset;
    
    public void RemoveKey(UnrealSharp.SequencerScripting.MovieSceneScriptingKey key)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[RemoveKey_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.SequencerScripting.MovieSceneScriptingKey>.ToNative(IntPtr.Add(ParamsBuffer, RemoveKey_Key_Offset), 0, null, key);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, RemoveKey_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/SequencerScripting.MovieSceneScriptingActorReferenceChannel:RemoveDefault
    static readonly IntPtr RemoveDefault_NativeFunction;
    
    public void RemoveDefault()
    {
        unsafe
        {
            UObjectExporter.CallInvokeNativeFunction(NativeObject, RemoveDefault_NativeFunction, IntPtr.Zero);
        }
    }
    
    // Function /Script/SequencerScripting.MovieSceneScriptingActorReferenceChannel:HasDefault
    static readonly IntPtr HasDefault_NativeFunction;
    static readonly int HasDefault_ParamsSize;
    static readonly int HasDefault_ReturnValue_Offset;
    
    public bool HasDefault()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[HasDefault_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, HasDefault_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, HasDefault_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/SequencerScripting.MovieSceneScriptingActorReferenceChannel:GetKeys
    static readonly IntPtr GetKeys_NativeFunction;
    static readonly int GetKeys_ParamsSize;
    static readonly int GetKeys_ReturnValue_Offset;
    static readonly int GetKeys_ReturnValue_ElementSize;
    
    public System.Collections.Generic.IList<UnrealSharp.SequencerScripting.MovieSceneScriptingKey> GetKeys()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetKeys_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetKeys_NativeFunction, ParamsBuffer);
            
            System.Collections.Generic.IList<UnrealSharp.SequencerScripting.MovieSceneScriptingKey> returnValue;
            IntPtr ReturnValue_NativeBuffer = IntPtr.Add(ParamsBuffer, GetKeys_ReturnValue_Offset);
            UnrealArrayCopyMarshaler<UnrealSharp.SequencerScripting.MovieSceneScriptingKey> ReturnValue_Marshaler = new UnrealArrayCopyMarshaler<UnrealSharp.SequencerScripting.MovieSceneScriptingKey> (1, ObjectMarshaller<UnrealSharp.SequencerScripting.MovieSceneScriptingKey>.ToNative, ObjectMarshaller<UnrealSharp.SequencerScripting.MovieSceneScriptingKey>.FromNative, GetKeys_ReturnValue_ElementSize);
            returnValue = ReturnValue_Marshaler.FromNative(ReturnValue_NativeBuffer, 0, null);
            UnrealArrayCopyMarshaler<UnrealSharp.SequencerScripting.MovieSceneScriptingKey>.DestructInstance(ReturnValue_NativeBuffer, 0);
            
            return returnValue;
        }
    }
    
    // Function /Script/SequencerScripting.MovieSceneScriptingActorReferenceChannel:GetDefault
    static readonly IntPtr GetDefault_NativeFunction;
    static readonly int GetDefault_ParamsSize;
    static readonly int GetDefault_ReturnValue_Offset;
    
    public UnrealSharp.MovieScene.MovieSceneObjectBindingID GetDefault()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetDefault_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetDefault_NativeFunction, ParamsBuffer);
            
            UnrealSharp.MovieScene.MovieSceneObjectBindingID returnValue;
            returnValue = UnrealSharp.MovieScene.MovieSceneObjectBindingIDMarshaler.FromNative(IntPtr.Add(ParamsBuffer, GetDefault_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/SequencerScripting.MovieSceneScriptingActorReferenceChannel:AddKey
    static readonly IntPtr AddKey_NativeFunction;
    static readonly int AddKey_ParamsSize;
    static readonly int AddKey_InTime_Offset;
    static readonly int AddKey_NewValue_Offset;
    static readonly int AddKey_SubFrame_Offset;
    static readonly int AddKey_TimeUnit_Offset;
    static readonly int AddKey_ReturnValue_Offset;
    
    public UnrealSharp.SequencerScripting.MovieSceneScriptingActorReferenceKey AddKey(UnrealSharp.CoreUObject.FrameNumber inTime, UnrealSharp.MovieScene.MovieSceneObjectBindingID newValue, float subFrame = 0.000000f, UnrealSharp.SequencerScripting.ESequenceTimeUnit timeUnit = UnrealSharp.SequencerScripting.ESequenceTimeUnit.DisplayRate)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AddKey_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<UnrealSharp.CoreUObject.FrameNumber>.ToNative(IntPtr.Add(ParamsBuffer, AddKey_InTime_Offset), 0, null, inTime);
            UnrealSharp.MovieScene.MovieSceneObjectBindingIDMarshaler.ToNative(IntPtr.Add(ParamsBuffer, AddKey_NewValue_Offset), 0, null, newValue);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, AddKey_SubFrame_Offset), 0, null, subFrame);
            BlittableMarshaller<UnrealSharp.SequencerScripting.ESequenceTimeUnit>.ToNative(IntPtr.Add(ParamsBuffer, AddKey_TimeUnit_Offset), 0, null, timeUnit);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, AddKey_NativeFunction, ParamsBuffer);
            
            UnrealSharp.SequencerScripting.MovieSceneScriptingActorReferenceKey returnValue;
            returnValue = ObjectMarshaller<UnrealSharp.SequencerScripting.MovieSceneScriptingActorReferenceKey>.FromNative(IntPtr.Add(ParamsBuffer, AddKey_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    
}