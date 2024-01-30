using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.CinematicCamera;

[UEnum]
public enum ECameraFocusMethod : byte
{
    DoNotOverride=0,
    Manual=1,
    Tracking=2,
    Disable=3,
}