using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum EAnimCurveType : byte
{
    AttributeCurve=0,
    MaterialCurve=1,
    MorphTargetCurve=2,
}