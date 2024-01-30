using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum ETransformCurveChannel : byte
{
    Position=0,
    Rotation=1,
    Scale=2,
    Invalid=3,
}