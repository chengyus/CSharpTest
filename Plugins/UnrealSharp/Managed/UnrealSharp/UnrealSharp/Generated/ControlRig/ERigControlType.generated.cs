using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UEnum]
public enum ERigControlType : byte
{
    Bool=0,
    Float=1,
    Integer=2,
    Vector2D=3,
    Position=4,
    Scale=5,
    Rotator=6,
    EulerTransform=9,
}