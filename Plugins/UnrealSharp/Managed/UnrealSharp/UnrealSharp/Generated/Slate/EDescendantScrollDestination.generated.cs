using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Slate;

[UEnum]
public enum EDescendantScrollDestination : byte
{
    IntoView=0,
    TopOrLeft=1,
    Center=2,
    BottomOrRight=3,
}