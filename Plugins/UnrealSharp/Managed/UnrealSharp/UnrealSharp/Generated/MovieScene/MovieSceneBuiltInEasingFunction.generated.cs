// This file is automatically generated
using UnrealSharp.MovieScene;
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.MovieScene;

[UClass]
public partial class MovieSceneBuiltInEasingFunction : UnrealSharp.CoreUObject.Object, IMovieSceneEasingFunction
{
    
    static MovieSceneBuiltInEasingFunction()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("MovieSceneBuiltInEasingFunction");
        
        
        
        IntPtr OnEvaluate_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "OnEvaluate");
        OnEvaluate_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(OnEvaluate_NativeFunction);
        OnEvaluate_Interp_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(OnEvaluate_NativeFunction, "Interp");
        OnEvaluate_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(OnEvaluate_NativeFunction, "ReturnValue");
        
        
    }
    
    protected MovieSceneBuiltInEasingFunction(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // Function /Script/MovieScene.MovieSceneEasingFunction:OnEvaluate
    IntPtr OnEvaluate_NativeFunction;
    static readonly int OnEvaluate_ParamsSize;
    static readonly int OnEvaluate_Interp_Offset;
    static readonly int OnEvaluate_ReturnValue_Offset;
    
    [UFunction(FunctionFlags.BlueprintEvent)]
    public float OnEvaluate(float interp)
    {
        unsafe
        {
            if (OnEvaluate_NativeFunction == IntPtr.Zero)
            {
                OnEvaluate_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "OnEvaluate");
            }
            byte* ParamsBufferAllocation = stackalloc byte[OnEvaluate_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, OnEvaluate_Interp_Offset), 0, null, interp);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, OnEvaluate_NativeFunction, ParamsBuffer);
            
            float returnValue;
            returnValue = BlittableMarshaller<float>.FromNative(IntPtr.Add(ParamsBuffer, OnEvaluate_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    //Hide implementation function from Intellisense/ReSharper
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual float OnEvaluate_Implementation(float interp)
    {
        return default(float);
    }
    void Invoke_OnEvaluate(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            float interp = BlittableMarshaller<float>.FromNative(IntPtr.Add(buffer, OnEvaluate_Interp_Offset), 0, null);
            float returnValue = OnEvaluate_Implementation(interp);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(returnBuffer, 0), 0, null, returnValue);
        }
    }
    
    
}