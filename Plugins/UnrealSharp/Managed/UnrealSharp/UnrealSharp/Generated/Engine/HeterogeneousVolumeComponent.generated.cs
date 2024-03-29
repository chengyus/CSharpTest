// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UClass]
public partial class HeterogeneousVolumeComponent : UnrealSharp.Engine.MeshComponent
{
    
    static HeterogeneousVolumeComponent()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("HeterogeneousVolumeComponent");
        
        VolumeResolution_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "VolumeResolution");
        Frame_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Frame");
        
        SetStartFrame_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetStartFrame");
        SetStartFrame_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetStartFrame_NativeFunction);
        SetStartFrame_NewValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetStartFrame_NativeFunction, "NewValue");
        SetPlaying_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetPlaying");
        SetPlaying_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetPlaying_NativeFunction);
        SetPlaying_NewValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetPlaying_NativeFunction, "NewValue");
        SetLooping_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetLooping");
        SetLooping_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetLooping_NativeFunction);
        SetLooping_NewValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetLooping_NativeFunction, "NewValue");
        SetFrameRate_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetFrameRate");
        SetFrameRate_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetFrameRate_NativeFunction);
        SetFrameRate_NewValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetFrameRate_NativeFunction, "NewValue");
        SetFrame_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetFrame");
        SetFrame_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetFrame_NativeFunction);
        SetFrame_NewValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetFrame_NativeFunction, "NewValue");
        SetEndFrame_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetEndFrame");
        SetEndFrame_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetEndFrame_NativeFunction);
        SetEndFrame_NewValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetEndFrame_NativeFunction, "NewValue");
        Play_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "Play");
        
        
    }
    
    protected HeterogeneousVolumeComponent(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // StructProperty /Script/Engine.HeterogeneousVolumeComponent:VolumeResolution
    static readonly int VolumeResolution_Offset;
    
    public UnrealSharp.CoreUObject.IntVector VolumeResolution
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<UnrealSharp.CoreUObject.IntVector>.FromNative(IntPtr.Add(NativeObject, VolumeResolution_Offset), 0, this);
        }
    }
    
    // FloatProperty /Script/Engine.HeterogeneousVolumeComponent:Frame
    static readonly int Frame_Offset;
    
    public float Frame
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, Frame_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<float>.ToNative(IntPtr.Add(NativeObject, Frame_Offset), 0, this, value);
        }
    }
    
    // Function /Script/Engine.HeterogeneousVolumeComponent:SetStartFrame
    static readonly IntPtr SetStartFrame_NativeFunction;
    static readonly int SetStartFrame_ParamsSize;
    static readonly int SetStartFrame_NewValue_Offset;
    
    public void SetStartFrame(float newValue)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetStartFrame_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, SetStartFrame_NewValue_Offset), 0, null, newValue);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetStartFrame_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/Engine.HeterogeneousVolumeComponent:SetPlaying
    static readonly IntPtr SetPlaying_NativeFunction;
    static readonly int SetPlaying_ParamsSize;
    static readonly int SetPlaying_NewValue_Offset;
    
    public void SetPlaying(bool newValue)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetPlaying_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, SetPlaying_NewValue_Offset), 0, null, newValue);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetPlaying_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/Engine.HeterogeneousVolumeComponent:SetLooping
    static readonly IntPtr SetLooping_NativeFunction;
    static readonly int SetLooping_ParamsSize;
    static readonly int SetLooping_NewValue_Offset;
    
    public void SetLooping(bool newValue)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetLooping_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, SetLooping_NewValue_Offset), 0, null, newValue);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetLooping_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/Engine.HeterogeneousVolumeComponent:SetFrameRate
    static readonly IntPtr SetFrameRate_NativeFunction;
    static readonly int SetFrameRate_ParamsSize;
    static readonly int SetFrameRate_NewValue_Offset;
    
    public void SetFrameRate(float newValue)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetFrameRate_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, SetFrameRate_NewValue_Offset), 0, null, newValue);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetFrameRate_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/Engine.HeterogeneousVolumeComponent:SetFrame
    static readonly IntPtr SetFrame_NativeFunction;
    static readonly int SetFrame_ParamsSize;
    static readonly int SetFrame_NewValue_Offset;
    
    public void SetFrame(float newValue)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetFrame_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, SetFrame_NewValue_Offset), 0, null, newValue);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetFrame_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/Engine.HeterogeneousVolumeComponent:SetEndFrame
    static readonly IntPtr SetEndFrame_NativeFunction;
    static readonly int SetEndFrame_ParamsSize;
    static readonly int SetEndFrame_NewValue_Offset;
    
    public void SetEndFrame(float newValue)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetEndFrame_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, SetEndFrame_NewValue_Offset), 0, null, newValue);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetEndFrame_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/Engine.HeterogeneousVolumeComponent:Play
    static readonly IntPtr Play_NativeFunction;
    
    public void Play()
    {
        unsafe
        {
            UObjectExporter.CallInvokeNativeFunction(NativeObject, Play_NativeFunction, IntPtr.Zero);
        }
    }
    
    
}