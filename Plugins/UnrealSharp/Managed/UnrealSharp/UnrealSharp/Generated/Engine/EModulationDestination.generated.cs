using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum EModulationDestination : byte
{
    Volume=0,
    Pitch=1,
    Lowpass=2,
    Highpass=3,
}