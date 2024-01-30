// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ResonanceAudio;

[UClass]
public partial class ResonanceAudioReverbPluginPreset : UnrealSharp.Engine.SoundEffectSubmixPreset
{
    
    static ResonanceAudioReverbPluginPreset()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("ResonanceAudioReverbPluginPreset");
        
        
        SetRoomRotation_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetRoomRotation");
        SetRoomRotation_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetRoomRotation_NativeFunction);
        SetRoomRotation_InRotation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetRoomRotation_NativeFunction, "InRotation");
        SetRoomPosition_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetRoomPosition");
        SetRoomPosition_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetRoomPosition_NativeFunction);
        SetRoomPosition_InPosition_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetRoomPosition_NativeFunction, "InPosition");
        SetRoomMaterials_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetRoomMaterials");
        SetRoomMaterials_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetRoomMaterials_NativeFunction);
        SetRoomMaterials_InMaterials_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetRoomMaterials_NativeFunction, "InMaterials");
        SetRoomMaterials_InMaterials_ElementSize = FArrayPropertyExporter.CallGetArrayElementSize(SetRoomMaterials_NativeFunction, "InMaterials");
        SetRoomDimensions_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetRoomDimensions");
        SetRoomDimensions_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetRoomDimensions_NativeFunction);
        SetRoomDimensions_InDimensions_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetRoomDimensions_NativeFunction, "InDimensions");
        SetReverbTimeModifier_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetReverbTimeModifier");
        SetReverbTimeModifier_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetReverbTimeModifier_NativeFunction);
        SetReverbTimeModifier_InReverbTimeModifier_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetReverbTimeModifier_NativeFunction, "InReverbTimeModifier");
        SetReverbGain_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetReverbGain");
        SetReverbGain_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetReverbGain_NativeFunction);
        SetReverbGain_InReverbGain_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetReverbGain_NativeFunction, "InReverbGain");
        SetReverbBrightness_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetReverbBrightness");
        SetReverbBrightness_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetReverbBrightness_NativeFunction);
        SetReverbBrightness_InReverbBrightness_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetReverbBrightness_NativeFunction, "InReverbBrightness");
        SetReflectionScalar_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetReflectionScalar");
        SetReflectionScalar_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetReflectionScalar_NativeFunction);
        SetReflectionScalar_InReflectionScalar_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetReflectionScalar_NativeFunction, "InReflectionScalar");
        SetEnableRoomEffects_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetEnableRoomEffects");
        SetEnableRoomEffects_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetEnableRoomEffects_NativeFunction);
        SetEnableRoomEffects_bInEnableRoomEffects_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetEnableRoomEffects_NativeFunction, "bInEnableRoomEffects");
        
        
    }
    
    protected ResonanceAudioReverbPluginPreset(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // Function /Script/ResonanceAudio.ResonanceAudioReverbPluginPreset:SetRoomRotation
    static readonly IntPtr SetRoomRotation_NativeFunction;
    static readonly int SetRoomRotation_ParamsSize;
    static readonly int SetRoomRotation_InRotation_Offset;
    
    public void SetRoomRotation(System.DoubleNumerics.Quaternion inRotation)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetRoomRotation_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<System.DoubleNumerics.Quaternion>.ToNative(IntPtr.Add(ParamsBuffer, SetRoomRotation_InRotation_Offset), 0, null, inRotation);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetRoomRotation_NativeFunction, ParamsBuffer);
            
            
        }
    }
    
    // Function /Script/ResonanceAudio.ResonanceAudioReverbPluginPreset:SetRoomPosition
    static readonly IntPtr SetRoomPosition_NativeFunction;
    static readonly int SetRoomPosition_ParamsSize;
    static readonly int SetRoomPosition_InPosition_Offset;
    
    public void SetRoomPosition(System.DoubleNumerics.Vector3 inPosition)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetRoomPosition_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(ParamsBuffer, SetRoomPosition_InPosition_Offset), 0, null, inPosition);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetRoomPosition_NativeFunction, ParamsBuffer);
            
            
        }
    }
    
    // Function /Script/ResonanceAudio.ResonanceAudioReverbPluginPreset:SetRoomMaterials
    static readonly IntPtr SetRoomMaterials_NativeFunction;
    static readonly int SetRoomMaterials_ParamsSize;
    static readonly int SetRoomMaterials_InMaterials_Offset;
    static readonly int SetRoomMaterials_InMaterials_ElementSize;
    
    public void SetRoomMaterials(System.Collections.Generic.IList<UnrealSharp.ResonanceAudio.ERaMaterialName> inMaterials)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetRoomMaterials_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            IntPtr InMaterials_NativeBuffer = IntPtr.Add(ParamsBuffer, SetRoomMaterials_InMaterials_Offset);
            UnrealArrayCopyMarshaler<UnrealSharp.ResonanceAudio.ERaMaterialName> InMaterials_Marshaler = new UnrealArrayCopyMarshaler<UnrealSharp.ResonanceAudio.ERaMaterialName>(1, BlittableMarshaller<UnrealSharp.ResonanceAudio.ERaMaterialName>.ToNative, BlittableMarshaller<UnrealSharp.ResonanceAudio.ERaMaterialName>.FromNative, SetRoomMaterials_InMaterials_ElementSize);
            InMaterials_Marshaler.ToNative(InMaterials_NativeBuffer, 0, null, inMaterials);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetRoomMaterials_NativeFunction, ParamsBuffer);
            
            
        }
    }
    
    // Function /Script/ResonanceAudio.ResonanceAudioReverbPluginPreset:SetRoomDimensions
    static readonly IntPtr SetRoomDimensions_NativeFunction;
    static readonly int SetRoomDimensions_ParamsSize;
    static readonly int SetRoomDimensions_InDimensions_Offset;
    
    public void SetRoomDimensions(System.DoubleNumerics.Vector3 inDimensions)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetRoomDimensions_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(ParamsBuffer, SetRoomDimensions_InDimensions_Offset), 0, null, inDimensions);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetRoomDimensions_NativeFunction, ParamsBuffer);
            
            
        }
    }
    
    // Function /Script/ResonanceAudio.ResonanceAudioReverbPluginPreset:SetReverbTimeModifier
    static readonly IntPtr SetReverbTimeModifier_NativeFunction;
    static readonly int SetReverbTimeModifier_ParamsSize;
    static readonly int SetReverbTimeModifier_InReverbTimeModifier_Offset;
    
    public void SetReverbTimeModifier(float inReverbTimeModifier)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetReverbTimeModifier_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, SetReverbTimeModifier_InReverbTimeModifier_Offset), 0, null, inReverbTimeModifier);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetReverbTimeModifier_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/ResonanceAudio.ResonanceAudioReverbPluginPreset:SetReverbGain
    static readonly IntPtr SetReverbGain_NativeFunction;
    static readonly int SetReverbGain_ParamsSize;
    static readonly int SetReverbGain_InReverbGain_Offset;
    
    public void SetReverbGain(float inReverbGain)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetReverbGain_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, SetReverbGain_InReverbGain_Offset), 0, null, inReverbGain);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetReverbGain_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/ResonanceAudio.ResonanceAudioReverbPluginPreset:SetReverbBrightness
    static readonly IntPtr SetReverbBrightness_NativeFunction;
    static readonly int SetReverbBrightness_ParamsSize;
    static readonly int SetReverbBrightness_InReverbBrightness_Offset;
    
    public void SetReverbBrightness(float inReverbBrightness)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetReverbBrightness_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, SetReverbBrightness_InReverbBrightness_Offset), 0, null, inReverbBrightness);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetReverbBrightness_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/ResonanceAudio.ResonanceAudioReverbPluginPreset:SetReflectionScalar
    static readonly IntPtr SetReflectionScalar_NativeFunction;
    static readonly int SetReflectionScalar_ParamsSize;
    static readonly int SetReflectionScalar_InReflectionScalar_Offset;
    
    public void SetReflectionScalar(float inReflectionScalar)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetReflectionScalar_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, SetReflectionScalar_InReflectionScalar_Offset), 0, null, inReflectionScalar);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetReflectionScalar_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/ResonanceAudio.ResonanceAudioReverbPluginPreset:SetEnableRoomEffects
    static readonly IntPtr SetEnableRoomEffects_NativeFunction;
    static readonly int SetEnableRoomEffects_ParamsSize;
    static readonly int SetEnableRoomEffects_bInEnableRoomEffects_Offset;
    
    public void SetEnableRoomEffects(bool bInEnableRoomEffects)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetEnableRoomEffects_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, SetEnableRoomEffects_bInEnableRoomEffects_Offset), 0, null, bInEnableRoomEffects);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetEnableRoomEffects_NativeFunction, ParamsBuffer);
            
        }
    }
    
    
}