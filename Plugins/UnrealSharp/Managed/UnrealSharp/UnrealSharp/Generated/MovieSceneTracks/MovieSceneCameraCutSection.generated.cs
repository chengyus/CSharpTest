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
public partial class MovieSceneCameraCutSection : UnrealSharp.MovieScene.MovieSceneSection, IMovieSceneEntityProvider
{
    
    static MovieSceneCameraCutSection()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("MovieSceneCameraCutSection");
        
        
        SetCameraBindingID_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetCameraBindingID");
        SetCameraBindingID_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetCameraBindingID_NativeFunction);
        SetCameraBindingID_InCameraBindingID_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetCameraBindingID_NativeFunction, "InCameraBindingID");
        GetCameraBindingID_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetCameraBindingID");
        GetCameraBindingID_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetCameraBindingID_NativeFunction);
        GetCameraBindingID_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetCameraBindingID_NativeFunction, "ReturnValue");
        
        
    }
    
    protected MovieSceneCameraCutSection(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // Function /Script/MovieSceneTracks.MovieSceneCameraCutSection:SetCameraBindingID
    static readonly IntPtr SetCameraBindingID_NativeFunction;
    static readonly int SetCameraBindingID_ParamsSize;
    static readonly int SetCameraBindingID_InCameraBindingID_Offset;
    
    public void SetCameraBindingID(UnrealSharp.MovieScene.MovieSceneObjectBindingID inCameraBindingID)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetCameraBindingID_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            UnrealSharp.MovieScene.MovieSceneObjectBindingIDMarshaler.ToNative(IntPtr.Add(ParamsBuffer, SetCameraBindingID_InCameraBindingID_Offset), 0, null, inCameraBindingID);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetCameraBindingID_NativeFunction, ParamsBuffer);
            
            
        }
    }
    
    // Function /Script/MovieSceneTracks.MovieSceneCameraCutSection:GetCameraBindingID
    static readonly IntPtr GetCameraBindingID_NativeFunction;
    static readonly int GetCameraBindingID_ParamsSize;
    static readonly int GetCameraBindingID_ReturnValue_Offset;
    
    public UnrealSharp.MovieScene.MovieSceneObjectBindingID GetCameraBindingID()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetCameraBindingID_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetCameraBindingID_NativeFunction, ParamsBuffer);
            
            UnrealSharp.MovieScene.MovieSceneObjectBindingID returnValue;
            returnValue = UnrealSharp.MovieScene.MovieSceneObjectBindingIDMarshaler.FromNative(IntPtr.Add(ParamsBuffer, GetCameraBindingID_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    
}