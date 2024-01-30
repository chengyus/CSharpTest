using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum EFFTPeakInterpolationMethod : byte
{
    NearestNeighbor=0,
    Linear=1,
    Quadratic=2,
    ConstantQ=3,
}