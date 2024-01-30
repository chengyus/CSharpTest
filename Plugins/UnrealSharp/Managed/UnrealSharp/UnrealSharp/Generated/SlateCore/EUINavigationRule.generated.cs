using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.SlateCore;

[UEnum]
public enum EUINavigationRule : byte
{
    Escape=0,
    Explicit=1,
    Wrap=2,
    Stop=3,
    Custom=4,
    CustomBoundary=5,
    Invalid=6,
}