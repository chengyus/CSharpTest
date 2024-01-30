using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum EQuartzCommandQuantization : byte
{
    Bar=0,
    Beat=1,
    ThirtySecondNote=2,
    SixteenthNote=3,
    EighthNote=4,
    QuarterNote=5,
    HalfNote=6,
    WholeNote=7,
    DottedSixteenthNote=8,
    DottedEighthNote=9,
    DottedQuarterNote=10,
    DottedHalfNote=11,
    DottedWholeNote=12,
    SixteenthNoteTriplet=13,
    EighthNoteTriplet=14,
    QuarterNoteTriplet=15,
    HalfNoteTriplet=16,
    Tick=17,
    None=19,
}