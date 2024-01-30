using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.PhysicsCore;

[UEnum]
public enum ELinearConstraintMotion : byte
{
    LCM_Free=0,
    LCM_Limited=1,
    LCM_Locked=2,
}