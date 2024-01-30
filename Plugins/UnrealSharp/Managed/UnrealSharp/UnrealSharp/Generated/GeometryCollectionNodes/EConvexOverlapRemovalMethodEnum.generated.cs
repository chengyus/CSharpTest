using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.GeometryCollectionNodes;

[UEnum]
public enum EConvexOverlapRemovalMethodEnum : byte
{
    Dataflow_EConvexOverlapRemovalMethod_None=0,
    Dataflow_EConvexOverlapRemovalMethod_All=1,
    Dataflow_EConvexOverlapRemovalMethod_OnlyClusters=2,
    Dataflow_EConvexOverlapRemovalMethod_OnlyClustersVsClusters=3,
}