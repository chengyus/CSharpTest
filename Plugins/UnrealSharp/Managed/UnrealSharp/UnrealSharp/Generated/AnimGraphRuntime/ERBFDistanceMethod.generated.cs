using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AnimGraphRuntime;

[UEnum]
public enum ERBFDistanceMethod : byte
{
    Euclidean=0,
    Quaternion=1,
    SwingAngle=2,
    TwistAngle=3,
    DefaultMethod=4,
}