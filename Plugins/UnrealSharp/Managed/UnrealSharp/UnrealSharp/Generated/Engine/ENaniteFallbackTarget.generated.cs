using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum ENaniteFallbackTarget : byte
{
    Auto=0,
    PercentTriangles=1,
    RelativeError=2,
}