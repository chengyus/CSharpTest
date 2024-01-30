using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.UMG;

[UEnum]
public enum EDynamicBoxType : byte
{
    Horizontal=0,
    Vertical=1,
    Wrap=2,
    VerticalWrap=3,
    Radial=4,
    Overlay=5,
}