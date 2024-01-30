using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum ELumenRayLightingModeOverride : byte
{
    Default=0,
    SurfaceCache=1,
    HitLighting=2,
}