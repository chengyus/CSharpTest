using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.SlateCore;

[UEnum]
public enum EButtonPressMethod : byte
{
    DownAndUp=0,
    ButtonPress=1,
    ButtonRelease=2,
}