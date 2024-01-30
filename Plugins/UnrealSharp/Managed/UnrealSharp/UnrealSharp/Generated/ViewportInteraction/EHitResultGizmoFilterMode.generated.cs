using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ViewportInteraction;

[UEnum]
public enum EHitResultGizmoFilterMode : byte
{
    All=0,
    NoGizmos=1,
    GizmosOnly=2,
}