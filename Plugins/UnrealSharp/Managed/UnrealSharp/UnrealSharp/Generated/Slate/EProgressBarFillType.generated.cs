using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Slate;

[UEnum]
public enum EProgressBarFillType : byte
{
    LeftToRight=0,
    RightToLeft=1,
    FillFromCenter=2,
    FillFromCenterHorizontal=3,
    FillFromCenterVertical=4,
    TopToBottom=5,
    BottomToTop=6,
}