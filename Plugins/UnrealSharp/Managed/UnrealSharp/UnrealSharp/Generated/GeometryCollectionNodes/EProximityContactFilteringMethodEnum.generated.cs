using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.GeometryCollectionNodes;

[UEnum]
public enum EProximityContactFilteringMethodEnum : byte
{
    Dataflow_ProximityContactFilteringMethod_ProjectedBoundsOverlap=0,
    Dataflow_ProximityContactFilteringMethod_ConvexHullSharp=1,
    Dataflow_ProximityContactFilteringMethod_ConvexHullArea=2,
}