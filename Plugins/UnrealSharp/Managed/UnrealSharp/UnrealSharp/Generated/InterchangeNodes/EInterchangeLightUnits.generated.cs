using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.InterchangeNodes;

[UEnum]
public enum EInterchangeLightUnits : byte
{
    Unitless=0,
    Candelas=1,
    Lumens=2,
    EV=3,
}