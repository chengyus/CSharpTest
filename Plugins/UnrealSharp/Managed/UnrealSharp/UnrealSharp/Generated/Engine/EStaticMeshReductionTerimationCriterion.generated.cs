using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum EStaticMeshReductionTerimationCriterion : byte
{
    Triangles=0,
    Vertices=1,
    Any=2,
}