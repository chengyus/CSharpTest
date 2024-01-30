using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.OnlineSubsystem;

[UEnum]
public enum EMPMatchOutcome : byte
{
    None=0,
    Quit=1,
    Won=2,
    Lost=3,
    Tied=4,
    TimeExpired=5,
    First=6,
    Second=7,
    Third=8,
    Fourth=9,
}