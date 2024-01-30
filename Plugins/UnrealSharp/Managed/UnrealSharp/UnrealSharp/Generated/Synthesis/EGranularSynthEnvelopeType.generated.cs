using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Synthesis;

[UEnum]
public enum EGranularSynthEnvelopeType : byte
{
    Rectangular=0,
    Triangle=1,
    DownwardTriangle=2,
    UpwardTriangle=3,
    ExponentialDecay=4,
    ExponentialIncrease=5,
    Gaussian=6,
    Hanning=7,
    Lanczos=8,
    Cosine=9,
    CosineSquared=10,
    Welch=11,
    Blackman=12,
    BlackmanHarris=13,
}