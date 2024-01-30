using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.GeometryFramework;

[UEnum]
public enum EDynamicMeshVertexColorTransformMode : byte
{
    NoTransform=0,
    LinearToSRGB=1,
    SRGBToLinear=2,
}