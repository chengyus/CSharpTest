using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Chaos;

[UEnum]
public enum EInitialVelocityTypeEnum : byte
{
    Chaos_Initial_Velocity_User_Defined=0,
    Chaos_Initial_Velocity_None=1,
}