using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Slate;

[UEnum]
public enum ESelectionMode : byte
{
    None=0,
    Single=1,
    SingleToggle=2,
    Multi=3,
}