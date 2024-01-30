using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum EMeshApproximationSimplificationPolicy : byte
{
    FixedTriangleCount=0,
    TrianglesPerArea=1,
    GeometricTolerance=2,
}