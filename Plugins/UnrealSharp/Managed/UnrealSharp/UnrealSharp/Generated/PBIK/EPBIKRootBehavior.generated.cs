using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.PBIK;

[UEnum]
public enum EPBIKRootBehavior : byte
{
    PrePull=0,
    PinToInput=1,
    Free=2,
}