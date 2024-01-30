using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AnimationCore;

[UEnum]
public enum ETransformConstraintType : byte
{
    Translation=0,
    Rotation=1,
    Scale=2,
    Parent=3,
    LookAt=4,
}