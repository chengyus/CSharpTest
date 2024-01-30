using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum ELerpInterpolationMode : byte
{
    QuatInterp=0,
    EulerInterp=1,
    DualQuatInterp=2,
}