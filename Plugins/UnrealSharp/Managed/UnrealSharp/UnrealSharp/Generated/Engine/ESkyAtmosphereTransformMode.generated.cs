using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum ESkyAtmosphereTransformMode : byte
{
    PlanetTopAtAbsoluteWorldOrigin=0,
    PlanetTopAtComponentTransform=1,
    PlanetCenterAtComponentTransform=2,
}