using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AIModule;

[UEnum]
public enum EPawnActionResult : byte
{
    NotStarted=0,
    InProgress=1,
    Success=2,
    Failed=3,
    Aborted=4,
}