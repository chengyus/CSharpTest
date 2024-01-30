using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.IKRig;

[UEnum]
public enum ERetargetRotationMode : byte
{
    Interpolated=0,
    OneToOne=1,
    OneToOneReversed=2,
    None=3,
}