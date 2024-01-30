using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Synthesis;

[UEnum]
public enum ESynth1OscType : byte
{
    Sine=0,
    Saw=1,
    Triangle=2,
    Square=3,
    Noise=4,
}