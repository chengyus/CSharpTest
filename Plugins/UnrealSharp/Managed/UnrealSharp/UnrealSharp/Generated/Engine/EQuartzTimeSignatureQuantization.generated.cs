using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum EQuartzTimeSignatureQuantization : byte
{
    HalfNote=0,
    QuarterNote=1,
    EighthNote=2,
    SixteenthNote=3,
    ThirtySecondNote=4,
}