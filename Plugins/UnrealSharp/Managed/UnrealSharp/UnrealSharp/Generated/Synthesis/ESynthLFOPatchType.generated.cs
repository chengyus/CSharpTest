using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Synthesis;

[UEnum]
public enum ESynthLFOPatchType : byte
{
    PatchToNone=0,
    PatchToGain=1,
    PatchToOscFreq=2,
    PatchToFilterFreq=3,
    PatchToFilterQ=4,
    PatchToOscPulseWidth=5,
    PatchToOscPan=6,
    PatchLFO1ToLFO2Frequency=7,
    PatchLFO1ToLFO2Gain=8,
}