using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AnimGraphRuntime;

[UEnum]
public enum EModifyCurveApplyMode : byte
{
    Add=0,
    Scale=1,
    Blend=2,
    WeightedMovingAverage=3,
    RemapCurve=4,
}