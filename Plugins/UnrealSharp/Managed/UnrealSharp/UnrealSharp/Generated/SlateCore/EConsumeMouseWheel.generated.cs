using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.SlateCore;

[UEnum]
public enum EConsumeMouseWheel : byte
{
    WhenScrollingPossible=0,
    Always=1,
    Never=2,
}