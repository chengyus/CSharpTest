using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.GameplayCameras;

[UEnum]
public enum EInitialWaveOscillatorOffsetType : byte
{
    Random=0,
    Zero=1,
}