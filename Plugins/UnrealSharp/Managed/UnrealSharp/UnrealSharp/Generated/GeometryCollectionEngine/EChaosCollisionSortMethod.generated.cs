using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.GeometryCollectionEngine;

[UEnum]
public enum EChaosCollisionSortMethod : byte
{
    SortNone=0,
    SortByHighestMass=1,
    SortByHighestSpeed=2,
    SortByHighestImpulse=3,
    SortByNearestFirst=4,
}