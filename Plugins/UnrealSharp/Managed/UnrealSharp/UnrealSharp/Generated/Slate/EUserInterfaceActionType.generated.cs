using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Slate;

[UEnum]
public enum EUserInterfaceActionType : byte
{
    None=0,
    Button=1,
    ToggleButton=2,
    RadioButton=3,
    Check=4,
    CollapsedButton=5,
}