using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum EMovementMode : byte
{
    MOVE_None=0,
    MOVE_Walking=1,
    MOVE_NavWalking=2,
    MOVE_Falling=3,
    MOVE_Swimming=4,
    MOVE_Flying=5,
    MOVE_Custom=6,
}