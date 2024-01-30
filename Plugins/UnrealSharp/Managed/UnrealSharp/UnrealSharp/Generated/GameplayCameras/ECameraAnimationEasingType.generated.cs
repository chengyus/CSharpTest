using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.GameplayCameras;

[UEnum]
public enum ECameraAnimationEasingType : byte
{
    Linear=0,
    Sinusoidal=1,
    Quadratic=2,
    Cubic=3,
    Quartic=4,
    Quintic=5,
    Exponential=6,
    Circular=7,
}