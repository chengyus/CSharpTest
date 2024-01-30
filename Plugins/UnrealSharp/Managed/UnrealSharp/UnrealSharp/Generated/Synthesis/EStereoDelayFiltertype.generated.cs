using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Synthesis;

[UEnum]
public enum EStereoDelayFiltertype : byte
{
    Lowpass=0,
    Highpass=1,
    Bandpass=2,
    Notch=3,
}