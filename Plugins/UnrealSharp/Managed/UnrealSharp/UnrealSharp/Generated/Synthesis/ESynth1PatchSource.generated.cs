using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Synthesis;

[UEnum]
public enum ESynth1PatchSource : byte
{
    LFO1=0,
    LFO2=1,
    Envelope=2,
    BiasEnvelope=3,
}