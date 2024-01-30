using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.GeometryCollectionNodes;

[UEnum]
public enum EConnectionContactAreaMethodEnum : byte
{
    Dataflow_ConnectionContactAreaMethod_None=0,
    Dataflow_ProximityContactFilteringMethod_ConvexHullArea=1,
}