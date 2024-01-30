using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.SlateCore;

[UEnum]
public enum EMenuPlacement : byte
{
    MenuPlacement_BelowAnchor=0,
    MenuPlacement_CenteredBelowAnchor=1,
    MenuPlacement_BelowRightAnchor=2,
    MenuPlacement_ComboBox=3,
    MenuPlacement_ComboBoxRight=4,
    MenuPlacement_MenuRight=5,
    MenuPlacement_AboveAnchor=6,
    MenuPlacement_CenteredAboveAnchor=7,
    MenuPlacement_AboveRightAnchor=8,
    MenuPlacement_MenuLeft=9,
    MenuPlacement_Center=10,
    MenuPlacement_RightLeftCenter=11,
    MenuPlacement_MatchBottomLeft=12,
}