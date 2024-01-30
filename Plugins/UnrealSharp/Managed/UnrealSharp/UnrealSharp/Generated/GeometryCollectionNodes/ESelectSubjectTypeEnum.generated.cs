using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.GeometryCollectionNodes;

[UEnum]
public enum ESelectSubjectTypeEnum : byte
{
    Dataflow_SelectSubjectType_Vertices=0,
    Dataflow_SelectSubjectType_BoundingBox=1,
    Dataflow_SelectSubjectType_Centroid=2,
}