using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ResonanceAudio;

[UEnum]
public enum EResonanceRenderMode : byte
{
    StereoPanning=0,
    BinauralLowQuality=1,
    BinauralMediumQuality=2,
    BinauralHighQuality=3,
    RoomEffectsOnly=4,
}