using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum ENavLinkDirection : byte
{
    BothWays=0,
    LeftToRight=1,
    RightToLeft=2,
}