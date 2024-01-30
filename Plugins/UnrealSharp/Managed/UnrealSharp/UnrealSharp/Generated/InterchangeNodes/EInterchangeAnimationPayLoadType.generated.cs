using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.InterchangeNodes;

[UEnum]
public enum EInterchangeAnimationPayLoadType : byte
{
    NONE=0,
    CURVE=1,
    MORPHTARGETCURVE=2,
    STEPCURVE=3,
    BAKED=4,
    MORPHTARGETCURVEWEIGHTINSTANCE=5,
}