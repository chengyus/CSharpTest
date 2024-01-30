using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.GeometryFramework;

[UEnum]
public enum EDynamicMeshComponentColorOverrideMode : byte
{
    None=0,
    VertexColors=1,
    Polygroups=2,
    Constant=3,
}