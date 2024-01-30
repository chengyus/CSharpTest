using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum EMeshApproximationGroundPlaneClippingPolicy : byte
{
    NoGroundClipping=0,
    DiscardWithZPlane=1,
    CutWithZPlane=2,
    CutAndFillWithZPlane=3,
}