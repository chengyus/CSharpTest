using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.WaveTable;

[UEnum]
public enum EWaveTableBitDepth : byte
{
    PCM_16=0,
    IEEE_Float=1,
}