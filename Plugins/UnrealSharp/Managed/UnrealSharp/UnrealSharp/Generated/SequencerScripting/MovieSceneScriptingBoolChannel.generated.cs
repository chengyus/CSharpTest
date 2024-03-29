// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.SequencerScripting;

[UClass]
public partial class MovieSceneScriptingBoolChannel : UnrealSharp.SequencerScripting.MovieSceneScriptingChannel
{
    
    static MovieSceneScriptingBoolChannel()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("MovieSceneScriptingBoolChannel");
        
        
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
        GetNumKeys_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetNumKeys");
        GetNumKeys_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetNumKeys_NativeFunction);
        GetNumKeys_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetNumKeys_NativeFunction, "ReturnValue");
        GetKeys_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetKeys");
        GetKeys_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetKeys_NativeFunction);
        GetKeys_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetKeys_NativeFunction, "ReturnValue");
        GetKeys_ReturnValue_ElementSize = FArrayPropertyExporter.CallGetArrayElementSize(GetKeys_NativeFunction, "ReturnValue");
        GetDefault_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetDefault");
        GetDefault_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetDefault_NativeFunction);
        GetDefault_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetDefault_NativeFunction, "ReturnValue");
        EvaluateKeys_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "EvaluateKeys");
        EvaluateKeys_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(EvaluateKeys_NativeFunction);
        EvaluateKeys_Range_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(EvaluateKeys_NativeFunction, "Range");
        EvaluateKeys_FrameRate_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(EvaluateKeys_NativeFunction, "FrameRate");
        EvaluateKeys_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(EvaluateKeys_NativeFunction, "ReturnValue");
        EvaluateKeys_ReturnValue_ElementSize = FArrayPropertyExporter.CallGetArrayElementSize(EvaluateKeys_NativeFunction, "ReturnValue");
        ComputeEffectiveRange_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "ComputeEffectiveRange");
        ComputeEffectiveRange_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(ComputeEffectiveRange_NativeFunction);
        ComputeEffectiveRange_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ComputeEffectiveRange_NativeFunction, "ReturnValue");
        AddKey_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AddKey");
        AddKey_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AddKey_NativeFunction);
        AddKey_InTime_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddKey_NativeFunction, "InTime");
        AddKey_NewValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddKey_NativeFunction, "NewValue");
        AddKey_SubFrame_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddKey_NativeFunction, "SubFrame");
        AddKey_TimeUnit_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddKey_NativeFunction, "TimeUnit");
        AddKey_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddKey_NativeFunction, "ReturnValue");
        
        
    }
    
    protected MovieSceneScriptingBoolChannel(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // Function /Script/SequencerScripting.MovieSceneScriptingBoolChannel:SetDefault
    static readonly IntPtr SetDefault_NativeFunction;
    static readonly int SetDefault_ParamsSize;
    static readonly int SetDefault_InDefaultValue_Offset;
    
    public void SetDefault(bool inDefaultValue)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetDefault_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, SetDefault_InDefaultValue_Offset), 0, null, inDefaultValue);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetDefault_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/SequencerScripting.MovieSceneScriptingBoolChannel:RemoveKey
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
    
    // Function /Script/SequencerScripting.MovieSceneScriptingBoolChannel:RemoveDefault
    static readonly IntPtr RemoveDefault_NativeFunction;
    
    public void RemoveDefault()
    {
        unsafe
        {
            UObjectExporter.CallInvokeNativeFunction(NativeObject, RemoveDefault_NativeFunction, IntPtr.Zero);
        }
    }
    
    // Function /Script/SequencerScripting.MovieSceneScriptingBoolChannel:HasDefault
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
    
    // Function /Script/SequencerScripting.MovieSceneScriptingBoolChannel:GetNumKeys
    static readonly IntPtr GetNumKeys_NativeFunction;
    static readonly int GetNumKeys_ParamsSize;
    static readonly int GetNumKeys_ReturnValue_Offset;
    
    public int GetNumKeys()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetNumKeys_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetNumKeys_NativeFunction, ParamsBuffer);
            
            int returnValue;
            returnValue = BlittableMarshaller<int>.FromNative(IntPtr.Add(ParamsBuffer, GetNumKeys_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/SequencerScripting.MovieSceneScriptingBoolChannel:GetKeys
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
    
    // Function /Script/SequencerScripting.MovieSceneScriptingBoolChannel:GetDefault
    static readonly IntPtr GetDefault_NativeFunction;
    static readonly int GetDefault_ParamsSize;
    static readonly int GetDefault_ReturnValue_Offset;
    
    public bool GetDefault()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetDefault_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetDefault_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, GetDefault_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/SequencerScripting.MovieSceneScriptingBoolChannel:EvaluateKeys
    static readonly IntPtr EvaluateKeys_NativeFunction;
    static readonly int EvaluateKeys_ParamsSize;
    static readonly int EvaluateKeys_Range_Offset;
    static readonly int EvaluateKeys_FrameRate_Offset;
    static readonly int EvaluateKeys_ReturnValue_Offset;
    static readonly int EvaluateKeys_ReturnValue_ElementSize;
    
    public System.Collections.Generic.IList<bool> EvaluateKeys(UnrealSharp.SequencerScripting.SequencerScriptingRange range, UnrealSharp.CoreUObject.FrameRate frameRate)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[EvaluateKeys_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            UnrealSharp.SequencerScripting.SequencerScriptingRangeMarshaler.ToNative(IntPtr.Add(ParamsBuffer, EvaluateKeys_Range_Offset), 0, null, range);
            BlittableMarshaller<UnrealSharp.CoreUObject.FrameRate>.ToNative(IntPtr.Add(ParamsBuffer, EvaluateKeys_FrameRate_Offset), 0, null, frameRate);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, EvaluateKeys_NativeFunction, ParamsBuffer);
            
            System.Collections.Generic.IList<bool> returnValue;
            IntPtr ReturnValue_NativeBuffer = IntPtr.Add(ParamsBuffer, EvaluateKeys_ReturnValue_Offset);
            UnrealArrayCopyMarshaler<bool> ReturnValue_Marshaler = new UnrealArrayCopyMarshaler<bool> (1, BoolMarshaller.ToNative, BoolMarshaller.FromNative, EvaluateKeys_ReturnValue_ElementSize);
            returnValue = ReturnValue_Marshaler.FromNative(ReturnValue_NativeBuffer, 0, null);
            UnrealArrayCopyMarshaler<bool>.DestructInstance(ReturnValue_NativeBuffer, 0);
            
            return returnValue;
        }
    }
    
    // Function /Script/SequencerScripting.MovieSceneScriptingBoolChannel:ComputeEffectiveRange
    static readonly IntPtr ComputeEffectiveRange_NativeFunction;
    static readonly int ComputeEffectiveRange_ParamsSize;
    static readonly int ComputeEffectiveRange_ReturnValue_Offset;
    
    public UnrealSharp.SequencerScripting.SequencerScriptingRange ComputeEffectiveRange()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[ComputeEffectiveRange_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, ComputeEffectiveRange_NativeFunction, ParamsBuffer);
            
            UnrealSharp.SequencerScripting.SequencerScriptingRange returnValue;
            returnValue = UnrealSharp.SequencerScripting.SequencerScriptingRangeMarshaler.FromNative(IntPtr.Add(ParamsBuffer, ComputeEffectiveRange_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/SequencerScripting.MovieSceneScriptingBoolChannel:AddKey
    static readonly IntPtr AddKey_NativeFunction;
    static readonly int AddKey_ParamsSize;
    static readonly int AddKey_InTime_Offset;
    static readonly int AddKey_NewValue_Offset;
    static readonly int AddKey_SubFrame_Offset;
    static readonly int AddKey_TimeUnit_Offset;
    static readonly int AddKey_ReturnValue_Offset;
    
    public UnrealSharp.SequencerScripting.MovieSceneScriptingBoolKey AddKey(UnrealSharp.CoreUObject.FrameNumber inTime, bool newValue, float subFrame = 0.000000f, UnrealSharp.SequencerScripting.ESequenceTimeUnit timeUnit = UnrealSharp.SequencerScripting.ESequenceTimeUnit.DisplayRate)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AddKey_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<UnrealSharp.CoreUObject.FrameNumber>.ToNative(IntPtr.Add(ParamsBuffer, AddKey_InTime_Offset), 0, null, inTime);
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, AddKey_NewValue_Offset), 0, null, newValue);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, AddKey_SubFrame_Offset), 0, null, subFrame);
            BlittableMarshaller<UnrealSharp.SequencerScripting.ESequenceTimeUnit>.ToNative(IntPtr.Add(ParamsBuffer, AddKey_TimeUnit_Offset), 0, null, timeUnit);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, AddKey_NativeFunction, ParamsBuffer);
            
            UnrealSharp.SequencerScripting.MovieSceneScriptingBoolKey returnValue;
            returnValue = ObjectMarshaller<UnrealSharp.SequencerScripting.MovieSceneScriptingBoolKey>.FromNative(IntPtr.Add(ParamsBuffer, AddKey_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    
}