using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum ENetRole : byte
{
    ROLE_None=0,
    ROLE_SimulatedProxy=1,
    ROLE_AutonomousProxy=2,
    ROLE_Authority=3,
}