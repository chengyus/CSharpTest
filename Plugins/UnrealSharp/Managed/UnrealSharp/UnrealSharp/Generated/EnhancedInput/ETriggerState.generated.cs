using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.EnhancedInput;

[UEnum]
public enum ETriggerState : byte
{
    None=0,
    Ongoing=1,
    Triggered=2,
}