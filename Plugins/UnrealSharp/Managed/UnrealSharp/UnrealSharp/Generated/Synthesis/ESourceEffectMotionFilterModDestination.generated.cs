using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Synthesis;

[UEnum]
public enum ESourceEffectMotionFilterModDestination : byte
{
    FilterACutoffFrequency=0,
    FilterAResonance=1,
    FilterAOutputVolumeDB=2,
    FilterBCutoffFrequency=3,
    FilterBResonance=4,
    FilterBOutputVolumeDB=5,
    FilterMix=6,
}