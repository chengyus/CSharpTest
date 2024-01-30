// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.CSharpForUE;

[UClass]
abstract public partial class CSWorldSubsystem : UnrealSharp.Engine.TickableWorldSubsystem
{
    
    static CSWorldSubsystem()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("CSWorldSubsystem");
        
        
        
        IntPtr K2_Tick_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "K2_Tick");
        K2_Tick_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(K2_Tick_NativeFunction);
        K2_Tick_DeltaTime_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(K2_Tick_NativeFunction, "DeltaTime");
        
        IntPtr K2_ShouldCreateSubsystem_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "K2_ShouldCreateSubsystem");
        K2_ShouldCreateSubsystem_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(K2_ShouldCreateSubsystem_NativeFunction);
        K2_ShouldCreateSubsystem_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(K2_ShouldCreateSubsystem_NativeFunction, "ReturnValue");
        
        
    }
    
    protected CSWorldSubsystem(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // Function /Script/CSharpForUE.CSWorldSubsystem:K2_UpdateStreamingState
    IntPtr K2_UpdateStreamingState_NativeFunction;
    
    [UFunction(FunctionFlags.BlueprintEvent)]
    protected virtual void UpdateStreamingState()
    {
        unsafe
        {
            if (K2_UpdateStreamingState_NativeFunction == IntPtr.Zero)
            {
                K2_UpdateStreamingState_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "K2_UpdateStreamingState");
            }
            UObjectExporter.CallInvokeNativeFunction(NativeObject, K2_UpdateStreamingState_NativeFunction, IntPtr.Zero);
        }
    }
    
    //Hide implementation function from Intellisense/ReSharper
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual void K2_UpdateStreamingState_Implementation()
    {
    }
    void Invoke_K2_UpdateStreamingState(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            K2_UpdateStreamingState_Implementation();
        }
    }
    
    // Function /Script/CSharpForUE.CSWorldSubsystem:K2_Tick
    IntPtr K2_Tick_NativeFunction;
    static readonly int K2_Tick_ParamsSize;
    static readonly int K2_Tick_DeltaTime_Offset;
    
    [UFunction(FunctionFlags.BlueprintEvent)]
    protected virtual void Tick(float deltaTime)
    {
        unsafe
        {
            if (K2_Tick_NativeFunction == IntPtr.Zero)
            {
                K2_Tick_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "K2_Tick");
            }
            byte* ParamsBufferAllocation = stackalloc byte[K2_Tick_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, K2_Tick_DeltaTime_Offset), 0, null, deltaTime);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, K2_Tick_NativeFunction, ParamsBuffer);
            
        }
    }
    
    //Hide implementation function from Intellisense/ReSharper
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual void K2_Tick_Implementation(float deltaTime)
    {
    }
    void Invoke_K2_Tick(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            float deltaTime = BlittableMarshaller<float>.FromNative(IntPtr.Add(buffer, K2_Tick_DeltaTime_Offset), 0, null);
            K2_Tick_Implementation(deltaTime);
        }
    }
    
    // Function /Script/CSharpForUE.CSWorldSubsystem:K2_ShouldCreateSubsystem
    IntPtr K2_ShouldCreateSubsystem_NativeFunction;
    static readonly int K2_ShouldCreateSubsystem_ParamsSize;
    static readonly int K2_ShouldCreateSubsystem_ReturnValue_Offset;
    
    [UFunction(FunctionFlags.BlueprintEvent)]
    protected virtual bool ShouldCreateSubsystem()
    {
        unsafe
        {
            if (K2_ShouldCreateSubsystem_NativeFunction == IntPtr.Zero)
            {
                K2_ShouldCreateSubsystem_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "K2_ShouldCreateSubsystem");
            }
            byte* ParamsBufferAllocation = stackalloc byte[K2_ShouldCreateSubsystem_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, K2_ShouldCreateSubsystem_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, K2_ShouldCreateSubsystem_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    //Hide implementation function from Intellisense/ReSharper
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual bool K2_ShouldCreateSubsystem_Implementation()
    {
        return default(bool);
    }
    void Invoke_K2_ShouldCreateSubsystem(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            bool returnValue = K2_ShouldCreateSubsystem_Implementation();
            BoolMarshaller.ToNative(IntPtr.Add(returnBuffer, 0), 0, null, returnValue);
        }
    }
    
    // Function /Script/CSharpForUE.CSWorldSubsystem:K2_PostInitialize
    IntPtr K2_PostInitialize_NativeFunction;
    
    [UFunction(FunctionFlags.BlueprintEvent)]
    protected virtual void PostInitialize()
    {
        unsafe
        {
            if (K2_PostInitialize_NativeFunction == IntPtr.Zero)
            {
                K2_PostInitialize_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "K2_PostInitialize");
            }
            UObjectExporter.CallInvokeNativeFunction(NativeObject, K2_PostInitialize_NativeFunction, IntPtr.Zero);
        }
    }
    
    //Hide implementation function from Intellisense/ReSharper
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual void K2_PostInitialize_Implementation()
    {
    }
    void Invoke_K2_PostInitialize(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            K2_PostInitialize_Implementation();
        }
    }
    
    // Function /Script/CSharpForUE.CSWorldSubsystem:K2_OnWorldComponentsUpdated
    IntPtr K2_OnWorldComponentsUpdated_NativeFunction;
    
    [UFunction(FunctionFlags.BlueprintEvent)]
    protected virtual void OnWorldComponentsUpdated()
    {
        unsafe
        {
            if (K2_OnWorldComponentsUpdated_NativeFunction == IntPtr.Zero)
            {
                K2_OnWorldComponentsUpdated_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "K2_OnWorldComponentsUpdated");
            }
            UObjectExporter.CallInvokeNativeFunction(NativeObject, K2_OnWorldComponentsUpdated_NativeFunction, IntPtr.Zero);
        }
    }
    
    //Hide implementation function from Intellisense/ReSharper
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual void K2_OnWorldComponentsUpdated_Implementation()
    {
    }
    void Invoke_K2_OnWorldComponentsUpdated(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            K2_OnWorldComponentsUpdated_Implementation();
        }
    }
    
    // Function /Script/CSharpForUE.CSWorldSubsystem:K2_OnWorldBeginPlay
    IntPtr K2_OnWorldBeginPlay_NativeFunction;
    
    [UFunction(FunctionFlags.BlueprintEvent)]
    protected virtual void OnWorldBeginPlay()
    {
        unsafe
        {
            if (K2_OnWorldBeginPlay_NativeFunction == IntPtr.Zero)
            {
                K2_OnWorldBeginPlay_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "K2_OnWorldBeginPlay");
            }
            UObjectExporter.CallInvokeNativeFunction(NativeObject, K2_OnWorldBeginPlay_NativeFunction, IntPtr.Zero);
        }
    }
    
    //Hide implementation function from Intellisense/ReSharper
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual void K2_OnWorldBeginPlay_Implementation()
    {
    }
    void Invoke_K2_OnWorldBeginPlay(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            K2_OnWorldBeginPlay_Implementation();
        }
    }
    
    // Function /Script/CSharpForUE.CSWorldSubsystem:K2_Initialize
    IntPtr K2_Initialize_NativeFunction;
    
    [UFunction(FunctionFlags.BlueprintEvent)]
    protected virtual void Initialize()
    {
        unsafe
        {
            if (K2_Initialize_NativeFunction == IntPtr.Zero)
            {
                K2_Initialize_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "K2_Initialize");
            }
            UObjectExporter.CallInvokeNativeFunction(NativeObject, K2_Initialize_NativeFunction, IntPtr.Zero);
        }
    }
    
    //Hide implementation function from Intellisense/ReSharper
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual void K2_Initialize_Implementation()
    {
    }
    void Invoke_K2_Initialize(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            K2_Initialize_Implementation();
        }
    }
    
    // Function /Script/CSharpForUE.CSWorldSubsystem:K2_Deinitialize
    IntPtr K2_Deinitialize_NativeFunction;
    
    [UFunction(FunctionFlags.BlueprintEvent)]
    protected virtual void Deinitialize()
    {
        unsafe
        {
            if (K2_Deinitialize_NativeFunction == IntPtr.Zero)
            {
                K2_Deinitialize_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "K2_Deinitialize");
            }
            UObjectExporter.CallInvokeNativeFunction(NativeObject, K2_Deinitialize_NativeFunction, IntPtr.Zero);
        }
    }
    
    //Hide implementation function from Intellisense/ReSharper
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual void K2_Deinitialize_Implementation()
    {
    }
    void Invoke_K2_Deinitialize(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            K2_Deinitialize_Implementation();
        }
    }
    
    
}