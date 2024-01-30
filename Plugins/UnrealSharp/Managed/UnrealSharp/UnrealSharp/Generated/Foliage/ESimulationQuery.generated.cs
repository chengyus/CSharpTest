using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Foliage;

[UEnum]
public enum ESimulationQuery : byte
{
    CollisionOverlap=1,
    ShadeOverlap=2,
    AnyOverlap=3,
}