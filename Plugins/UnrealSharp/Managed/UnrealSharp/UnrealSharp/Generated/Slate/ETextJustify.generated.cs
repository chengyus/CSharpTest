using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Slate;

[UEnum]
public enum ETextJustify : byte
{
    Left=0,
    Center=1,
    Right=2,
    InvariantLeft=3,
    InvariantRight=4,
}