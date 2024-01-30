using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.GameplayCameras;

[UEnum]
public enum EOscillatorWaveform : byte
{
    SineWave=0,
    PerlinNoise=1,
}