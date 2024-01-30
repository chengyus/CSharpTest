// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.SequencerScripting;

[UClass]
public partial class MovieSceneScriptingBoolKey : UnrealSharp.SequencerScripting.MovieSceneScriptingKey
{
    
    static MovieSceneScriptingBoolKey()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("MovieSceneScriptingBoolKey");
        
        
        SetValue_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetValue");
        SetValue_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetValue_NativeFunction);
        SetValue_InNewValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetValue_NativeFunction, "InNewValue");
        SetTime_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetTime");
        SetTime_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetTime_NativeFunction);
        SetTime_NewFrameNumber_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetTime_NativeFunction, "NewFrameNumber");
        SetTime_SubFrame_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetTime_NativeFunction, "SubFrame");
        SetTime_TimeUnit_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetTime_NativeFunction, "TimeUnit");
        GetValue_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetValue");
        GetValue_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetValue_NativeFunction);
        GetValue_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetValue_NativeFunction, "ReturnValue");
        GetTime_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetTime");
        GetTime_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetTime_NativeFunction);
        GetTime_TimeUnit_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetTime_NativeFunction, "TimeUnit");
        GetTime_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetTime_NativeFunction, "ReturnValue");
        
        
    }
    
    protected MovieSceneScriptingBoolKey(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // Function /Script/SequencerScripting.MovieSceneScriptingBoolKey:SetValue
    static readonly IntPtr SetValue_NativeFunction;
    static readonly int SetValue_ParamsSize;
    static readonly int SetValue_InNewValue_Offset;
    
    public void SetValue(bool inNewValue)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetValue_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, SetValue_InNewValue_Offset), 0, null, inNewValue);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetValue_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/SequencerScripting.MovieSceneScriptingBoolKey:SetTime
    static readonly IntPtr SetTime_NativeFunction;
    static readonly int SetTime_ParamsSize;
    static readonly int SetTime_NewFrameNumber_Offset;
    static readonly int SetTime_SubFrame_Offset;
    static readonly int SetTime_TimeUnit_Offset;
    
    public void SetTime(UnrealSharp.CoreUObject.FrameNumber newFrameNumber, float subFrame = 0.000000f, UnrealSharp.SequencerScripting.ESequenceTimeUnit timeUnit = UnrealSharp.SequencerScripting.ESequenceTimeUnit.DisplayRate)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetTime_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<UnrealSharp.CoreUObject.FrameNumber>.ToNative(IntPtr.Add(ParamsBuffer, SetTime_NewFrameNumber_Offset), 0, null, newFrameNumber);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, SetTime_SubFrame_Offset), 0, null, subFrame);
            BlittableMarshaller<UnrealSharp.SequencerScripting.ESequenceTimeUnit>.ToNative(IntPtr.Add(ParamsBuffer, SetTime_TimeUnit_Offset), 0, null, timeUnit);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetTime_NativeFunction, ParamsBuffer);
            
            
        }
    }
    
    // Function /Script/SequencerScripting.MovieSceneScriptingBoolKey:GetValue
    static readonly IntPtr GetValue_NativeFunction;
    static readonly int GetValue_ParamsSize;
    static readonly int GetValue_ReturnValue_Offset;
    
    public bool GetValue()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetValue_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetValue_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, GetValue_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/SequencerScripting.MovieSceneScriptingBoolKey:GetTime
    static readonly IntPtr GetTime_NativeFunction;
    static readonly int GetTime_ParamsSize;
    static readonly int GetTime_TimeUnit_Offset;
    static readonly int GetTime_ReturnValue_Offset;
    
    public UnrealSharp.CoreUObject.FrameTime GetTime(UnrealSharp.SequencerScripting.ESequenceTimeUnit timeUnit = UnrealSharp.SequencerScripting.ESequenceTimeUnit.DisplayRate)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetTime_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<UnrealSharp.SequencerScripting.ESequenceTimeUnit>.ToNative(IntPtr.Add(ParamsBuffer, GetTime_TimeUnit_Offset), 0, null, timeUnit);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetTime_NativeFunction, ParamsBuffer);
            
            UnrealSharp.CoreUObject.FrameTime returnValue;
            returnValue = BlittableMarshaller<UnrealSharp.CoreUObject.FrameTime>.FromNative(IntPtr.Add(ParamsBuffer, GetTime_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    
}