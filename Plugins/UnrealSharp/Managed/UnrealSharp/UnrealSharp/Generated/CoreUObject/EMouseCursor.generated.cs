using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.CoreUObject;

[UEnum]
public enum EMouseCursor : byte
{
    None=0,
    Default=1,
    TextEditBeam=2,
    ResizeLeftRight=3,
    ResizeUpDown=4,
    ResizeSouthEast=5,
    ResizeSouthWest=6,
    CardinalCross=7,
    Crosshairs=8,
    Hand=9,
    GrabHand=10,
    GrabHandClosed=11,
    SlashedCircle=12,
    EyeDropper=13,
}