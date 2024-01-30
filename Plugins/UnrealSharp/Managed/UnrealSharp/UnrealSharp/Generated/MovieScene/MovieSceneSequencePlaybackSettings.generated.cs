using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.MovieScene;

[UStruct]
public partial struct MovieSceneSequencePlaybackSettings
{
    // BoolProperty /Script/MovieScene.MovieSceneSequencePlaybackSettings:bAutoPlay
    static readonly int bAutoPlay_Offset;
    static readonly IntPtr bAutoPlay_NativeProperty;
    public bool AutoPlay;
    
    // StructProperty /Script/MovieScene.MovieSceneSequencePlaybackSettings:LoopCount
    static readonly int LoopCount_Offset;
    public UnrealSharp.MovieScene.MovieSceneSequenceLoopCount LoopCount;
    
    // FloatProperty /Script/MovieScene.MovieSceneSequencePlaybackSettings:PlayRate
    static readonly int PlayRate_Offset;
    public float PlayRate;
    
    // FloatProperty /Script/MovieScene.MovieSceneSequencePlaybackSettings:StartTime
    static readonly int StartTime_Offset;
    public float StartTime;
    
    // BoolProperty /Script/MovieScene.MovieSceneSequencePlaybackSettings:bRandomStartTime
    static readonly int bRandomStartTime_Offset;
    static readonly IntPtr bRandomStartTime_NativeProperty;
    public bool RandomStartTime;
    
    // BoolProperty /Script/MovieScene.MovieSceneSequencePlaybackSettings:bRestoreState
    static readonly int bRestoreState_Offset;
    static readonly IntPtr bRestoreState_NativeProperty;
    public bool RestoreState;
    
    // BoolProperty /Script/MovieScene.MovieSceneSequencePlaybackSettings:bDisableMovementInput
    static readonly int bDisableMovementInput_Offset;
    static readonly IntPtr bDisableMovementInput_NativeProperty;
    public bool DisableMovementInput;
    
    // BoolProperty /Script/MovieScene.MovieSceneSequencePlaybackSettings:bDisableLookAtInput
    static readonly int bDisableLookAtInput_Offset;
    static readonly IntPtr bDisableLookAtInput_NativeProperty;
    public bool DisableLookAtInput;
    
    // BoolProperty /Script/MovieScene.MovieSceneSequencePlaybackSettings:bHidePlayer
    static readonly int bHidePlayer_Offset;
    static readonly IntPtr bHidePlayer_NativeProperty;
    public bool HidePlayer;
    
    // BoolProperty /Script/MovieScene.MovieSceneSequencePlaybackSettings:bHideHud
    static readonly int bHideHud_Offset;
    static readonly IntPtr bHideHud_NativeProperty;
    public bool HideHud;
    
    // BoolProperty /Script/MovieScene.MovieSceneSequencePlaybackSettings:bDisableCameraCuts
    static readonly int bDisableCameraCuts_Offset;
    static readonly IntPtr bDisableCameraCuts_NativeProperty;
    public bool DisableCameraCuts;
    
    // BoolProperty /Script/MovieScene.MovieSceneSequencePlaybackSettings:bPauseAtEnd
    static readonly int bPauseAtEnd_Offset;
    static readonly IntPtr bPauseAtEnd_NativeProperty;
    public bool PauseAtEnd;
    
    
    public static readonly int NativeDataSize;
    static MovieSceneSequencePlaybackSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("MovieSceneSequencePlaybackSettings");
        
        bAutoPlay_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bAutoPlay");
        bAutoPlay_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bAutoPlay");
        LoopCount_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LoopCount");
        PlayRate_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PlayRate");
        StartTime_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "StartTime");
        bRandomStartTime_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bRandomStartTime");
        bRandomStartTime_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bRandomStartTime");
        bRestoreState_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bRestoreState");
        bRestoreState_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bRestoreState");
        bDisableMovementInput_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bDisableMovementInput");
        bDisableMovementInput_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bDisableMovementInput");
        bDisableLookAtInput_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bDisableLookAtInput");
        bDisableLookAtInput_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bDisableLookAtInput");
        bHidePlayer_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bHidePlayer");
        bHidePlayer_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bHidePlayer");
        bHideHud_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bHideHud");
        bHideHud_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bHideHud");
        bDisableCameraCuts_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bDisableCameraCuts");
        bDisableCameraCuts_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bDisableCameraCuts");
        bPauseAtEnd_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bPauseAtEnd");
        bPauseAtEnd_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bPauseAtEnd");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public MovieSceneSequencePlaybackSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            AutoPlay = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bAutoPlay_NativeProperty, bAutoPlay_Offset);
            LoopCount = BlittableMarshaller<UnrealSharp.MovieScene.MovieSceneSequenceLoopCount>.FromNative(IntPtr.Add(InNativeStruct, LoopCount_Offset), 0, null);
            PlayRate = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, PlayRate_Offset), 0, null);
            StartTime = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, StartTime_Offset), 0, null);
            RandomStartTime = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bRandomStartTime_NativeProperty, bRandomStartTime_Offset);
            RestoreState = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bRestoreState_NativeProperty, bRestoreState_Offset);
            DisableMovementInput = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bDisableMovementInput_NativeProperty, bDisableMovementInput_Offset);
            DisableLookAtInput = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bDisableLookAtInput_NativeProperty, bDisableLookAtInput_Offset);
            HidePlayer = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bHidePlayer_NativeProperty, bHidePlayer_Offset);
            HideHud = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bHideHud_NativeProperty, bHideHud_Offset);
            DisableCameraCuts = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bDisableCameraCuts_NativeProperty, bDisableCameraCuts_Offset);
            PauseAtEnd = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bPauseAtEnd_NativeProperty, bPauseAtEnd_Offset);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bAutoPlay_NativeProperty, bAutoPlay_Offset, AutoPlay);
            BlittableMarshaller<UnrealSharp.MovieScene.MovieSceneSequenceLoopCount>.ToNative(IntPtr.Add(Buffer, LoopCount_Offset), 0, null, LoopCount);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, PlayRate_Offset), 0, null, PlayRate);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, StartTime_Offset), 0, null, StartTime);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bRandomStartTime_NativeProperty, bRandomStartTime_Offset, RandomStartTime);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bRestoreState_NativeProperty, bRestoreState_Offset, RestoreState);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bDisableMovementInput_NativeProperty, bDisableMovementInput_Offset, DisableMovementInput);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bDisableLookAtInput_NativeProperty, bDisableLookAtInput_Offset, DisableLookAtInput);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bHidePlayer_NativeProperty, bHidePlayer_Offset, HidePlayer);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bHideHud_NativeProperty, bHideHud_Offset, HideHud);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bDisableCameraCuts_NativeProperty, bDisableCameraCuts_Offset, DisableCameraCuts);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bPauseAtEnd_NativeProperty, bPauseAtEnd_Offset, PauseAtEnd);
        }
    }
}

public static class MovieSceneSequencePlaybackSettingsMarshaler
{
    public static MovieSceneSequencePlaybackSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new MovieSceneSequencePlaybackSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, MovieSceneSequencePlaybackSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return MovieSceneSequencePlaybackSettings.NativeDataSize;
    }
}