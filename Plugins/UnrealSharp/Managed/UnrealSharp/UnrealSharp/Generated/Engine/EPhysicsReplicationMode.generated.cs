using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum EPhysicsReplicationMode : byte
{
    Default=0,
    PredictiveInterpolation=1,
    Resimulation=2,
}