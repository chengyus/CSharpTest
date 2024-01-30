using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Synthesis;

[UEnum]
public enum ESourceEffectMotionFilterModSource : byte
{
    DistanceFromListener=0,
    SpeedRelativeToListener=1,
    SpeedOfSourceEmitter=2,
    SpeedOfListener=3,
    SpeedOfAngleDelta=4,
}