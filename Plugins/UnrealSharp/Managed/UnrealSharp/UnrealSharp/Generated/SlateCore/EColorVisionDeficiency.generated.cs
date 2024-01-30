using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.SlateCore;

[UEnum]
public enum EColorVisionDeficiency : byte
{
    NormalVision=0,
    Deuteranope=1,
    Protanope=2,
    Tritanope=3,
}