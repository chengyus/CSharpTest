using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ResonanceAudio;

[UEnum]
public enum ERaQualityMode : byte
{
    STEREO_PANNING=0,
    BINAURAL_LOW=1,
    BINAURAL_MEDIUM=2,
    BINAURAL_HIGH=3,
}