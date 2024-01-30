using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.SlateCore;

[UEnum]
public enum EButtonClickMethod : byte
{
    DownAndUp=0,
    MouseDown=1,
    MouseUp=2,
    PreciseClick=3,
}