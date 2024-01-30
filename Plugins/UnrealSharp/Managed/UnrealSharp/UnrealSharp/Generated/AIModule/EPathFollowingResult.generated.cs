using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AIModule;

[UEnum]
public enum EPathFollowingResult : byte
{
    Success=0,
    Blocked=1,
    OffPath=2,
    Aborted=3,
    Invalid=5,
}