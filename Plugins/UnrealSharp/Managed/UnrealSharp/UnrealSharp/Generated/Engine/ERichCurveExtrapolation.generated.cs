using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum ERichCurveExtrapolation : byte
{
    RCCE_Cycle=0,
    RCCE_CycleWithOffset=1,
    RCCE_Oscillate=2,
    RCCE_Linear=3,
    RCCE_Constant=4,
    RCCE_None=5,
}