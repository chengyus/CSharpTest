using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.PhysicsCore;

[UEnum]
public enum ESleepFamily : byte
{
    Normal=0,
    Sensitive=1,
    Custom=2,
}