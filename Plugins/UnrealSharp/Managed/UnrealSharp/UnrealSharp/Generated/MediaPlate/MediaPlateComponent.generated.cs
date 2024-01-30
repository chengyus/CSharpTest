// This file is automatically generated
using UnrealSharp.MediaAssets;
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.MediaPlate;

[UClass]
public partial class MediaPlateComponent : UnrealSharp.Engine.ActorComponent, IMediaPlayerProxyInterface
{
    
    static MediaPlateComponent()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("MediaPlateComponent");
        
        bPlayOnOpen_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bPlayOnOpen");
        StartTime_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "StartTime");
        MediaPlaylist_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MediaPlaylist");
        PlaylistIndex_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PlaylistIndex");
        bIsMediaPlatePlaying_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIsMediaPlatePlaying");
        bPlayOnlyWhenVisible_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bPlayOnlyWhenVisible");
        bLoop_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bLoop");
        bIsAspectRatioAuto_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIsAspectRatioAuto");
        
        SetPlayOnlyWhenVisible_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetPlayOnlyWhenVisible");
        SetPlayOnlyWhenVisible_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetPlayOnlyWhenVisible_NativeFunction);
        SetPlayOnlyWhenVisible_bInPlayOnlyWhenVisible_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetPlayOnlyWhenVisible_NativeFunction, "bInPlayOnlyWhenVisible");
        SetMeshRange_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetMeshRange");
        SetMeshRange_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetMeshRange_NativeFunction);
        SetMeshRange_InMeshRange_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetMeshRange_NativeFunction, "InMeshRange");
        SetLetterboxAspectRatio_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetLetterboxAspectRatio");
        SetLetterboxAspectRatio_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetLetterboxAspectRatio_NativeFunction);
        SetLetterboxAspectRatio_AspectRatio_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetLetterboxAspectRatio_NativeFunction, "AspectRatio");
        SetIsAspectRatioAuto_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetIsAspectRatioAuto");
        SetIsAspectRatioAuto_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetIsAspectRatioAuto_NativeFunction);
        SetIsAspectRatioAuto_bInIsAspectRatioAuto_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetIsAspectRatioAuto_NativeFunction, "bInIsAspectRatioAuto");
        Seek_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "Seek");
        Seek_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(Seek_NativeFunction);
        Seek_Time_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(Seek_NativeFunction, "Time");
        Seek_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(Seek_NativeFunction, "ReturnValue");
        Rewind_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "Rewind");
        Rewind_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(Rewind_NativeFunction);
        Rewind_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(Rewind_NativeFunction, "ReturnValue");
        Play_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "Play");
        Pause_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "Pause");
        Open_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "Open");
        GetMeshRange_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetMeshRange");
        GetMeshRange_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetMeshRange_NativeFunction);
        GetMeshRange_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetMeshRange_NativeFunction, "ReturnValue");
        GetMediaTexture_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetMediaTexture");
        GetMediaTexture_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetMediaTexture_NativeFunction);
        GetMediaTexture_Index_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetMediaTexture_NativeFunction, "Index");
        GetMediaTexture_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetMediaTexture_NativeFunction, "ReturnValue");
        GetMediaPlayer_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetMediaPlayer");
        GetMediaPlayer_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetMediaPlayer_NativeFunction);
        GetMediaPlayer_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetMediaPlayer_NativeFunction, "ReturnValue");
        GetLetterboxAspectRatio_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetLetterboxAspectRatio");
        GetLetterboxAspectRatio_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetLetterboxAspectRatio_NativeFunction);
        GetLetterboxAspectRatio_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetLetterboxAspectRatio_NativeFunction, "ReturnValue");
        GetIsAspectRatioAuto_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetIsAspectRatioAuto");
        GetIsAspectRatioAuto_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetIsAspectRatioAuto_NativeFunction);
        GetIsAspectRatioAuto_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetIsAspectRatioAuto_NativeFunction, "ReturnValue");
        Close_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "Close");
        
        
    }
    
    protected MediaPlateComponent(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // BoolProperty /Script/MediaPlate.MediaPlateComponent:bPlayOnOpen
    static readonly int bPlayOnOpen_Offset;
    
    public bool bPlayOnOpen
    {
        get
        {
            CheckObjectForValidity();
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bPlayOnOpen_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bPlayOnOpen_Offset), 0, this, value);
        }
    }
    
    // FloatProperty /Script/MediaPlate.MediaPlateComponent:StartTime
    static readonly int StartTime_Offset;
    
    public float StartTime
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, StartTime_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<float>.ToNative(IntPtr.Add(NativeObject, StartTime_Offset), 0, this, value);
        }
    }
    
    // ObjectProperty /Script/MediaPlate.MediaPlateComponent:MediaPlaylist
    static readonly int MediaPlaylist_Offset;
    
    public UnrealSharp.MediaAssets.MediaPlaylist MediaPlaylist
    {
        get
        {
            CheckObjectForValidity();
            return ObjectMarshaller<UnrealSharp.MediaAssets.MediaPlaylist>.FromNative(IntPtr.Add(NativeObject, MediaPlaylist_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            ObjectMarshaller<UnrealSharp.MediaAssets.MediaPlaylist>.ToNative(IntPtr.Add(NativeObject, MediaPlaylist_Offset), 0, this, value);
        }
    }
    
    // IntProperty /Script/MediaPlate.MediaPlateComponent:PlaylistIndex
    static readonly int PlaylistIndex_Offset;
    
    public int PlaylistIndex
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<int>.FromNative(IntPtr.Add(NativeObject, PlaylistIndex_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<int>.ToNative(IntPtr.Add(NativeObject, PlaylistIndex_Offset), 0, this, value);
        }
    }
    
    // BoolProperty /Script/MediaPlate.MediaPlateComponent:bIsMediaPlatePlaying
    static readonly int bIsMediaPlatePlaying_Offset;
    
    public bool bIsMediaPlatePlaying
    {
        get
        {
            CheckObjectForValidity();
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bIsMediaPlatePlaying_Offset), 0, this);
        }
    }
    
    // BoolProperty /Script/MediaPlate.MediaPlateComponent:bPlayOnlyWhenVisible
    static readonly int bPlayOnlyWhenVisible_Offset;
    
    public bool bPlayOnlyWhenVisible
    {
        get
        {
            CheckObjectForValidity();
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bPlayOnlyWhenVisible_Offset), 0, this);
        }
    }
    
    // BoolProperty /Script/MediaPlate.MediaPlateComponent:bLoop
    static readonly int bLoop_Offset;
    
    public bool bLoop
    {
        get
        {
            CheckObjectForValidity();
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bLoop_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bLoop_Offset), 0, this, value);
        }
    }
    
    // BoolProperty /Script/MediaPlate.MediaPlateComponent:bIsAspectRatioAuto
    static readonly int bIsAspectRatioAuto_Offset;
    
    public bool bIsAspectRatioAuto
    {
        get
        {
            CheckObjectForValidity();
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bIsAspectRatioAuto_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bIsAspectRatioAuto_Offset), 0, this, value);
        }
    }
    
    // Function /Script/MediaPlate.MediaPlateComponent:SetPlayOnlyWhenVisible
    static readonly IntPtr SetPlayOnlyWhenVisible_NativeFunction;
    static readonly int SetPlayOnlyWhenVisible_ParamsSize;
    static readonly int SetPlayOnlyWhenVisible_bInPlayOnlyWhenVisible_Offset;
    
    public void SetPlayOnlyWhenVisible(bool bInPlayOnlyWhenVisible)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetPlayOnlyWhenVisible_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, SetPlayOnlyWhenVisible_bInPlayOnlyWhenVisible_Offset), 0, null, bInPlayOnlyWhenVisible);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetPlayOnlyWhenVisible_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/MediaPlate.MediaPlateComponent:SetMeshRange
    static readonly IntPtr SetMeshRange_NativeFunction;
    static readonly int SetMeshRange_ParamsSize;
    static readonly int SetMeshRange_InMeshRange_Offset;
    
    public void SetMeshRange(System.DoubleNumerics.Vector2 inMeshRange)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetMeshRange_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<System.DoubleNumerics.Vector2>.ToNative(IntPtr.Add(ParamsBuffer, SetMeshRange_InMeshRange_Offset), 0, null, inMeshRange);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetMeshRange_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/MediaPlate.MediaPlateComponent:SetLetterboxAspectRatio
    static readonly IntPtr SetLetterboxAspectRatio_NativeFunction;
    static readonly int SetLetterboxAspectRatio_ParamsSize;
    static readonly int SetLetterboxAspectRatio_AspectRatio_Offset;
    
    public void SetLetterboxAspectRatio(float aspectRatio)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetLetterboxAspectRatio_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, SetLetterboxAspectRatio_AspectRatio_Offset), 0, null, aspectRatio);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetLetterboxAspectRatio_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/MediaPlate.MediaPlateComponent:SetIsAspectRatioAuto
    static readonly IntPtr SetIsAspectRatioAuto_NativeFunction;
    static readonly int SetIsAspectRatioAuto_ParamsSize;
    static readonly int SetIsAspectRatioAuto_bInIsAspectRatioAuto_Offset;
    
    public void SetIsAspectRatioAuto(bool bInIsAspectRatioAuto)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetIsAspectRatioAuto_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, SetIsAspectRatioAuto_bInIsAspectRatioAuto_Offset), 0, null, bInIsAspectRatioAuto);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetIsAspectRatioAuto_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/MediaPlate.MediaPlateComponent:Seek
    static readonly IntPtr Seek_NativeFunction;
    static readonly int Seek_ParamsSize;
    static readonly int Seek_Time_Offset;
    static readonly int Seek_ReturnValue_Offset;
    
    public bool Seek(UnrealSharp.CoreUObject.Timespan time)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[Seek_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            UnrealSharp.CoreUObject.TimespanMarshaler.ToNative(IntPtr.Add(ParamsBuffer, Seek_Time_Offset), 0, null, time);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, Seek_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, Seek_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/MediaPlate.MediaPlateComponent:Rewind
    static readonly IntPtr Rewind_NativeFunction;
    static readonly int Rewind_ParamsSize;
    static readonly int Rewind_ReturnValue_Offset;
    
    public bool Rewind()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[Rewind_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, Rewind_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, Rewind_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/MediaPlate.MediaPlateComponent:Play
    static readonly IntPtr Play_NativeFunction;
    
    public void Play()
    {
        unsafe
        {
            UObjectExporter.CallInvokeNativeFunction(NativeObject, Play_NativeFunction, IntPtr.Zero);
        }
    }
    
    // Function /Script/MediaPlate.MediaPlateComponent:Pause
    static readonly IntPtr Pause_NativeFunction;
    
    public void Pause()
    {
        unsafe
        {
            UObjectExporter.CallInvokeNativeFunction(NativeObject, Pause_NativeFunction, IntPtr.Zero);
        }
    }
    
    // Function /Script/MediaPlate.MediaPlateComponent:Open
    static readonly IntPtr Open_NativeFunction;
    
    public void Open()
    {
        unsafe
        {
            UObjectExporter.CallInvokeNativeFunction(NativeObject, Open_NativeFunction, IntPtr.Zero);
        }
    }
    
    // Function /Script/MediaPlate.MediaPlateComponent:GetMeshRange
    static readonly IntPtr GetMeshRange_NativeFunction;
    static readonly int GetMeshRange_ParamsSize;
    static readonly int GetMeshRange_ReturnValue_Offset;
    
    public System.DoubleNumerics.Vector2 GetMeshRange()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetMeshRange_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetMeshRange_NativeFunction, ParamsBuffer);
            
            System.DoubleNumerics.Vector2 returnValue;
            returnValue = BlittableMarshaller<System.DoubleNumerics.Vector2>.FromNative(IntPtr.Add(ParamsBuffer, GetMeshRange_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/MediaPlate.MediaPlateComponent:GetMediaTexture
    static readonly IntPtr GetMediaTexture_NativeFunction;
    static readonly int GetMediaTexture_ParamsSize;
    static readonly int GetMediaTexture_Index_Offset;
    static readonly int GetMediaTexture_ReturnValue_Offset;
    
    public UnrealSharp.MediaAssets.MediaTexture GetMediaTexture(int index = 0)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetMediaTexture_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<int>.ToNative(IntPtr.Add(ParamsBuffer, GetMediaTexture_Index_Offset), 0, null, index);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetMediaTexture_NativeFunction, ParamsBuffer);
            
            UnrealSharp.MediaAssets.MediaTexture returnValue;
            returnValue = ObjectMarshaller<UnrealSharp.MediaAssets.MediaTexture>.FromNative(IntPtr.Add(ParamsBuffer, GetMediaTexture_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/MediaPlate.MediaPlateComponent:GetMediaPlayer
    static readonly IntPtr GetMediaPlayer_NativeFunction;
    static readonly int GetMediaPlayer_ParamsSize;
    static readonly int GetMediaPlayer_ReturnValue_Offset;
    
    public UnrealSharp.MediaAssets.MediaPlayer GetMediaPlayer()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetMediaPlayer_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetMediaPlayer_NativeFunction, ParamsBuffer);
            
            UnrealSharp.MediaAssets.MediaPlayer returnValue;
            returnValue = ObjectMarshaller<UnrealSharp.MediaAssets.MediaPlayer>.FromNative(IntPtr.Add(ParamsBuffer, GetMediaPlayer_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/MediaPlate.MediaPlateComponent:GetLetterboxAspectRatio
    static readonly IntPtr GetLetterboxAspectRatio_NativeFunction;
    static readonly int GetLetterboxAspectRatio_ParamsSize;
    static readonly int GetLetterboxAspectRatio_ReturnValue_Offset;
    
    public float GetLetterboxAspectRatio()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetLetterboxAspectRatio_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetLetterboxAspectRatio_NativeFunction, ParamsBuffer);
            
            float returnValue;
            returnValue = BlittableMarshaller<float>.FromNative(IntPtr.Add(ParamsBuffer, GetLetterboxAspectRatio_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/MediaPlate.MediaPlateComponent:GetIsAspectRatioAuto
    static readonly IntPtr GetIsAspectRatioAuto_NativeFunction;
    static readonly int GetIsAspectRatioAuto_ParamsSize;
    static readonly int GetIsAspectRatioAuto_ReturnValue_Offset;
    
    public bool GetIsAspectRatioAuto()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetIsAspectRatioAuto_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetIsAspectRatioAuto_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, GetIsAspectRatioAuto_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/MediaPlate.MediaPlateComponent:Close
    static readonly IntPtr Close_NativeFunction;
    
    public void Close()
    {
        unsafe
        {
            UObjectExporter.CallInvokeNativeFunction(NativeObject, Close_NativeFunction, IntPtr.Zero);
        }
    }
    
    
}