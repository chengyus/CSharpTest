using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.WaveTable;

[UEnum]
public enum EWaveTableCurve : byte
{
    Linear=0,
    Linear_Inv=1,
    Exp=2,
    Exp_Inverse=3,
    Log=4,
    Sin=5,
    Sin_Full=6,
    SCurve=7,
    Shared=8,
    Custom=9,
    File=10,
}