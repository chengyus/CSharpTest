using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.MediaUtils;

[UStruct(IsBlittable = true)]
public partial struct MediaPlayerTrackOptions
{
    // IntProperty /Script/MediaUtils.MediaPlayerTrackOptions:Audio
    public int Audio;
    
    // IntProperty /Script/MediaUtils.MediaPlayerTrackOptions:Caption
    public int Caption;
    
    // IntProperty /Script/MediaUtils.MediaPlayerTrackOptions:Metadata
    public int Metadata;
    
    // IntProperty /Script/MediaUtils.MediaPlayerTrackOptions:Script
    public int Script;
    
    // IntProperty /Script/MediaUtils.MediaPlayerTrackOptions:Subtitle
    public int Subtitle;
    
    // IntProperty /Script/MediaUtils.MediaPlayerTrackOptions:Text
    public int Text;
    
    // IntProperty /Script/MediaUtils.MediaPlayerTrackOptions:Video
    public int Video;
    
}