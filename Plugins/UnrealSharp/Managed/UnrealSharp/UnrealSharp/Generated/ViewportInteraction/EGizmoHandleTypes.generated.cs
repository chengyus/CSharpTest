using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ViewportInteraction;

[UEnum]
public enum EGizmoHandleTypes : byte
{
    All=0,
    Translate=1,
    Rotate=2,
    Scale=3,
}