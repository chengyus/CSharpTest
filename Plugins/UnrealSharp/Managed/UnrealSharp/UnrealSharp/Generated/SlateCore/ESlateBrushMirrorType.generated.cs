using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.SlateCore;

[UEnum]
public enum ESlateBrushMirrorType : byte
{
    NoMirror=0,
    Horizontal=1,
    Vertical=2,
    Both=3,
}