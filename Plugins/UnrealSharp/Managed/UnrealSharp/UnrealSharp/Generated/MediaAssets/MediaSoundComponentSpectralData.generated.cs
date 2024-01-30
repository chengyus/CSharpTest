using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.MediaAssets;

[UStruct(IsBlittable = true)]
public partial struct MediaSoundComponentSpectralData
{
    // FloatProperty /Script/MediaAssets.MediaSoundComponentSpectralData:FrequencyHz
    public float FrequencyHz;
    
    // FloatProperty /Script/MediaAssets.MediaSoundComponentSpectralData:Magnitude
    public float Magnitude;
    
}