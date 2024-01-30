using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Paper2D;

[UEnum]
public enum ESpriteCollisionMode : byte
{
    None=0,
    Use3DPhysics=2,
}