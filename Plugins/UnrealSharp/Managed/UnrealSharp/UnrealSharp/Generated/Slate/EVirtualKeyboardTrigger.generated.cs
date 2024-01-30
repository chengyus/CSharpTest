using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Slate;

[UEnum]
public enum EVirtualKeyboardTrigger : byte
{
    OnFocusByPointer=0,
    OnAllFocusEvents=1,
}