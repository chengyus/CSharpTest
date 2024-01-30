using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum EWalkableSlopeBehavior : byte
{
    WalkableSlope_Default=0,
    WalkableSlope_Increase=1,
    WalkableSlope_Decrease=2,
    WalkableSlope_Unwalkable=3,
}