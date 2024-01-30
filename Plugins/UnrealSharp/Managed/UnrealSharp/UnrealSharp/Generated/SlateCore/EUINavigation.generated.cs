using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.SlateCore;

[UEnum]
public enum EUINavigation : byte
{
    Left=0,
    Right=1,
    Up=2,
    Down=3,
    Next=4,
    Previous=5,
    Invalid=7,
}