using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum EAspectRatioAxisConstraint : byte
{
    AspectRatio_MaintainYFOV=0,
    AspectRatio_MaintainXFOV=1,
    AspectRatio_MajorAxisFOV=2,
}