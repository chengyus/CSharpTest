using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UEnum]
public enum ERigEvent : byte
{
    None=0,
    RequestAutoKey=1,
    OpenUndoBracket=2,
    CloseUndoBracket=3,
}