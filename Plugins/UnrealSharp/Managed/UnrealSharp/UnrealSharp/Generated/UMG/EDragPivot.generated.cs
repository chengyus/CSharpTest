using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.UMG;

[UEnum]
public enum EDragPivot : byte
{
    MouseDown=0,
    TopLeft=1,
    TopCenter=2,
    TopRight=3,
    CenterLeft=4,
    CenterCenter=5,
    CenterRight=6,
    BottomLeft=7,
    BottomCenter=8,
    BottomRight=9,
}