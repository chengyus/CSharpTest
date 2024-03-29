// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.SequencerScripting;

[UClass]
public partial class MovieSceneFloatVectorTrackExtensions : UnrealSharp.Engine.BlueprintFunctionLibrary
{
    
    static readonly IntPtr NativeClassPtr;
    static MovieSceneFloatVectorTrackExtensions()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("MovieSceneFloatVectorTrackExtensions");
        
        
        SetNumChannelsUsed_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetNumChannelsUsed");
        SetNumChannelsUsed_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetNumChannelsUsed_NativeFunction);
        SetNumChannelsUsed_Track_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetNumChannelsUsed_NativeFunction, "Track");
        SetNumChannelsUsed_InNumChannelsUsed_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetNumChannelsUsed_NativeFunction, "InNumChannelsUsed");
        GetNumChannelsUsed_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetNumChannelsUsed");
        GetNumChannelsUsed_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetNumChannelsUsed_NativeFunction);
        GetNumChannelsUsed_Track_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetNumChannelsUsed_NativeFunction, "Track");
        GetNumChannelsUsed_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetNumChannelsUsed_NativeFunction, "ReturnValue");
        
        
    }
    
    protected MovieSceneFloatVectorTrackExtensions(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // Function /Script/SequencerScripting.MovieSceneFloatVectorTrackExtensions:SetNumChannelsUsed
    static readonly IntPtr SetNumChannelsUsed_NativeFunction;
    static readonly int SetNumChannelsUsed_ParamsSize;
    static readonly int SetNumChannelsUsed_Track_Offset;
    static readonly int SetNumChannelsUsed_InNumChannelsUsed_Offset;
    
    public static void SetNumChannelsUsed(UnrealSharp.MovieSceneTracks.MovieSceneFloatVectorTrack track, int inNumChannelsUsed)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetNumChannelsUsed_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.MovieSceneTracks.MovieSceneFloatVectorTrack>.ToNative(IntPtr.Add(ParamsBuffer, SetNumChannelsUsed_Track_Offset), 0, null, track);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(ParamsBuffer, SetNumChannelsUsed_InNumChannelsUsed_Offset), 0, null, inNumChannelsUsed);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, SetNumChannelsUsed_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/SequencerScripting.MovieSceneFloatVectorTrackExtensions:GetNumChannelsUsed
    static readonly IntPtr GetNumChannelsUsed_NativeFunction;
    static readonly int GetNumChannelsUsed_ParamsSize;
    static readonly int GetNumChannelsUsed_Track_Offset;
    static readonly int GetNumChannelsUsed_ReturnValue_Offset;
    
    public static int GetNumChannelsUsed(UnrealSharp.MovieSceneTracks.MovieSceneFloatVectorTrack track)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetNumChannelsUsed_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.MovieSceneTracks.MovieSceneFloatVectorTrack>.ToNative(IntPtr.Add(ParamsBuffer, GetNumChannelsUsed_Track_Offset), 0, null, track);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, GetNumChannelsUsed_NativeFunction, ParamsBuffer);
            
            int returnValue;
            returnValue = BlittableMarshaller<int>.FromNative(IntPtr.Add(ParamsBuffer, GetNumChannelsUsed_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    
}