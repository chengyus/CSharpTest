using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum ECollisionChannel : byte
{
    ECC_WorldStatic=0,
    ECC_WorldDynamic=1,
    ECC_Pawn=2,
    ECC_Visibility=3,
    ECC_Camera=4,
    ECC_PhysicsBody=5,
    ECC_Vehicle=6,
    ECC_Destructible=7,
}