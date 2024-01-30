using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.PhysicsCore;

[UEnum]
public enum EFrictionCombineMode : byte
{
    Average=0,
    Min=1,
    Multiply=2,
    Max=3,
}