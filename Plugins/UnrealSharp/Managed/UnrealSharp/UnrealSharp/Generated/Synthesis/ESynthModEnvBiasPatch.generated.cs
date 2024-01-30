using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Synthesis;

[UEnum]
public enum ESynthModEnvBiasPatch : byte
{
    PatchToNone=0,
    PatchToOscFreq=1,
    PatchToFilterFreq=2,
    PatchToFilterQ=3,
    PatchToLFO1Gain=4,
    PatchToLFO2Gain=5,
    PatchToLFO1Freq=6,
    PatchToLFO2Freq=7,
}