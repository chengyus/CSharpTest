using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Synthesis;

[UEnum]
public enum ETapLineMode : byte
{
    SendToChannel=0,
    Panning=1,
    Disabled=2,
}