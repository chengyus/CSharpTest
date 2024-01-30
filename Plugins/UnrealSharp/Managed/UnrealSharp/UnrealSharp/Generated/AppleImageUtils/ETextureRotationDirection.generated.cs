using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AppleImageUtils;

[UEnum]
public enum ETextureRotationDirection : byte
{
    None=0,
    Left=1,
    Right=2,
    Down=3,
    LeftMirrored=4,
    RightMirrored=5,
    DownMirrored=6,
    UpMirrored=7,
}