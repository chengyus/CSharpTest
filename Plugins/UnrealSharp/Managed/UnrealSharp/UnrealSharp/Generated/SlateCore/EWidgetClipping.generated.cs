using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.SlateCore;

[UEnum]
public enum EWidgetClipping : byte
{
    Inherit=0,
    ClipToBounds=1,
    ClipToBoundsWithoutIntersecting=2,
    ClipToBoundsAlways=3,
    OnDemand=4,
}