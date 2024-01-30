using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum EActorUpdateOverlapsMethod : byte
{
    UseConfigDefault=0,
    AlwaysUpdate=1,
    OnlyUpdateMovable=2,
    NeverUpdate=3,
}