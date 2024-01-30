using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.GeometryFramework;

[UEnum]
public enum EDynamicMeshChangeType : byte
{
    GeneralEdit=0,
    MeshChange=1,
    MeshReplacementChange=2,
    MeshVertexChange=3,
    DeformationEdit=4,
    AttributeEdit=5,
}