using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum EQuarztQuantizationReference : byte
{
    BarRelative=0,
    TransportRelative=1,
    CurrentTimeRelative=2,
}