using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.GeometryCollectionEngine;

[UEnum]
public enum EChaosRemovalSortMethod : byte
{
    SortNone=0,
    SortByHighestMass=1,
    SortByNearestFirst=2,
}