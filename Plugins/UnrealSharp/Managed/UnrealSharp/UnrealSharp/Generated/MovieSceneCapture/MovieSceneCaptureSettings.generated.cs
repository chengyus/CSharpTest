using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.MovieSceneCapture;

[UStruct]
public partial struct MovieSceneCaptureSettings
{
    // StructProperty /Script/MovieSceneCapture.MovieSceneCaptureSettings:OutputDirectory
    static readonly int OutputDirectory_Offset;
    public UnrealSharp.CoreUObject.DirectoryPath OutputDirectory;
    
    // ClassProperty /Script/MovieSceneCapture.MovieSceneCaptureSettings:GameModeOverride
    static readonly int GameModeOverride_Offset;
    public SubclassOf<UnrealSharp.Engine.GameModeBase> GameModeOverride;
    
    // BoolProperty /Script/MovieSceneCapture.MovieSceneCaptureSettings:bOverwriteExisting
    static readonly int bOverwriteExisting_Offset;
    public bool OverwriteExisting;
    
    // BoolProperty /Script/MovieSceneCapture.MovieSceneCaptureSettings:bUseRelativeFrameNumbers
    static readonly int bUseRelativeFrameNumbers_Offset;
    public bool UseRelativeFrameNumbers;
    
    // IntProperty /Script/MovieSceneCapture.MovieSceneCaptureSettings:HandleFrames
    static readonly int HandleFrames_Offset;
    public int HandleFrames;
    
    // ByteProperty /Script/MovieSceneCapture.MovieSceneCaptureSettings:ZeroPadFrameNumbers
    static readonly int ZeroPadFrameNumbers_Offset;
    public byte ZeroPadFrameNumbers;
    
    // StructProperty /Script/MovieSceneCapture.MovieSceneCaptureSettings:FrameRate
    static readonly int FrameRate_Offset;
    public UnrealSharp.CoreUObject.FrameRate FrameRate;
    
    // BoolProperty /Script/MovieSceneCapture.MovieSceneCaptureSettings:bUseCustomFrameRate
    static readonly int bUseCustomFrameRate_Offset;
    public bool UseCustomFrameRate;
    
    // StructProperty /Script/MovieSceneCapture.MovieSceneCaptureSettings:CustomFrameRate
    static readonly int CustomFrameRate_Offset;
    public UnrealSharp.CoreUObject.FrameRate CustomFrameRate;
    
    // StructProperty /Script/MovieSceneCapture.MovieSceneCaptureSettings:Resolution
    static readonly int Resolution_Offset;
    public UnrealSharp.MovieSceneCapture.CaptureResolution Resolution;
    
    // BoolProperty /Script/MovieSceneCapture.MovieSceneCaptureSettings:bEnableTextureStreaming
    static readonly int bEnableTextureStreaming_Offset;
    public bool EnableTextureStreaming;
    
    // BoolProperty /Script/MovieSceneCapture.MovieSceneCaptureSettings:bCinematicEngineScalability
    static readonly int bCinematicEngineScalability_Offset;
    public bool CinematicEngineScalability;
    
    // BoolProperty /Script/MovieSceneCapture.MovieSceneCaptureSettings:bCinematicMode
    static readonly int bCinematicMode_Offset;
    public bool CinematicMode;
    
    // BoolProperty /Script/MovieSceneCapture.MovieSceneCaptureSettings:bAllowMovement
    static readonly int bAllowMovement_Offset;
    public bool AllowMovement;
    
    // BoolProperty /Script/MovieSceneCapture.MovieSceneCaptureSettings:bAllowTurning
    static readonly int bAllowTurning_Offset;
    public bool AllowTurning;
    
    // BoolProperty /Script/MovieSceneCapture.MovieSceneCaptureSettings:bShowPlayer
    static readonly int bShowPlayer_Offset;
    public bool ShowPlayer;
    
    // BoolProperty /Script/MovieSceneCapture.MovieSceneCaptureSettings:bShowHUD
    static readonly int bShowHUD_Offset;
    public bool ShowHUD;
    
    // BoolProperty /Script/MovieSceneCapture.MovieSceneCaptureSettings:bUsePathTracer
    static readonly int bUsePathTracer_Offset;
    public bool UsePathTracer;
    
    // IntProperty /Script/MovieSceneCapture.MovieSceneCaptureSettings:PathTracerSamplePerPixel
    static readonly int PathTracerSamplePerPixel_Offset;
    public int PathTracerSamplePerPixel;
    
    
    public static readonly int NativeDataSize;
    static MovieSceneCaptureSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("MovieSceneCaptureSettings");
        
