using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.GeometryCollectionNodes;

[UEnum]
public enum EProximityMethodEnum : byte
{
    Dataflow_ProximityMethod_Precise=0,
    Dataflow_ProximityMethod_ConvexHull=1,
}