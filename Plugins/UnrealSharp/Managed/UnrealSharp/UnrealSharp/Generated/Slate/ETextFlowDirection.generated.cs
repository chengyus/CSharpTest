using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Slate;

[UEnum]
public enum ETextFlowDirection : byte
{
    Auto=0,
    LeftToRight=1,
    RightToLeft=2,
    Culture=3,
}