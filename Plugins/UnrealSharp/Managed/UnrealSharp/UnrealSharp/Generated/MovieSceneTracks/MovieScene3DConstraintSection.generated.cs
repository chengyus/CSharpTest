// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.MovieSceneTracks;

[UClass]
public partial class MovieScene3DConstraintSection : UnrealSharp.MovieScene.MovieSceneSection
{
    
    static MovieScene3DConstraintSection()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("MovieScene3DConstraintSection");
        
        
        SetConstraintBindingID_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetConstraintBindingID");
        SetConstraintBindingID_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetConstraintBindingID_NativeFunction);
        SetConstraintBindingID_InConstraintBindingID_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetConstraintBindingID_NativeFunction, "InConstraintBindingID");
        GetConstraintBindingID_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetConstraintBindingID");
        GetConstraintBindingID_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetConstraintBindingID_NativeFunction);
        GetConstraintBindingID_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetConstraintBindingID_NativeFunction, "ReturnValue");
        
        
    }
    
    protected MovieScene3DConstraintSection(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // Function /Script/MovieSceneTracks.MovieScene3DConstraintSection:SetConstraintBindingID
    static readonly IntPtr SetConstraintBindingID_NativeFunction;
    static readonly int SetConstraintBindingID_ParamsSize;
    static readonly int SetConstraintBindingID_InConstraintBindingID_Offset;
    
    public void SetConstraintBindingID(UnrealSharp.MovieScene.MovieSceneObjectBindingID inConstraintBindingID)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetConstraintBindingID_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            UnrealSharp.MovieScene.MovieSceneObjectBindingIDMarshaler.ToNative(IntPtr.Add(ParamsBuffer, SetConstraintBindingID_InConstraintBindingID_Offset), 0, null, inConstraintBindingID);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetConstraintBindingID_NativeFunction, ParamsBuffer);
            
            
        }
    }
    
    // Function /Script/MovieSceneTracks.MovieScene3DConstraintSection:GetConstraintBindingID
    static readonly IntPtr GetConstraintBindingID_NativeFunction;
    static readonly int GetConstraintBindingID_ParamsSize;
    static readonly int GetConstraintBindingID_ReturnValue_Offset;
    
    public UnrealSharp.MovieScene.MovieSceneObjectBindingID GetConstraintBindingID()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetConstraintBindingID_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetConstraintBindingID_NativeFunction, ParamsBuffer);
            
            UnrealSharp.MovieScene.MovieSceneObjectBindingID returnValue;
            returnValue = UnrealSharp.MovieScene.MovieSceneObjectBindingIDMarshaler.FromNative(IntPtr.Add(ParamsBuffer, GetConstraintBindingID_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    
}