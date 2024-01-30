using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum ERoundingMode : byte
{
    HalfToEven=0,
    HalfFromZero=1,
    HalfToZero=2,
    FromZero=3,
    ToZero=4,
    ToNegativeInfinity=5,
    ToPositiveInfinity=6,
}