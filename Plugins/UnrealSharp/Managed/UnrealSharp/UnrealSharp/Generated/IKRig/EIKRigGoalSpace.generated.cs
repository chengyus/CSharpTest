using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.IKRig;

[UEnum]
public enum EIKRigGoalSpace : byte
{
    Component=0,
    Additive=1,
    World=2,
}