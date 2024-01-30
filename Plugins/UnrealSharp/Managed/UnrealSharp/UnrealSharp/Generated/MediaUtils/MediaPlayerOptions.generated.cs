using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.MediaUtils;

[UStruct]
public partial struct MediaPlayerOptions
{
    // StructProperty /Script/MediaUtils.MediaPlayerOptions:Tracks
    static readonly int Tracks_Offset;
    public UnrealSharp.MediaUtils.MediaPlayerTrackOptions Tracks;
    
    // StructProperty /Script/MediaUtils.MediaPlayerOptions:SeekTime
    static readonly int SeekTime_Offset;
    public UnrealSharp.CoreUObject.Timespan SeekTime;
    
    // EnumProperty /Script/MediaUtils.MediaPlayerOptions:PlayOnOpen
    static readonly int PlayOnOpen_Offset;
    public UnrealSharp.MediaUtils.EMediaPlayerOptionBooleanOverride PlayOnOpen;
    
    // EnumProperty /Script/MediaUtils.MediaPlayerOptions:Loop
    static readonly int Loop_Offset;
    public UnrealSharp.MediaUtils.EMediaPlayerOptionBooleanOverride Loop;
    
    
    public static readonly int NativeDataSize;
    static MediaPlayerOptions()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("MediaPlayerOptions");
        
        Tracks_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Tracks");
        SeekTime_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SeekTime");
        PlayOnOpen_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PlayOnOpen");
        Loop_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Loop");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public MediaPlayerOptions(IntPtr InNativeStruct)
    {
        unsafe
        {
            Tracks = BlittableMarshaller<UnrealSharp.MediaUtils.MediaPlayerTrackOptions>.FromNative(IntPtr.Add(InNativeStruct, Tracks_Offset), 0, null);
            SeekTime = UnrealSharp.CoreUObject.TimespanMarshaler.FromNative(IntPtr.Add(InNativeStruct, SeekTime_Offset), 0, null);
            PlayOnOpen = BlittableMarshaller<UnrealSharp.MediaUtils.EMediaPlayerOptionBooleanOverride>.FromNative(IntPtr.Add(InNativeStruct, PlayOnOpen_Offset), 0, null);
            Loop = BlittableMarshaller<UnrealSharp.MediaUtils.EMediaPlayerOptionBooleanOverride>.FromNative(IntPtr.Add(InNativeStruct, Loop_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.MediaUtils.MediaPlayerTrackOptions>.ToNative(IntPtr.Add(Buffer, Tracks_Offset), 0, null, Tracks);
            UnrealSharp.CoreUObject.TimespanMarshaler.ToNative(IntPtr.Add(Buffer, SeekTime_Offset), 0, null, SeekTime);
            BlittableMarshaller<UnrealSharp.MediaUtils.EMediaPlayerOptionBooleanOverride>.ToNative(IntPtr.Add(Buffer, PlayOnOpen_Offset), 0, null, PlayOnOpen);
            BlittableMarshaller<UnrealSharp.MediaUtils.EMediaPlayerOptionBooleanOverride>.ToNative(IntPtr.Add(Buffer, Loop_Offset), 0, null, Loop);
        }
    }
}

public static class MediaPlayerOptionsMarshaler
{
    public static MediaPlayerOptions FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new MediaPlayerOptions(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, MediaPlayerOptions obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return MediaPlayerOptions.NativeDataSize;
    }
}