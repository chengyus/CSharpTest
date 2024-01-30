using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.PhysicsCore;

[UEnum]
public enum EConstraintPlasticityType : byte
{
    CCPT_Free=0,
    CCPT_Shrink=1,
    CCPT_Grow=2,
}