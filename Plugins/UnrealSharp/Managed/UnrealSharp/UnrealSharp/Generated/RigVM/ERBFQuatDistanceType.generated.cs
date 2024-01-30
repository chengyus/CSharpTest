using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UEnum]
public enum ERBFQuatDistanceType : byte
{
    Euclidean=0,
    ArcLength=1,
    SwingAngle=2,
    TwistAngle=3,
}