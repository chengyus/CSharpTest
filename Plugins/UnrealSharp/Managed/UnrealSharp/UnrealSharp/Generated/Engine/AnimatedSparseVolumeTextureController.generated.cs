// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UClass]
public partial class AnimatedSparseVolumeTextureController : UnrealSharp.CoreUObject.Object
{
    
    static AnimatedSparseVolumeTextureController()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("AnimatedSparseVolumeTextureController");
        
        SparseVolumeTexture_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SparseVolumeTexture");
        Time_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Time");
        bIsPlaying_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIsPlaying");
        FrameRate_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FrameRate");
        MipLevel_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MipLevel");
        bBlockingStreamingRequests_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bBlockingStreamingRequests");
        
        Update_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "Update");
        Update_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(Update_NativeFunction);
        Update_DeltaTime_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(Update_NativeFunction, "DeltaTime");
        Stop_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "Stop");
        Play_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "Play");
        Pause_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "Pause");
        GetFrameByIndex_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetFrameByIndex");
        GetFrameByIndex_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetFrameByIndex_NativeFunction);
        GetFrameByIndex_FrameIndex_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetFrameByIndex_NativeFunction, "FrameIndex");
        GetFrameByIndex_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetFrameByIndex_NativeFunction, "ReturnValue");
        GetFractionalFrameIndex_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetFractionalFrameIndex");
        GetFractionalFrameIndex_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetFractionalFrameIndex_NativeFunction);
        GetFractionalFrameIndex_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetFractionalFrameIndex_NativeFunction, "ReturnValue");
        GetDuration_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetDuration");
        GetDuration_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetDuration_NativeFunction);
        GetDuration_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetDuration_NativeFunction, "ReturnValue");
        GetCurrentFramesForInterpolation_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetCurrentFramesForInterpolation");
        GetCurrentFramesForInterpolation_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetCurrentFramesForInterpolation_NativeFunction);
        GetCurrentFramesForInterpolation_Frame0_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetCurrentFramesForInterpolation_NativeFunction, "Frame0");
        GetCurrentFramesForInterpolation_Frame1_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetCurrentFramesForInterpolation_NativeFunction, "Frame1");
        GetCurrentFramesForInterpolation_LerpAlpha_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetCurrentFramesForInterpolation_NativeFunction, "LerpAlpha");
        GetCurrentFrame_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetCurrentFrame");
        GetCurrentFrame_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetCurrentFrame_NativeFunction);
        GetCurrentFrame_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetCurrentFrame_NativeFunction, "ReturnValue");
        
        
    }
    
    protected AnimatedSparseVolumeTextureController(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // ObjectProperty /Script/Engine.AnimatedSparseVolumeTextureController:SparseVolumeTexture
    static readonly int SparseVolumeTexture_Offset;
    
    public UnrealSharp.Engine.SparseVolumeTexture SparseVolumeTexture
    {
        get
        {
            CheckObjectForValidity();
            return ObjectMarshaller<UnrealSharp.Engine.SparseVolumeTexture>.FromNative(IntPtr.Add(NativeObject, SparseVolumeTexture_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            ObjectMarshaller<UnrealSharp.Engine.SparseVolumeTexture>.ToNative(IntPtr.Add(NativeObject, SparseVolumeTexture_Offset), 0, this, value);
        }
    }
    
    // FloatProperty /Script/Engine.AnimatedSparseVolumeTextureController:Time
    static readonly int Time_Offset;
    
    public float Time
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, Time_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<float>.ToNative(IntPtr.Add(NativeObject, Time_Offset), 0, this, value);
        }
    }
    
    // BoolProperty /Script/Engine.AnimatedSparseVolumeTextureController:bIsPlaying
    static readonly int bIsPlaying_Offset;
    
    public bool bIsPlaying
    {
        get
        {
            CheckObjectForValidity();
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bIsPlaying_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bIsPlaying_Offset), 0, this, value);
        }
    }
    
    // FloatProperty /Script/Engine.AnimatedSparseVolumeTextureController:FrameRate
    static readonly int FrameRate_Offset;
    
    public float FrameRate
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, FrameRate_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<float>.ToNative(IntPtr.Add(NativeObject, FrameRate_Offset), 0, this, value);
        }
    }
    
    // IntProperty /Script/Engine.AnimatedSparseVolumeTextureController:MipLevel
    static readonly int MipLevel_Offset;
    
    public int MipLevel
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<int>.FromNative(IntPtr.Add(NativeObject, MipLevel_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<int>.ToNative(IntPtr.Add(NativeObject, MipLevel_Offset), 0, this, value);
        }
    }
    
    // BoolProperty /Script/Engine.AnimatedSparseVolumeTextureController:bBlockingStreamingRequests
    static readonly int bBlockingStreamingRequests_Offset;
    
    public bool bBlockingStreamingRequests
    {
        get
        {
            CheckObjectForValidity();
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bBlockingStreamingRequests_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bBlockingStreamingRequests_Offset), 0, this, value);
        }
    }
    
    // Function /Script/Engine.AnimatedSparseVolumeTextureController:Update
    static readonly IntPtr Update_NativeFunction;
    static readonly int Update_ParamsSize;
    static readonly int Update_DeltaTime_Offset;
    
    public void Update(float deltaTime)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[Update_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, Update_DeltaTime_Offset), 0, null, deltaTime);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, Update_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/Engine.AnimatedSparseVolumeTextureController:Stop
    static readonly IntPtr Stop_NativeFunction;
    
    public void Stop()
    {
        unsafe
        {
            UObjectExporter.CallInvokeNativeFunction(NativeObject, Stop_NativeFunction, IntPtr.Zero);
        }
    }
    
    // Function /Script/Engine.AnimatedSparseVolumeTextureController:Play
    static readonly IntPtr Play_NativeFunction;
    
    public void Play()
    {
        unsafe
        {
            UObjectExporter.CallInvokeNativeFunction(NativeObject, Play_NativeFunction, IntPtr.Zero);
        }
    }
    
    // Function /Script/Engine.AnimatedSparseVolumeTextureController:Pause
    static readonly IntPtr Pause_NativeFunction;
    
    public void Pause()
    {
        unsafe
        {
            UObjectExporter.CallInvokeNativeFunction(NativeObject, Pause_NativeFunction, IntPtr.Zero);
        }
    }
    
    // Function /Script/Engine.AnimatedSparseVolumeTextureController:GetFrameByIndex
    static readonly IntPtr GetFrameByIndex_NativeFunction;
    static readonly int GetFrameByIndex_ParamsSize;
    static readonly int GetFrameByIndex_FrameIndex_Offset;
    static readonly int GetFrameByIndex_ReturnValue_Offset;
    
    public UnrealSharp.Engine.SparseVolumeTextureFrame GetFrameByIndex(int frameIndex)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetFrameByIndex_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<int>.ToNative(IntPtr.Add(ParamsBuffer, GetFrameByIndex_FrameIndex_Offset), 0, null, frameIndex);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetFrameByIndex_NativeFunction, ParamsBuffer);
            
            UnrealSharp.Engine.SparseVolumeTextureFrame returnValue;
            returnValue = ObjectMarshaller<UnrealSharp.Engine.SparseVolumeTextureFrame>.FromNative(IntPtr.Add(ParamsBuffer, GetFrameByIndex_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/Engine.AnimatedSparseVolumeTextureController:GetFractionalFrameIndex
    static readonly IntPtr GetFractionalFrameIndex_NativeFunction;
    static readonly int GetFractionalFrameIndex_ParamsSize;
    static readonly int GetFractionalFrameIndex_ReturnValue_Offset;
    
    public float GetFractionalFrameIndex()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetFractionalFrameIndex_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetFractionalFrameIndex_NativeFunction, ParamsBuffer);
            
            float returnValue;
            returnValue = BlittableMarshaller<float>.FromNative(IntPtr.Add(ParamsBuffer, GetFractionalFrameIndex_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/Engine.AnimatedSparseVolumeTextureController:GetDuration
    static readonly IntPtr GetDuration_NativeFunction;
    static readonly int GetDuration_ParamsSize;
    static readonly int GetDuration_ReturnValue_Offset;
    
    public float GetDuration()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetDuration_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetDuration_NativeFunction, ParamsBuffer);
            
            float returnValue;
            returnValue = BlittableMarshaller<float>.FromNative(IntPtr.Add(ParamsBuffer, GetDuration_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/Engine.AnimatedSparseVolumeTextureController:GetCurrentFramesForInterpolation
    static readonly IntPtr GetCurrentFramesForInterpolation_NativeFunction;
    static readonly int GetCurrentFramesForInterpolation_ParamsSize;
    static readonly int GetCurrentFramesForInterpolation_Frame0_Offset;
    static readonly int GetCurrentFramesForInterpolation_Frame1_Offset;
    static readonly int GetCurrentFramesForInterpolation_LerpAlpha_Offset;
    
    public void GetCurrentFramesForInterpolation(out UnrealSharp.Engine.SparseVolumeTextureFrame frame0, out UnrealSharp.Engine.SparseVolumeTextureFrame frame1, out float lerpAlpha)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetCurrentFramesForInterpolation_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetCurrentFramesForInterpolation_NativeFunction, ParamsBuffer);
            
            frame0 = ObjectMarshaller<UnrealSharp.Engine.SparseVolumeTextureFrame>.FromNative(IntPtr.Add(ParamsBuffer, GetCurrentFramesForInterpolation_Frame0_Offset), 0, null);
            frame1 = ObjectMarshaller<UnrealSharp.Engine.SparseVolumeTextureFrame>.FromNative(IntPtr.Add(ParamsBuffer, GetCurrentFramesForInterpolation_Frame1_Offset), 0, null);
            lerpAlpha = BlittableMarshaller<float>.FromNative(IntPtr.Add(ParamsBuffer, GetCurrentFramesForInterpolation_LerpAlpha_Offset), 0, null);
            
        }
    }
    
    // Function /Script/Engine.AnimatedSparseVolumeTextureController:GetCurrentFrame
    static readonly IntPtr GetCurrentFrame_NativeFunction;
    static readonly int GetCurrentFrame_ParamsSize;
    static readonly int GetCurrentFrame_ReturnValue_Offset;
    
    public UnrealSharp.Engine.SparseVolumeTextureFrame GetCurrentFrame()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetCurrentFrame_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetCurrentFrame_NativeFunction, ParamsBuffer);
            
            UnrealSharp.Engine.SparseVolumeTextureFrame returnValue;
            returnValue = ObjectMarshaller<UnrealSharp.Engine.SparseVolumeTextureFrame>.FromNative(IntPtr.Add(ParamsBuffer, GetCurrentFrame_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    
}