using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.VREditor;

[UEnum]
public enum ETouchSwipeDirection : byte
{
    None=0,
    Left=1,
    Right=2,
    Up=3,
    Down=4,
}