using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum EAttenuationDistanceModel : byte
{
    Linear=0,
    Logarithmic=1,
    Inverse=2,
    LogReverse=3,
    NaturalSound=4,
    Custom=5,
}