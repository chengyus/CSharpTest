using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Synthesis;

[UEnum]
public enum ESynthLFOType : byte
{
    Sine=0,
    UpSaw=1,
    DownSaw=2,
    Square=3,
    Triangle=4,
    Exponential=5,
    RandomSampleHold=6,
}