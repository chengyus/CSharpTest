using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum EPhysicsTransformUpdateMode : byte
{
    SimulationUpatesComponentTransform=0,
    ComponentTransformIsKinematic=1,
}