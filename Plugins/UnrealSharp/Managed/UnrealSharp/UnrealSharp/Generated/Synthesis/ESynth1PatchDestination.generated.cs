using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Synthesis;

[UEnum]
public enum ESynth1PatchDestination : byte
{
    Osc1Gain=0,
    Osc1Frequency=1,
    Osc1Pulsewidth=2,
    Osc2Gain=3,
    Osc2Frequency=4,
    Osc2Pulsewidth=5,
    FilterFrequency=6,
    FilterQ=7,
    Gain=8,
    Pan=9,
    LFO1Frequency=10,
    LFO1Gain=11,
    LFO2Frequency=12,
    LFO2Gain=13,
}