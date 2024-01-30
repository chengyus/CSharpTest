using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AIModule;

[UEnum]
public enum EPathFollowingStatus : byte
{
    Idle=0,
    Waiting=1,
    Paused=2,
    Moving=3,
}