// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.CacheTrackRecorder;

[UClass]
public partial class CacheTrackRecorder : UnrealSharp.CoreUObject.Object
{
    
    static CacheTrackRecorder()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("CacheTrackRecorder");
        
        
        GetState_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetState");
        GetState_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetState_NativeFunction);
        GetState_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetState_NativeFunction, "ReturnValue");
        GetSequence_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetSequence");
        GetSequence_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetSequence_NativeFunction);
        GetSequence_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetSequence_NativeFunction, "ReturnValue");
        
        
    }
    
    protected CacheTrackRecorder(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // Function /Script/CacheTrackRecorder.CacheTrackRecorder:GetState
    static readonly IntPtr GetState_NativeFunction;
    static readonly int GetState_ParamsSize;
    static readonly int GetState_ReturnValue_Offset;
    
    public UnrealSharp.CacheTrackRecorder.ECacheTrackRecorderState GetState()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetState_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetState_NativeFunction, ParamsBuffer);
            
            UnrealSharp.CacheTrackRecorder.ECacheTrackRecorderState returnValue;
            returnValue = BlittableMarshaller<UnrealSharp.CacheTrackRecorder.ECacheTrackRecorderState>.FromNative(IntPtr.Add(ParamsBuffer, GetState_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/CacheTrackRecorder.CacheTrackRecorder:GetSequence
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
    
    
}