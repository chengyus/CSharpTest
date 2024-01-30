using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum EAudioFaderCurve : byte
{
    Linear=0,
    Logarithmic=1,
    SCurve=2,
    Sin=3,
}