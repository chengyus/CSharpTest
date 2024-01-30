using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.GeometryFramework;

[UEnum]
public enum EDynamicMeshAttributeChangeFlags : byte
{
    Unknown=0,
    MeshTopology=1,
    VertexPositions=2,
    NormalsTangents=3,
    VertexColors=4,
    UVs=5,
    TriangleGroups=6,
}