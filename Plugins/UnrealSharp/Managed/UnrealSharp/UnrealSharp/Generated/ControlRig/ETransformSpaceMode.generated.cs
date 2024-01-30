using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UEnum]
public enum ETransformSpaceMode : byte
{
    LocalSpace=0,
    GlobalSpace=1,
    BaseSpace=2,
    BaseJoint=3,
}