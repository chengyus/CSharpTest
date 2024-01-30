using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum EAlphaBlendOption : byte
{
    Linear=0,
    Cubic=1,
    HermiteCubic=2,
    Sinusoidal=3,
    QuadraticInOut=4,
    CubicInOut=5,
    QuarticInOut=6,
    QuinticInOut=7,
    CircularIn=8,
    CircularOut=9,
    CircularInOut=10,
    ExpIn=11,
    ExpOut=12,
    ExpInOut=13,
    Custom=14,
}