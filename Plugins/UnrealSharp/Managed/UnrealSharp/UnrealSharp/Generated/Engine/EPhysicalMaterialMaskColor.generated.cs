using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum EPhysicalMaterialMaskColor : byte
{
    Red=0,
    Green=1,
    Blue=2,
    Cyan=3,
    Magenta=4,
    Yellow=5,
    White=6,
    Black=7,
}