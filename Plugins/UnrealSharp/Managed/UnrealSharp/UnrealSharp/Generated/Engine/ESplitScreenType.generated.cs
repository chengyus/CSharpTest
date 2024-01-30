using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum ESplitScreenType : byte
{
    None=0,
    TwoPlayer_Horizontal=1,
    TwoPlayer_Vertical=2,
    ThreePlayer_FavorTop=3,
    ThreePlayer_FavorBottom=4,
    ThreePlayer_Vertical=5,
    ThreePlayer_Horizontal=6,
    FourPlayer_Grid=7,
    FourPlayer_Vertical=8,
    FourPlayer_Horizontal=9,
    SplitTypeCount=10,
}