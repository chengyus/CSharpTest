using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Slate;

[UEnum]
public enum EScrollWhenFocusChanges : byte
{
    NoScroll=0,
    InstantScroll=1,
    AnimatedScroll=2,
}