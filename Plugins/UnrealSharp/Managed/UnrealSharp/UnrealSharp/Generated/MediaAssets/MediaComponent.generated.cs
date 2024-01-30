// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.MediaAssets;

[UClass]
public partial class MediaComponent : UnrealSharp.Engine.ActorComponent
{
    
    static MediaComponent()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("MediaComponent");
        
        MediaTexture_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MediaTexture");
        MediaPlayer_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MediaPlayer");
        
        GetMediaTexture_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetMediaTexture");
        GetMediaTexture_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetMediaTexture_NativeFunction);
        GetMediaTexture_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetMediaTexture_NativeFunction, "ReturnValue");
        GetMediaPlayer_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetMediaPlayer");
        GetMediaPlayer_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetMediaPlayer_NativeFunction);
        GetMediaPlayer_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetMediaPlayer_NativeFunction, "ReturnValue");
        
        
    }
    
    protected MediaComponent(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // ObjectProperty /Script/MediaAssets.MediaComponent:MediaTexture
    static readonly int MediaTexture_Offset;
    
    public UnrealSharp.MediaAssets.MediaTexture MediaTexture
    {
        get
        {
            CheckObjectForValidity();
            return ObjectMarshaller<UnrealSharp.MediaAssets.MediaTexture>.FromNative(IntPtr.Add(NativeObject, MediaTexture_Offset), 0, this);
        }
    }
    
    // ObjectProperty /Script/MediaAssets.MediaComponent:MediaPlayer
    static readonly int MediaPlayer_Offset;
    
    public UnrealSharp.MediaAssets.MediaPlayer MediaPlayer
    {
        get
        {
            CheckObjectForValidity();
            return ObjectMarshaller<UnrealSharp.MediaAssets.MediaPlayer>.FromNative(IntPtr.Add(NativeObject, MediaPlayer_Offset), 0, this);
        }
    }
    
    // Function /Script/MediaAssets.MediaComponent:GetMediaTexture
    static readonly IntPtr GetMediaTexture_NativeFunction;
    static readonly int GetMediaTexture_ParamsSize;
    static readonly int GetMediaTexture_ReturnValue_Offset;
    
    public UnrealSharp.MediaAssets.MediaTexture GetMediaTexture()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetMediaTexture_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetMediaTexture_NativeFunction, ParamsBuffer);
            
            UnrealSharp.MediaAssets.MediaTexture returnValue;
            returnValue = ObjectMarshaller<UnrealSharp.MediaAssets.MediaTexture>.FromNative(IntPtr.Add(ParamsBuffer, GetMediaTexture_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/MediaAssets.MediaComponent:GetMediaPlayer
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
    
    
}