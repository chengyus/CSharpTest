using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.EnhancedInput;

[UEnum]
public enum ETriggerEvent : byte
{
    Triggered=1,
    Started=2,
    Ongoing=3,
    Canceled=4,
    Completed=5,
}