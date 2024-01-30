// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.MovieSceneCapture;

[UClass]
abstract public partial class MovieSceneCaptureProtocolBase : UnrealSharp.CoreUObject.Object
{
    
    static MovieSceneCaptureProtocolBase()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("MovieSceneCaptureProtocolBase");
        
        
        IsCapturing_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "IsCapturing");
        IsCapturing_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(IsCapturing_NativeFunction);
        IsCapturing_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(IsCapturing_NativeFunction, "ReturnValue");
        GetState_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetState");
        GetState_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetState_NativeFunction);
        GetState_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetState_NativeFunction, "ReturnValue");
        
        
    }
    
    protected MovieSceneCaptureProtocolBase(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // Function /Script/MovieSceneCapture.MovieSceneCaptureProtocolBase:IsCapturing
    static readonly IntPtr IsCapturing_NativeFunction;
    static readonly int IsCapturing_ParamsSize;
    static readonly int IsCapturing_ReturnValue_Offset;
    
    public bool IsCapturing()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[IsCapturing_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, IsCapturing_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, IsCapturing_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/MovieSceneCapture.MovieSceneCaptureProtocolBase:GetState
    static readonly IntPtr GetState_NativeFunction;
    static readonly int GetState_ParamsSize;
    static readonly int GetState_ReturnValue_Offset;
    
    public UnrealSharp.MovieSceneCapture.EMovieSceneCaptureProtocolState GetState()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetState_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetState_NativeFunction, ParamsBuffer);
            
            UnrealSharp.MovieSceneCapture.EMovieSceneCaptureProtocolState returnValue;
            returnValue = BlittableMarshaller<UnrealSharp.MovieSceneCapture.EMovieSceneCaptureProtocolState>.FromNative(IntPtr.Add(ParamsBuffer, GetState_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    
}