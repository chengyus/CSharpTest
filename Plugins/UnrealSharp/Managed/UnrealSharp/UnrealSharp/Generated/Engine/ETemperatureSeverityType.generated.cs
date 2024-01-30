using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum ETemperatureSeverityType : byte
{
    Unknown=0,
    Good=1,
    Bad=2,
    Serious=3,
    Critical=4,
    NumSeverities=5,
}