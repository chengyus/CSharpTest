using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum EEndPlayReason : byte
{
    Destroyed=0,
    LevelTransition=1,
    EndPlayInEditor=2,
    RemovedFromWorld=3,
    Quit=4,
}