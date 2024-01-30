using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UEnum]
public enum ERBFVectorDistanceType : byte
{
    Euclidean=0,
    Manhattan=1,
    ArcLength=2,
}