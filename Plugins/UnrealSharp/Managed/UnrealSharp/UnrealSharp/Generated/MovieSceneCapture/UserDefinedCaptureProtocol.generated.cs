// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.MovieSceneCapture;

[UClass]
abstract public partial class UserDefinedCaptureProtocol : UnrealSharp.MovieSceneCapture.MovieSceneImageCaptureProtocolBase
{
    
    static UserDefinedCaptureProtocol()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("UserDefinedCaptureProtocol");
        
        World_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "World");
        
        StopCapturingFinalPixels_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "StopCapturingFinalPixels");
        StartCapturingFinalPixels_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "StartCapturingFinalPixels");
        StartCapturingFinalPixels_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(StartCapturingFinalPixels_NativeFunction);
        StartCapturingFinalPixels_StreamID_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(StartCapturingFinalPixels_NativeFunction, "StreamID");
        ResolveBuffer_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "ResolveBuffer");
        ResolveBuffer_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(ResolveBuffer_NativeFunction);
        ResolveBuffer_Buffer_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ResolveBuffer_NativeFunction, "Buffer");
        ResolveBuffer_BufferID_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ResolveBuffer_NativeFunction, "BufferID");
        GetCurrentFrameMetrics_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetCurrentFrameMetrics");
        GetCurrentFrameMetrics_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetCurrentFrameMetrics_NativeFunction);
        GetCurrentFrameMetrics_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetCurrentFrameMetrics_NativeFunction, "ReturnValue");
        GenerateFilename_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GenerateFilename");
        GenerateFilename_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GenerateFilename_NativeFunction);
        GenerateFilename_InFrameMetrics_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GenerateFilename_NativeFunction, "InFrameMetrics");
        GenerateFilename_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GenerateFilename_NativeFunction, "ReturnValue");
        
        IntPtr OnSetup_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "OnSetup");
        OnSetup_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(OnSetup_NativeFunction);
        OnSetup_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(OnSetup_NativeFunction, "ReturnValue");
        
        IntPtr OnPixelsReceived_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "OnPixelsReceived");
        OnPixelsReceived_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(OnPixelsReceived_NativeFunction);
        OnPixelsReceived_Pixels_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(OnPixelsReceived_NativeFunction, "Pixels");
        OnPixelsReceived_ID_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(OnPixelsReceived_NativeFunction, "ID");
        OnPixelsReceived_FrameMetrics_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(OnPixelsReceived_NativeFunction, "FrameMetrics");
        
        IntPtr OnCanFinalize_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "OnCanFinalize");
        OnCanFinalize_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(OnCanFinalize_NativeFunction);
        OnCanFinalize_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(OnCanFinalize_NativeFunction, "ReturnValue");
        
        
    }
    
    protected UserDefinedCaptureProtocol(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // ObjectProperty /Script/MovieSceneCapture.UserDefinedCaptureProtocol:World
    static readonly int World_Offset;
    
    public UnrealSharp.Engine.World World
    {
        get
        {
            CheckObjectForValidity();
            return ObjectMarshaller<UnrealSharp.Engine.World>.FromNative(IntPtr.Add(NativeObject, World_Offset), 0, this);
        }
    }
    
    // Function /Script/MovieSceneCapture.UserDefinedCaptureProtocol:StopCapturingFinalPixels
    static readonly IntPtr StopCapturingFinalPixels_NativeFunction;
    
    public void StopCapturingFinalPixels()
    {
        unsafe
        {
            UObjectExporter.CallInvokeNativeFunction(NativeObject, StopCapturingFinalPixels_NativeFunction, IntPtr.Zero);
        }
    }
    
    // Function /Script/MovieSceneCapture.UserDefinedCaptureProtocol:StartCapturingFinalPixels
    static readonly IntPtr StartCapturingFinalPixels_NativeFunction;
    static readonly int StartCapturingFinalPixels_ParamsSize;
    static readonly int StartCapturingFinalPixels_StreamID_Offset;
    
    public void StartCapturingFinalPixels(UnrealSharp.MovieSceneCapture.CapturedPixelsID streamID)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[StartCapturingFinalPixels_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            UnrealSharp.MovieSceneCapture.CapturedPixelsIDMarshaler.ToNative(IntPtr.Add(ParamsBuffer, StartCapturingFinalPixels_StreamID_Offset), 0, null, streamID);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, StartCapturingFinalPixels_NativeFunction, ParamsBuffer);
            
            
        }
    }
    
    // Function /Script/MovieSceneCapture.UserDefinedCaptureProtocol:ResolveBuffer
    static readonly IntPtr ResolveBuffer_NativeFunction;
    static readonly int ResolveBuffer_ParamsSize;
    static readonly int ResolveBuffer_Buffer_Offset;
    static readonly int ResolveBuffer_BufferID_Offset;
    
    public void ResolveBuffer(UnrealSharp.Engine.Texture buffer, UnrealSharp.MovieSceneCapture.CapturedPixelsID bufferID)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[ResolveBuffer_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.Engine.Texture>.ToNative(IntPtr.Add(ParamsBuffer, ResolveBuffer_Buffer_Offset), 0, null, buffer);
            UnrealSharp.MovieSceneCapture.CapturedPixelsIDMarshaler.ToNative(IntPtr.Add(ParamsBuffer, ResolveBuffer_BufferID_Offset), 0, null, bufferID);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, ResolveBuffer_NativeFunction, ParamsBuffer);
            
            
        }
    }
    
    // Function /Script/MovieSceneCapture.UserDefinedCaptureProtocol:GetCurrentFrameMetrics
    static readonly IntPtr GetCurrentFrameMetrics_NativeFunction;
    static readonly int GetCurrentFrameMetrics_ParamsSize;
    static readonly int GetCurrentFrameMetrics_ReturnValue_Offset;
    
    public UnrealSharp.MovieSceneCapture.FrameMetrics GetCurrentFrameMetrics()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetCurrentFrameMetrics_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetCurrentFrameMetrics_NativeFunction, ParamsBuffer);
            
            UnrealSharp.MovieSceneCapture.FrameMetrics returnValue;
            returnValue = BlittableMarshaller<UnrealSharp.MovieSceneCapture.FrameMetrics>.FromNative(IntPtr.Add(ParamsBuffer, GetCurrentFrameMetrics_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/MovieSceneCapture.UserDefinedCaptureProtocol:GenerateFilename
    static readonly IntPtr GenerateFilename_NativeFunction;
    static readonly int GenerateFilename_ParamsSize;
    static readonly int GenerateFilename_InFrameMetrics_Offset;
    static readonly int GenerateFilename_ReturnValue_Offset;
    
    public string GenerateFilename(UnrealSharp.MovieSceneCapture.FrameMetrics inFrameMetrics)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GenerateFilename_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<UnrealSharp.MovieSceneCapture.FrameMetrics>.ToNative(IntPtr.Add(ParamsBuffer, GenerateFilename_InFrameMetrics_Offset), 0, null, inFrameMetrics);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GenerateFilename_NativeFunction, ParamsBuffer);
            
            string returnValue;
            IntPtr ReturnValue_NativePtr = IntPtr.Add(ParamsBuffer,GenerateFilename_ReturnValue_Offset);
            returnValue = StringMarshaller.FromNative(ReturnValue_NativePtr,0,null);
            StringMarshaller.DestructInstance(ReturnValue_NativePtr, 0);
            
            return returnValue;
        }
    }
    
    // Function /Script/MovieSceneCapture.UserDefinedCaptureProtocol:OnWarmUp
    IntPtr OnWarmUp_NativeFunction;
    
    [UFunction(FunctionFlags.BlueprintEvent)]
    protected virtual void OnWarmUp()
    {
        unsafe
        {
            if (OnWarmUp_NativeFunction == IntPtr.Zero)
            {
                OnWarmUp_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "OnWarmUp");
            }
            UObjectExporter.CallInvokeNativeFunction(NativeObject, OnWarmUp_NativeFunction, IntPtr.Zero);
        }
    }
    
    //Hide implementation function from Intellisense/ReSharper
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual void OnWarmUp_Implementation()
    {
    }
    void Invoke_OnWarmUp(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            OnWarmUp_Implementation();
        }
    }
    
    // Function /Script/MovieSceneCapture.UserDefinedCaptureProtocol:OnTick
    IntPtr OnTick_NativeFunction;
    
    [UFunction(FunctionFlags.BlueprintEvent)]
    protected virtual void OnTick()
    {
        unsafe
        {
            if (OnTick_NativeFunction == IntPtr.Zero)
            {
                OnTick_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "OnTick");
            }
            UObjectExporter.CallInvokeNativeFunction(NativeObject, OnTick_NativeFunction, IntPtr.Zero);
        }
    }
    
    //Hide implementation function from Intellisense/ReSharper
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual void OnTick_Implementation()
    {
    }
    void Invoke_OnTick(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            OnTick_Implementation();
        }
    }
    
    // Function /Script/MovieSceneCapture.UserDefinedCaptureProtocol:OnStartCapture
    IntPtr OnStartCapture_NativeFunction;
    
    [UFunction(FunctionFlags.BlueprintEvent)]
    protected virtual void OnStartCapture()
    {
        unsafe
        {
            if (OnStartCapture_NativeFunction == IntPtr.Zero)
            {
                OnStartCapture_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "OnStartCapture");
            }
            UObjectExporter.CallInvokeNativeFunction(NativeObject, OnStartCapture_NativeFunction, IntPtr.Zero);
        }
    }
    
    //Hide implementation function from Intellisense/ReSharper
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual void OnStartCapture_Implementation()
    {
    }
    void Invoke_OnStartCapture(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            OnStartCapture_Implementation();
        }
    }
    
    // Function /Script/MovieSceneCapture.UserDefinedCaptureProtocol:OnSetup
    IntPtr OnSetup_NativeFunction;
    static readonly int OnSetup_ParamsSize;
    static readonly int OnSetup_ReturnValue_Offset;
    
    [UFunction(FunctionFlags.BlueprintEvent)]
    protected virtual bool OnSetup()
    {
        unsafe
        {
            if (OnSetup_NativeFunction == IntPtr.Zero)
            {
                OnSetup_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "OnSetup");
            }
            byte* ParamsBufferAllocation = stackalloc byte[OnSetup_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, OnSetup_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, OnSetup_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    //Hide implementation function from Intellisense/ReSharper
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual bool OnSetup_Implementation()
    {
        return default(bool);
    }
    void Invoke_OnSetup(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            bool returnValue = OnSetup_Implementation();
            BoolMarshaller.ToNative(IntPtr.Add(returnBuffer, 0), 0, null, returnValue);
        }
    }
    
    // Function /Script/MovieSceneCapture.UserDefinedCaptureProtocol:OnPreTick
    IntPtr OnPreTick_NativeFunction;
    
    [UFunction(FunctionFlags.BlueprintEvent)]
    protected virtual void OnPreTick()
    {
        unsafe
        {
            if (OnPreTick_NativeFunction == IntPtr.Zero)
            {
                OnPreTick_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "OnPreTick");
            }
            UObjectExporter.CallInvokeNativeFunction(NativeObject, OnPreTick_NativeFunction, IntPtr.Zero);
        }
    }
    
    //Hide implementation function from Intellisense/ReSharper
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual void OnPreTick_Implementation()
    {
    }
    void Invoke_OnPreTick(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            OnPreTick_Implementation();
        }
    }
    
    // Function /Script/MovieSceneCapture.UserDefinedCaptureProtocol:OnPixelsReceived
    IntPtr OnPixelsReceived_NativeFunction;
    static readonly int OnPixelsReceived_ParamsSize;
    static readonly int OnPixelsReceived_Pixels_Offset;
    static readonly int OnPixelsReceived_ID_Offset;
    static readonly int OnPixelsReceived_FrameMetrics_Offset;
    
    [UFunction(FunctionFlags.BlueprintEvent)]
    protected virtual void OnPixelsReceived(UnrealSharp.MovieSceneCapture.CapturedPixels pixels, UnrealSharp.MovieSceneCapture.CapturedPixelsID iD, UnrealSharp.MovieSceneCapture.FrameMetrics frameMetrics)
    {
        unsafe
        {
            if (OnPixelsReceived_NativeFunction == IntPtr.Zero)
            {
                OnPixelsReceived_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "OnPixelsReceived");
            }
            byte* ParamsBufferAllocation = stackalloc byte[OnPixelsReceived_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            UnrealSharp.MovieSceneCapture.CapturedPixelsMarshaler.ToNative(IntPtr.Add(ParamsBuffer, OnPixelsReceived_Pixels_Offset), 0, null, pixels);
            UnrealSharp.MovieSceneCapture.CapturedPixelsIDMarshaler.ToNative(IntPtr.Add(ParamsBuffer, OnPixelsReceived_ID_Offset), 0, null, iD);
            BlittableMarshaller<UnrealSharp.MovieSceneCapture.FrameMetrics>.ToNative(IntPtr.Add(ParamsBuffer, OnPixelsReceived_FrameMetrics_Offset), 0, null, frameMetrics);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, OnPixelsReceived_NativeFunction, ParamsBuffer);
            
            
        }
    }
    
    //Hide implementation function from Intellisense/ReSharper
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual void OnPixelsReceived_Implementation(UnrealSharp.MovieSceneCapture.CapturedPixels pixels, UnrealSharp.MovieSceneCapture.CapturedPixelsID iD, UnrealSharp.MovieSceneCapture.FrameMetrics frameMetrics)
    {
    }
    void Invoke_OnPixelsReceived(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            UnrealSharp.MovieSceneCapture.CapturedPixels pixels = UnrealSharp.MovieSceneCapture.CapturedPixelsMarshaler.FromNative(IntPtr.Add(buffer, OnPixelsReceived_Pixels_Offset), 0, null);
            UnrealSharp.MovieSceneCapture.CapturedPixelsID iD = UnrealSharp.MovieSceneCapture.CapturedPixelsIDMarshaler.FromNative(IntPtr.Add(buffer, OnPixelsReceived_ID_Offset), 0, null);
            UnrealSharp.MovieSceneCapture.FrameMetrics frameMetrics = BlittableMarshaller<UnrealSharp.MovieSceneCapture.FrameMetrics>.FromNative(IntPtr.Add(buffer, OnPixelsReceived_FrameMetrics_Offset), 0, null);
            OnPixelsReceived_Implementation(pixels, iD, frameMetrics);
        }
    }
    
    // Function /Script/MovieSceneCapture.UserDefinedCaptureProtocol:OnPauseCapture
    IntPtr OnPauseCapture_NativeFunction;
    
    [UFunction(FunctionFlags.BlueprintEvent)]
    protected virtual void OnPauseCapture()
    {
        unsafe
        {
            if (OnPauseCapture_NativeFunction == IntPtr.Zero)
            {
                OnPauseCapture_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "OnPauseCapture");
            }
            UObjectExporter.CallInvokeNativeFunction(NativeObject, OnPauseCapture_NativeFunction, IntPtr.Zero);
        }
    }
    
    //Hide implementation function from Intellisense/ReSharper
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual void OnPauseCapture_Implementation()
    {
    }
    void Invoke_OnPauseCapture(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            OnPauseCapture_Implementation();
        }
    }
    
    // Function /Script/MovieSceneCapture.UserDefinedCaptureProtocol:OnFinalize
    IntPtr OnFinalize_NativeFunction;
    
    [UFunction(FunctionFlags.BlueprintEvent)]
    protected virtual void OnFinalize()
    {
        unsafe
        {
            if (OnFinalize_NativeFunction == IntPtr.Zero)
            {
                OnFinalize_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "OnFinalize");
            }
            UObjectExporter.CallInvokeNativeFunction(NativeObject, OnFinalize_NativeFunction, IntPtr.Zero);
        }
    }
    
    //Hide implementation function from Intellisense/ReSharper
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual void OnFinalize_Implementation()
    {
    }
    void Invoke_OnFinalize(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            OnFinalize_Implementation();
        }
    }
    
    // Function /Script/MovieSceneCapture.UserDefinedCaptureProtocol:OnCaptureFrame
    IntPtr OnCaptureFrame_NativeFunction;
    
    [UFunction(FunctionFlags.BlueprintEvent)]
    protected virtual void OnCaptureFrame()
    {
        unsafe
        {
            if (OnCaptureFrame_NativeFunction == IntPtr.Zero)
            {
                OnCaptureFrame_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "OnCaptureFrame");
            }
            UObjectExporter.CallInvokeNativeFunction(NativeObject, OnCaptureFrame_NativeFunction, IntPtr.Zero);
        }
    }
    
    //Hide implementation function from Intellisense/ReSharper
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual void OnCaptureFrame_Implementation()
    {
    }
    void Invoke_OnCaptureFrame(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            OnCaptureFrame_Implementation();
        }
    }
    
    // Function /Script/MovieSceneCapture.UserDefinedCaptureProtocol:OnCanFinalize
    IntPtr OnCanFinalize_NativeFunction;
    static readonly int OnCanFinalize_ParamsSize;
    static readonly int OnCanFinalize_ReturnValue_Offset;
    
    [UFunction(FunctionFlags.BlueprintEvent)]
    protected virtual bool OnCanFinalize()
    {
        unsafe
        {
            if (OnCanFinalize_NativeFunction == IntPtr.Zero)
            {
                OnCanFinalize_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "OnCanFinalize");
            }
            byte* ParamsBufferAllocation = stackalloc byte[OnCanFinalize_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, OnCanFinalize_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, OnCanFinalize_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    //Hide implementation function from Intellisense/ReSharper
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual bool OnCanFinalize_Implementation()
    {
        return default(bool);
    }
    void Invoke_OnCanFinalize(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            bool returnValue = OnCanFinalize_Implementation();
            BoolMarshaller.ToNative(IntPtr.Add(returnBuffer, 0), 0, null, returnValue);
        }
    }
    
    // Function /Script/MovieSceneCapture.UserDefinedCaptureProtocol:OnBeginFinalize
    IntPtr OnBeginFinalize_NativeFunction;
    
    [UFunction(FunctionFlags.BlueprintEvent)]
    protected virtual void OnBeginFinalize()
    {
        unsafe
        {
            if (OnBeginFinalize_NativeFunction == IntPtr.Zero)
            {
                OnBeginFinalize_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "OnBeginFinalize");
            }
            UObjectExporter.CallInvokeNativeFunction(NativeObject, OnBeginFinalize_NativeFunction, IntPtr.Zero);
        }
    }
    
    //Hide implementation function from Intellisense/ReSharper
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual void OnBeginFinalize_Implementation()
    {
    }
    void Invoke_OnBeginFinalize(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            OnBeginFinalize_Implementation();
        }
    }
    
    
}