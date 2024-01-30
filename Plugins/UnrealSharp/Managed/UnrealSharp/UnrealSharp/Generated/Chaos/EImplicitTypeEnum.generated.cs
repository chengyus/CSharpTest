using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Chaos;

[UEnum]
public enum EImplicitTypeEnum : byte
{
    Chaos_Implicit_Box=0,
    Chaos_Implicit_Sphere=1,
    Chaos_Implicit_Capsule=2,
    Chaos_Implicit_LevelSet=3,
    Chaos_Implicit_None=4,
    Chaos_Implicit_Convex=5,
}