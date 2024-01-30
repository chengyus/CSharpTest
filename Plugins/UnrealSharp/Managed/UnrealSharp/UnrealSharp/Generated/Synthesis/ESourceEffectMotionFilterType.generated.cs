using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Synthesis;

[UEnum]
public enum ESourceEffectMotionFilterType : byte
{
    LowPass=0,
    HighPass=1,
    BandPass=2,
    BandStop=3,
}