// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.SequencerScripting;

[UClass]
public partial class MovieSceneScriptingEventChannel : UnrealSharp.SequencerScripting.MovieSceneScriptingChannel
{
    
    static MovieSceneScriptingEventChannel()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("MovieSceneScriptingEventChannel");
        
        
        RemoveKey_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "RemoveKey");
        RemoveKey_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(RemoveKey_NativeFunction);
        RemoveKey_Key_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(RemoveKey_NativeFunction, "Key");
        GetKeys_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetKeys");
        GetKeys_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetKeys_NativeFunction);
        GetKeys_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetKeys_NativeFunction, "ReturnValue");
        GetKeys_ReturnValue_ElementSize = FArrayPropertyExporter.CallGetArrayElementSize(GetKeys_NativeFunction, "ReturnValue");
        AddKey_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AddKey");
        AddKey_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AddKey_NativeFunction);
        AddKey_InTime_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddKey_NativeFunction, "InTime");
        AddKey_NewValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddKey_NativeFunction, "NewValue");
        AddKey_SubFrame_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddKey_NativeFunction, "SubFrame");
        AddKey_TimeUnit_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddKey_NativeFunction, "TimeUnit");
        AddKey_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddKey_NativeFunction, "ReturnValue");
        
        
    }
    
    protected MovieSceneScriptingEventChannel(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // Function /Script/SequencerScripting.MovieSceneScriptingEventChannel:RemoveKey
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
    
    // Function /Script/SequencerScripting.MovieSceneScriptingEventChannel:GetKeys
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
    
    // Function /Script/SequencerScripting.MovieSceneScriptingEventChannel:AddKey
    static readonly IntPtr AddKey_NativeFunction;
    static readonly int AddKey_ParamsSize;
    static readonly int AddKey_InTime_Offset;
    static readonly int AddKey_NewValue_Offset;
    static readonly int AddKey_SubFrame_Offset;
    static readonly int AddKey_TimeUnit_Offset;
    static readonly int AddKey_ReturnValue_Offset;
    
    public UnrealSharp.SequencerScripting.MovieSceneScriptingEventKey AddKey(UnrealSharp.CoreUObject.FrameNumber inTime, UnrealSharp.MovieSceneTracks.MovieSceneEvent newValue, float subFrame = 0.000000f, UnrealSharp.SequencerScripting.ESequenceTimeUnit timeUnit = UnrealSharp.SequencerScripting.ESequenceTimeUnit.DisplayRate)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AddKey_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<UnrealSharp.CoreUObject.FrameNumber>.ToNative(IntPtr.Add(ParamsBuffer, AddKey_InTime_Offset), 0, null, inTime);
            UnrealSharp.MovieSceneTracks.MovieSceneEventMarshaler.ToNative(IntPtr.Add(ParamsBuffer, AddKey_NewValue_Offset), 0, null, newValue);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, AddKey_SubFrame_Offset), 0, null, subFrame);
            BlittableMarshaller<UnrealSharp.SequencerScripting.ESequenceTimeUnit>.ToNative(IntPtr.Add(ParamsBuffer, AddKey_TimeUnit_Offset), 0, null, timeUnit);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, AddKey_NativeFunction, ParamsBuffer);
            
            UnrealSharp.SequencerScripting.MovieSceneScriptingEventKey returnValue;
            returnValue = ObjectMarshaller<UnrealSharp.SequencerScripting.MovieSceneScriptingEventKey>.FromNative(IntPtr.Add(ParamsBuffer, AddKey_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    
}