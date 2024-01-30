using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum ESoundWaveFFTSize : byte
{
    VerySmall_64=0,
    Small_256=1,
    Medium_512=2,
    Large_1024=3,
    VeryLarge_2048=4,
}