        OutputDirectory_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "OutputDirectory");
        GameModeOverride_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "GameModeOverride");
        bOverwriteExisting_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverwriteExisting");
        bUseRelativeFrameNumbers_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bUseRelativeFrameNumbers");
        HandleFrames_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "HandleFrames");
        ZeroPadFrameNumbers_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ZeroPadFrameNumbers");
        FrameRate_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FrameRate");
        bUseCustomFrameRate_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bUseCustomFrameRate");
        CustomFrameRate_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CustomFrameRate");
        Resolution_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Resolution");
        bEnableTextureStreaming_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bEnableTextureStreaming");
        bCinematicEngineScalability_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bCinematicEngineScalability");
        bCinematicMode_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bCinematicMode");
        bAllowMovement_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bAllowMovement");
        bAllowTurning_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bAllowTurning");
        bShowPlayer_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bShowPlayer");
        bShowHUD_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bShowHUD");
        bUsePathTracer_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bUsePathTracer");
        PathTracerSamplePerPixel_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PathTracerSamplePerPixel");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public MovieSceneCaptureSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            OutputDirectory = UnrealSharp.CoreUObject.DirectoryPathMarshaler.FromNative(IntPtr.Add(InNativeStruct, OutputDirectory_Offset), 0, null);
            GameModeOverride = SubclassOfMarshaller<UnrealSharp.Engine.GameModeBase>.FromNative(IntPtr.Add(InNativeStruct, GameModeOverride_Offset), 0, null);
            OverwriteExisting = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bOverwriteExisting_Offset), 0, null);
            UseRelativeFrameNumbers = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bUseRelativeFrameNumbers_Offset), 0, null);
            HandleFrames = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, HandleFrames_Offset), 0, null);
            ZeroPadFrameNumbers = BlittableMarshaller<byte>.FromNative(IntPtr.Add(InNativeStruct, ZeroPadFrameNumbers_Offset), 0, null);
            FrameRate = BlittableMarshaller<UnrealSharp.CoreUObject.FrameRate>.FromNative(IntPtr.Add(InNativeStruct, FrameRate_Offset), 0, null);
            UseCustomFrameRate = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bUseCustomFrameRate_Offset), 0, null);
            CustomFrameRate = BlittableMarshaller<UnrealSharp.CoreUObject.FrameRate>.FromNative(IntPtr.Add(InNativeStruct, CustomFrameRate_Offset), 0, null);
            Resolution = BlittableMarshaller<UnrealSharp.MovieSceneCapture.CaptureResolution>.FromNative(IntPtr.Add(InNativeStruct, Resolution_Offset), 0, null);
            EnableTextureStreaming = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bEnableTextureStreaming_Offset), 0, null);
            CinematicEngineScalability = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bCinematicEngineScalability_Offset), 0, null);
            CinematicMode = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bCinematicMode_Offset), 0, null);
            AllowMovement = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bAllowMovement_Offset), 0, null);
            AllowTurning = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bAllowTurning_Offset), 0, null);
            ShowPlayer = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bShowPlayer_Offset), 0, null);
            ShowHUD = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bShowHUD_Offset), 0, null);
            UsePathTracer = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bUsePathTracer_Offset), 0, null);
            PathTracerSamplePerPixel = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, PathTracerSamplePerPixel_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.CoreUObject.DirectoryPathMarshaler.ToNative(IntPtr.Add(Buffer, OutputDirectory_Offset), 0, null, OutputDirectory);
            SubclassOfMarshaller<UnrealSharp.Engine.GameModeBase>.ToNative(IntPtr.Add(Buffer, GameModeOverride_Offset), 0, null, GameModeOverride);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bOverwriteExisting_Offset), 0, null, OverwriteExisting);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bUseRelativeFrameNumbers_Offset), 0, null, UseRelativeFrameNumbers);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, HandleFrames_Offset), 0, null, HandleFrames);
            BlittableMarshaller<byte>.ToNative(IntPtr.Add(Buffer, ZeroPadFrameNumbers_Offset), 0, null, ZeroPadFrameNumbers);
            BlittableMarshaller<UnrealSharp.CoreUObject.FrameRate>.ToNative(IntPtr.Add(Buffer, FrameRate_Offset), 0, null, FrameRate);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bUseCustomFrameRate_Offset), 0, null, UseCustomFrameRate);
            BlittableMarshaller<UnrealSharp.CoreUObject.FrameRate>.ToNative(IntPtr.Add(Buffer, CustomFrameRate_Offset), 0, null, CustomFrameRate);
            BlittableMarshaller<UnrealSharp.MovieSceneCapture.CaptureResolution>.ToNative(IntPtr.Add(Buffer, Resolution_Offset), 0, null, Resolution);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bEnableTextureStreaming_Offset), 0, null, EnableTextureStreaming);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bCinematicEngineScalability_Offset), 0, null, CinematicEngineScalability);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bCinematicMode_Offset), 0, null, CinematicMode);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bAllowMovement_Offset), 0, null, AllowMovement);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bAllowTurning_Offset), 0, null, AllowTurning);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bShowPlayer_Offset), 0, null, ShowPlayer);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bShowHUD_Offset), 0, null, ShowHUD);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bUsePathTracer_Offset), 0, null, UsePathTracer);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, PathTracerSamplePerPixel_Offset), 0, null, PathTracerSamplePerPixel);
        }
    }
}

public static class MovieSceneCaptureSettingsMarshaler
{
    public static MovieSceneCaptureSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new MovieSceneCaptureSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, MovieSceneCaptureSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return MovieSceneCaptureSettings.NativeDataSize;
    }
}