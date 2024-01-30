using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UEnum]
public enum ERigElementType : byte
{
    None=0,
    Bone=1,
    Null=2,
    Control=4,
    Curve=5,
    Reference=7,
    All=9,
}