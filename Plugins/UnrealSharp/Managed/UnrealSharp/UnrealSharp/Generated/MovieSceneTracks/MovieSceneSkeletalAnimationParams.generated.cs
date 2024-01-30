using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.MovieSceneTracks;

[UStruct]
public partial struct MovieSceneSkeletalAnimationParams
{
    // ObjectProperty /Script/MovieSceneTracks.MovieSceneSkeletalAnimationParams:Animation
    static readonly int Animation_Offset;
    public UnrealSharp.Engine.AnimSequenceBase Animation;
    
    // StructProperty /Script/MovieSceneTracks.MovieSceneSkeletalAnimationParams:FirstLoopStartFrameOffset
    static readonly int FirstLoopStartFrameOffset_Offset;
    public UnrealSharp.CoreUObject.FrameNumber FirstLoopStartFrameOffset;
    
    // StructProperty /Script/MovieSceneTracks.MovieSceneSkeletalAnimationParams:StartFrameOffset
    static readonly int StartFrameOffset_Offset;
    public UnrealSharp.CoreUObject.FrameNumber StartFrameOffset;
    
    // StructProperty /Script/MovieSceneTracks.MovieSceneSkeletalAnimationParams:EndFrameOffset
    static readonly int EndFrameOffset_Offset;
    public UnrealSharp.CoreUObject.FrameNumber EndFrameOffset;
    
    // FloatProperty /Script/MovieSceneTracks.MovieSceneSkeletalAnimationParams:PlayRate
    static readonly int PlayRate_Offset;
    public float PlayRate;
    
    // BoolProperty /Script/MovieSceneTracks.MovieSceneSkeletalAnimationParams:bReverse
    static readonly int bReverse_Offset;
    static readonly IntPtr bReverse_NativeProperty;
    public bool Reverse;
    
    // NameProperty /Script/MovieSceneTracks.MovieSceneSkeletalAnimationParams:SlotName
    static readonly int SlotName_Offset;
    public Name SlotName;
    
    // ObjectProperty /Script/MovieSceneTracks.MovieSceneSkeletalAnimationParams:MirrorDataTable
    static readonly int MirrorDataTable_Offset;
    public UnrealSharp.Engine.MirrorDataTable MirrorDataTable;
    
    // BoolProperty /Script/MovieSceneTracks.MovieSceneSkeletalAnimationParams:bSkipAnimNotifiers
    static readonly int bSkipAnimNotifiers_Offset;
    public bool SkipAnimNotifiers;
    
    // BoolProperty /Script/MovieSceneTracks.MovieSceneSkeletalAnimationParams:bForceCustomMode
    static readonly int bForceCustomMode_Offset;
    public bool ForceCustomMode;
    
    // EnumProperty /Script/MovieSceneTracks.MovieSceneSkeletalAnimationParams:SwapRootBone
    static readonly int SwapRootBone_Offset;
    public UnrealSharp.AnimGraphRuntime.ESwapRootBone SwapRootBone;
    
    
    public static readonly int NativeDataSize;
    static MovieSceneSkeletalAnimationParams()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("MovieSceneSkeletalAnimationParams");
        
        Animation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Animation");
        FirstLoopStartFrameOffset_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FirstLoopStartFrameOffset");
        StartFrameOffset_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "StartFrameOffset");
        EndFrameOffset_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "EndFrameOffset");
        PlayRate_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PlayRate");
        bReverse_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bReverse");
        bReverse_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bReverse");
        SlotName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SlotName");
        MirrorDataTable_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MirrorDataTable");
        bSkipAnimNotifiers_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bSkipAnimNotifiers");
        bForceCustomMode_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bForceCustomMode");
        SwapRootBone_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SwapRootBone");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public MovieSceneSkeletalAnimationParams(IntPtr InNativeStruct)
    {
        unsafe
        {
            Animation = ObjectMarshaller<UnrealSharp.Engine.AnimSequenceBase>.FromNative(IntPtr.Add(InNativeStruct, Animation_Offset), 0, null);
            FirstLoopStartFrameOffset = BlittableMarshaller<UnrealSharp.CoreUObject.FrameNumber>.FromNative(IntPtr.Add(InNativeStruct, FirstLoopStartFrameOffset_Offset), 0, null);
            StartFrameOffset = BlittableMarshaller<UnrealSharp.CoreUObject.FrameNumber>.FromNative(IntPtr.Add(InNativeStruct, StartFrameOffset_Offset), 0, null);
            EndFrameOffset = BlittableMarshaller<UnrealSharp.CoreUObject.FrameNumber>.FromNative(IntPtr.Add(InNativeStruct, EndFrameOffset_Offset), 0, null);
            PlayRate = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, PlayRate_Offset), 0, null);
            Reverse = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bReverse_NativeProperty, bReverse_Offset);
            SlotName = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, SlotName_Offset), 0, null);
            MirrorDataTable = ObjectMarshaller<UnrealSharp.Engine.MirrorDataTable>.FromNative(IntPtr.Add(InNativeStruct, MirrorDataTable_Offset), 0, null);
            SkipAnimNotifiers = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bSkipAnimNotifiers_Offset), 0, null);
            ForceCustomMode = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bForceCustomMode_Offset), 0, null);
            SwapRootBone = BlittableMarshaller<UnrealSharp.AnimGraphRuntime.ESwapRootBone>.FromNative(IntPtr.Add(InNativeStruct, SwapRootBone_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            ObjectMarshaller<UnrealSharp.Engine.AnimSequenceBase>.ToNative(IntPtr.Add(Buffer, Animation_Offset), 0, null, Animation);
            BlittableMarshaller<UnrealSharp.CoreUObject.FrameNumber>.ToNative(IntPtr.Add(Buffer, FirstLoopStartFrameOffset_Offset), 0, null, FirstLoopStartFrameOffset);
            BlittableMarshaller<UnrealSharp.CoreUObject.FrameNumber>.ToNative(IntPtr.Add(Buffer, StartFrameOffset_Offset), 0, null, StartFrameOffset);
            BlittableMarshaller<UnrealSharp.CoreUObject.FrameNumber>.ToNative(IntPtr.Add(Buffer, EndFrameOffset_Offset), 0, null, EndFrameOffset);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, PlayRate_Offset), 0, null, PlayRate);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bReverse_NativeProperty, bReverse_Offset, Reverse);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, SlotName_Offset), 0, null, SlotName);
            ObjectMarshaller<UnrealSharp.Engine.MirrorDataTable>.ToNative(IntPtr.Add(Buffer, MirrorDataTable_Offset), 0, null, MirrorDataTable);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bSkipAnimNotifiers_Offset), 0, null, SkipAnimNotifiers);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bForceCustomMode_Offset), 0, null, ForceCustomMode);
            BlittableMarshaller<UnrealSharp.AnimGraphRuntime.ESwapRootBone>.ToNative(IntPtr.Add(Buffer, SwapRootBone_Offset), 0, null, SwapRootBone);
        }
    }
}

public static class MovieSceneSkeletalAnimationParamsMarshaler
{
    public static MovieSceneSkeletalAnimationParams FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new MovieSceneSkeletalAnimationParams(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, MovieSceneSkeletalAnimationParams obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return MovieSceneSkeletalAnimationParams.NativeDataSize;
    }
}