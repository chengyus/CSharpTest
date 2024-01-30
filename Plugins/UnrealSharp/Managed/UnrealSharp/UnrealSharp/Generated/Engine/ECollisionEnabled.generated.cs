using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum ECollisionEnabled : byte
{
    NoCollision=0,
    QueryOnly=1,
    PhysicsOnly=2,
    QueryAndPhysics=3,
    ProbeOnly=4,
    QueryAndProbe=5,
}