using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum ERichCurveInterpMode : byte
{
    RCIM_Linear=0,
    RCIM_Constant=1,
    RCIM_Cubic=2,
}