// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UClass]
public partial class SoundWave : UnrealSharp.Engine.SoundBase
{
    
    static SoundWave()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("SoundWave");
        
        StreamingPriority_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "StreamingPriority");
        bSeekableStreaming_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bSeekableStreaming");
        bSeekableStreaming_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bSeekableStreaming");
        bUseBinkAudio_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bUseBinkAudio");
        bUseBinkAudio_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bUseBinkAudio");
        ModulationSettings_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ModulationSettings");
        bMature_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bMature");
        bMature_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bMature");
        bManualWordWrap_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bManualWordWrap");
        bManualWordWrap_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bManualWordWrap");
        bSingleLine_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bSingleLine");
        bSingleLine_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bSingleLine");
        SubtitlePriority_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SubtitlePriority");
        CuePoints_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CuePoints");
        CuePoints_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "CuePoints");
        Subtitles_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Subtitles");
        Subtitles_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "Subtitles");
        
        SetSoundAssetCompressionType_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetSoundAssetCompressionType");
        SetSoundAssetCompressionType_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetSoundAssetCompressionType_NativeFunction);
        SetSoundAssetCompressionType_InSoundAssetCompressionType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetSoundAssetCompressionType_NativeFunction, "InSoundAssetCompressionType");
        SetSoundAssetCompressionType_bMarkDirty_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetSoundAssetCompressionType_NativeFunction, "bMarkDirty");
        GetSoundAssetCompressionType_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetSoundAssetCompressionType");
        GetSoundAssetCompressionType_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetSoundAssetCompressionType_NativeFunction);
        GetSoundAssetCompressionType_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetSoundAssetCompressionType_NativeFunction, "ReturnValue");
        GetLoopRegions_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetLoopRegions");
        GetLoopRegions_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetLoopRegions_NativeFunction);
        GetLoopRegions_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetLoopRegions_NativeFunction, "ReturnValue");
        GetLoopRegions_ReturnValue_ElementSize = FArrayPropertyExporter.CallGetArrayElementSize(GetLoopRegions_NativeFunction, "ReturnValue");
        GetCuePoints_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetCuePoints");
        GetCuePoints_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetCuePoints_NativeFunction);
        GetCuePoints_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetCuePoints_NativeFunction, "ReturnValue");
        GetCuePoints_ReturnValue_ElementSize = FArrayPropertyExporter.CallGetArrayElementSize(GetCuePoints_NativeFunction, "ReturnValue");
        
        
    }
    
    protected SoundWave(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // IntProperty /Script/Engine.SoundWave:StreamingPriority
    static readonly int StreamingPriority_Offset;
    
    public int StreamingPriority
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<int>.FromNative(IntPtr.Add(NativeObject, StreamingPriority_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<int>.ToNative(IntPtr.Add(NativeObject, StreamingPriority_Offset), 0, this, value);
        }
    }
    
    // BoolProperty /Script/Engine.SoundWave:bSeekableStreaming
    static readonly int bSeekableStreaming_Offset;
    static readonly IntPtr bSeekableStreaming_NativeProperty;
    
    public bool bSeekableStreaming
    {
        get
        {
            CheckObjectForValidity();
            return FBoolPropertyExporter.CallGetBitfieldValueFromProperty(NativeObject, bSeekableStreaming_NativeProperty, bSeekableStreaming_Offset);
        }
        set
        {
            CheckObjectForValidity();
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(NativeObject, bSeekableStreaming_NativeProperty, bSeekableStreaming_Offset, value);
        }
    }
    
    // BoolProperty /Script/Engine.SoundWave:bUseBinkAudio
    static readonly int bUseBinkAudio_Offset;
    static readonly IntPtr bUseBinkAudio_NativeProperty;
    
    public bool bUseBinkAudio
    {
        get
        {
            CheckObjectForValidity();
            return FBoolPropertyExporter.CallGetBitfieldValueFromProperty(NativeObject, bUseBinkAudio_NativeProperty, bUseBinkAudio_Offset);
        }
        set
        {
            CheckObjectForValidity();
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(NativeObject, bUseBinkAudio_NativeProperty, bUseBinkAudio_Offset, value);
        }
    }
    
    // StructProperty /Script/Engine.SoundWave:ModulationSettings
    static readonly int ModulationSettings_Offset;
    
    public UnrealSharp.Engine.SoundModulationDefaultRoutingSettings ModulationSettings
    {
        get
        {
            CheckObjectForValidity();
            return UnrealSharp.Engine.SoundModulationDefaultRoutingSettingsMarshaler.FromNative(IntPtr.Add(NativeObject, ModulationSettings_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            UnrealSharp.Engine.SoundModulationDefaultRoutingSettingsMarshaler.ToNative(IntPtr.Add(NativeObject, ModulationSettings_Offset), 0, this, value);
        }
    }
    
    // BoolProperty /Script/Engine.SoundWave:bMature
    static readonly int bMature_Offset;
    static readonly IntPtr bMature_NativeProperty;
    
    public bool bMature
    {
        get
        {
            CheckObjectForValidity();
            return FBoolPropertyExporter.CallGetBitfieldValueFromProperty(NativeObject, bMature_NativeProperty, bMature_Offset);
        }
    }
    
    // BoolProperty /Script/Engine.SoundWave:bManualWordWrap
    static readonly int bManualWordWrap_Offset;
    static readonly IntPtr bManualWordWrap_NativeProperty;
    
    public bool bManualWordWrap
    {
        get
        {
            CheckObjectForValidity();
            return FBoolPropertyExporter.CallGetBitfieldValueFromProperty(NativeObject, bManualWordWrap_NativeProperty, bManualWordWrap_Offset);
        }
    }
    
    // BoolProperty /Script/Engine.SoundWave:bSingleLine
    static readonly int bSingleLine_Offset;
    static readonly IntPtr bSingleLine_NativeProperty;
    
    public bool bSingleLine
    {
        get
        {
            CheckObjectForValidity();
            return FBoolPropertyExporter.CallGetBitfieldValueFromProperty(NativeObject, bSingleLine_NativeProperty, bSingleLine_Offset);
        }
    }
    
    // FloatProperty /Script/Engine.SoundWave:SubtitlePriority
    static readonly int SubtitlePriority_Offset;
    
    public float SubtitlePriority
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, SubtitlePriority_Offset), 0, this);
        }
    }
    
    // ArrayProperty /Script/Engine.SoundWave:CuePoints
    static readonly int CuePoints_Offset;
    static readonly IntPtr CuePoints_NativeProperty;
    UnrealArrayReadOnlyMarshaler<UnrealSharp.Engine.SoundWaveCuePoint> CuePoints_Wrapper = null;
    
    public System.Collections.Generic.IReadOnlyList<UnrealSharp.Engine.SoundWaveCuePoint> CuePoints
    {
        get
        {
            if(CuePoints_Wrapper == null)
            {
                CuePoints_Wrapper = new UnrealArrayReadOnlyMarshaler<UnrealSharp.Engine.SoundWaveCuePoint>(1, CuePoints_NativeProperty, UnrealSharp.Engine.SoundWaveCuePointMarshaler.ToNative, UnrealSharp.Engine.SoundWaveCuePointMarshaler.FromNative);
            }
            
            return CuePoints_Wrapper.FromNative(IntPtr.Add(NativeObject,CuePoints_Offset),0,this);
        }
    }
    
    // ArrayProperty /Script/Engine.SoundWave:Subtitles
    static readonly int Subtitles_Offset;
    static readonly IntPtr Subtitles_NativeProperty;
    UnrealArrayReadOnlyMarshaler<UnrealSharp.Engine.SubtitleCue> Subtitles_Wrapper = null;
    
    public System.Collections.Generic.IReadOnlyList<UnrealSharp.Engine.SubtitleCue> Subtitles
    {
        get
        {
            if(Subtitles_Wrapper == null)
            {
                Subtitles_Wrapper = new UnrealArrayReadOnlyMarshaler<UnrealSharp.Engine.SubtitleCue>(1, Subtitles_NativeProperty, UnrealSharp.Engine.SubtitleCueMarshaler.ToNative, UnrealSharp.Engine.SubtitleCueMarshaler.FromNative);
            }
            
            return Subtitles_Wrapper.FromNative(IntPtr.Add(NativeObject,Subtitles_Offset),0,this);
        }
    }
    
    // Function /Script/Engine.SoundWave:SetSoundAssetCompressionType
    static readonly IntPtr SetSoundAssetCompressionType_NativeFunction;
    static readonly int SetSoundAssetCompressionType_ParamsSize;
    static readonly int SetSoundAssetCompressionType_InSoundAssetCompressionType_Offset;
    static readonly int SetSoundAssetCompressionType_bMarkDirty_Offset;
    
    public void SetSoundAssetCompressionType(UnrealSharp.Engine.ESoundAssetCompressionType inSoundAssetCompressionType, bool bMarkDirty = true)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetSoundAssetCompressionType_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<UnrealSharp.Engine.ESoundAssetCompressionType>.ToNative(IntPtr.Add(ParamsBuffer, SetSoundAssetCompressionType_InSoundAssetCompressionType_Offset), 0, null, inSoundAssetCompressionType);
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, SetSoundAssetCompressionType_bMarkDirty_Offset), 0, null, bMarkDirty);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetSoundAssetCompressionType_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/Engine.SoundWave:GetSoundAssetCompressionType
    static readonly IntPtr GetSoundAssetCompressionType_NativeFunction;
    static readonly int GetSoundAssetCompressionType_ParamsSize;
    static readonly int GetSoundAssetCompressionType_ReturnValue_Offset;
    
    public UnrealSharp.Engine.ESoundAssetCompressionType GetSoundAssetCompressionType()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetSoundAssetCompressionType_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetSoundAssetCompressionType_NativeFunction, ParamsBuffer);
            
            UnrealSharp.Engine.ESoundAssetCompressionType returnValue;
            returnValue = BlittableMarshaller<UnrealSharp.Engine.ESoundAssetCompressionType>.FromNative(IntPtr.Add(ParamsBuffer, GetSoundAssetCompressionType_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/Engine.SoundWave:GetLoopRegions
    static readonly IntPtr GetLoopRegions_NativeFunction;
    static readonly int GetLoopRegions_ParamsSize;
    static readonly int GetLoopRegions_ReturnValue_Offset;
    static readonly int GetLoopRegions_ReturnValue_ElementSize;
    
    public System.Collections.Generic.IList<UnrealSharp.Engine.SoundWaveCuePoint> GetLoopRegions()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetLoopRegions_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetLoopRegions_NativeFunction, ParamsBuffer);
            
            System.Collections.Generic.IList<UnrealSharp.Engine.SoundWaveCuePoint> returnValue;
            IntPtr ReturnValue_NativeBuffer = IntPtr.Add(ParamsBuffer, GetLoopRegions_ReturnValue_Offset);
            UnrealArrayCopyMarshaler<UnrealSharp.Engine.SoundWaveCuePoint> ReturnValue_Marshaler = new UnrealArrayCopyMarshaler<UnrealSharp.Engine.SoundWaveCuePoint> (1, UnrealSharp.Engine.SoundWaveCuePointMarshaler.ToNative, UnrealSharp.Engine.SoundWaveCuePointMarshaler.FromNative, GetLoopRegions_ReturnValue_ElementSize);
            returnValue = ReturnValue_Marshaler.FromNative(ReturnValue_NativeBuffer, 0, null);
            UnrealArrayCopyMarshaler<UnrealSharp.Engine.SoundWaveCuePoint>.DestructInstance(ReturnValue_NativeBuffer, 0);
            
            return returnValue;
        }
    }
    
    // Function /Script/Engine.SoundWave:GetCuePoints
    static readonly IntPtr GetCuePoints_NativeFunction;
    static readonly int GetCuePoints_ParamsSize;
    static readonly int GetCuePoints_ReturnValue_Offset;
    static readonly int GetCuePoints_ReturnValue_ElementSize;
    
    public System.Collections.Generic.IList<UnrealSharp.Engine.SoundWaveCuePoint> GetCuePoints()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetCuePoints_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetCuePoints_NativeFunction, ParamsBuffer);
            
            System.Collections.Generic.IList<UnrealSharp.Engine.SoundWaveCuePoint> returnValue;
            IntPtr ReturnValue_NativeBuffer = IntPtr.Add(ParamsBuffer, GetCuePoints_ReturnValue_Offset);
            UnrealArrayCopyMarshaler<UnrealSharp.Engine.SoundWaveCuePoint> ReturnValue_Marshaler = new UnrealArrayCopyMarshaler<UnrealSharp.Engine.SoundWaveCuePoint> (1, UnrealSharp.Engine.SoundWaveCuePointMarshaler.ToNative, UnrealSharp.Engine.SoundWaveCuePointMarshaler.FromNative, GetCuePoints_ReturnValue_ElementSize);
            returnValue = ReturnValue_Marshaler.FromNative(ReturnValue_NativeBuffer, 0, null);
            UnrealArrayCopyMarshaler<UnrealSharp.Engine.SoundWaveCuePoint>.DestructInstance(ReturnValue_NativeBuffer, 0);
            
            return returnValue;
        }
    }
    
    
}