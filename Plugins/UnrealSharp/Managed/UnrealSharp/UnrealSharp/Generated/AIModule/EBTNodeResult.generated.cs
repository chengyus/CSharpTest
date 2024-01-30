using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AIModule;

[UEnum]
public enum EBTNodeResult : byte
{
    Succeeded=0,
    Failed=1,
    Aborted=2,
    InProgress=3,
}