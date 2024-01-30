using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Foliage;

[UEnum]
public enum ESimulationOverlap : byte
{
    CollisionOverlap=0,
    ShadeOverlap=1,
    None=2,
}