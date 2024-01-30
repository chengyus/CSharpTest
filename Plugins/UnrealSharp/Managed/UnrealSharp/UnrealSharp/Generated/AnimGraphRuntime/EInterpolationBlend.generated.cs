using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AnimGraphRuntime;

[UEnum]
public enum EInterpolationBlend : byte
{
    Linear=0,
    Cubic=1,
    Sinusoidal=2,
    EaseInOutExponent2=3,
    EaseInOutExponent3=4,
    EaseInOutExponent4=5,
    EaseInOutExponent5=6,
}