using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum ESplinePointType : byte
{
    Linear=0,
    Curve=1,
    Constant=2,
    CurveClamped=3,
    CurveCustomTangent=4,
}