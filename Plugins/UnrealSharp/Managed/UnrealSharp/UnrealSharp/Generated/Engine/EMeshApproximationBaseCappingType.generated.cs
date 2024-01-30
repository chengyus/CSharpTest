using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum EMeshApproximationBaseCappingType : byte
{
    NoBaseCapping=0,
    ConvexPolygon=1,
    ConvexSolid=2,
}