using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Paper2D;

[UEnum]
public enum ETileMapProjectionMode : byte
{
    Orthogonal=0,
    IsometricDiamond=1,
    IsometricStaggered=2,
    HexagonalStaggered=3,
}