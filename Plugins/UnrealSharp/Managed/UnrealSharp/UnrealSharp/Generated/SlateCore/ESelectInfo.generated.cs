using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.SlateCore;

[UEnum]
public enum ESelectInfo : byte
{
    OnKeyPress=0,
    OnNavigation=1,
    OnMouseClick=2,
    Direct=3,
}