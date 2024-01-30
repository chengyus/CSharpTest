using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.PhysicsCore;

[UEnum]
public enum EAngularConstraintMotion : byte
{
    ACM_Free=0,
    ACM_Limited=1,
    ACM_Locked=2,
}