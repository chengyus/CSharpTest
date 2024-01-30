using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.SlateCore;

[UEnum]
public enum ESlateBrushDrawType : byte
{
    NoDrawType=0,
    Box=1,
    Border=2,
    Image=3,
    RoundedBox=4,
}