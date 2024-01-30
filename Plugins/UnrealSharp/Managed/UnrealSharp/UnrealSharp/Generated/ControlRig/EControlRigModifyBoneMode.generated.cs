using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UEnum]
public enum EControlRigModifyBoneMode : byte
{
    OverrideLocal=0,
    OverrideGlobal=1,
    AdditiveLocal=2,
    AdditiveGlobal=3,
}