using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.GeometryCollectionNodes;

[UEnum]
public enum EMeshBooleanOperationEnum : byte
{
    Dataflow_MeshBoolean_Union=0,
    Dataflow_MeshBoolean_Intersect=1,
    Dataflow_MeshBoolean_Difference=2,
}