using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.WaveTable;

[UEnum]
public enum EWaveTableResolution : byte
{
    Res_8=1,
    Res_16=2,
    Res_32=3,
    Res_64=4,
    Res_128=5,
    Res_256=6,
    Res_512=7,
    Res_1024=8,
    Res_2048=9,
    Res_4096=10,
    Maximum=12,
}