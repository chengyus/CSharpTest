using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.SlateCore;

[UEnum]
public enum EWidgetPixelSnapping : byte
{
    Inherit=0,
    Disabled=1,
    SnapToPixel=2,
}