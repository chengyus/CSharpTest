using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.SlateCore;

[UEnum]
public enum EFontHinting : byte
{
    Default=0,
    Auto=1,
    AutoLight=2,
    Monochrome=3,
    None=4,
}