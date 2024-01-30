using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ModelingComponents;

[UEnum]
public enum ECreateMeshObjectSourceMeshType : byte
{
    MeshDescription=0,
    DynamicMesh=1,
}