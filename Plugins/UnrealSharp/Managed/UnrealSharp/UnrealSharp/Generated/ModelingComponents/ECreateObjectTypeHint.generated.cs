using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ModelingComponents;

[UEnum]
public enum ECreateObjectTypeHint : byte
{
    Undefined=0,
    StaticMesh=1,
    Volume=2,
    DynamicMeshActor=3,
}