using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum EViewTargetBlendFunction : byte
{
    VTBlend_Linear=0,
    VTBlend_Cubic=1,
    VTBlend_EaseIn=2,
    VTBlend_EaseOut=3,
    VTBlend_EaseInOut=4,
    VTBlend_PreBlended=5,
}