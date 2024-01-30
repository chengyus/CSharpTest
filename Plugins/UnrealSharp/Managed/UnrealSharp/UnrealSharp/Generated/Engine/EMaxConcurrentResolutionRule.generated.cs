using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum EMaxConcurrentResolutionRule : byte
{
    PreventNew=0,
    StopOldest=1,
    StopFarthestThenPreventNew=2,
    StopFarthestThenOldest=3,
    StopLowestPriority=4,
    StopQuietest=5,
    StopLowestPriorityThenPreventNew=6,
}