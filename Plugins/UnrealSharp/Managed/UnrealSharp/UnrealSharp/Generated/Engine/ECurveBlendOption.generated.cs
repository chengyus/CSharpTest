using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum ECurveBlendOption : byte
{
    Override=0,
    DoNotOverride=1,
    NormalizeByWeight=2,
    BlendByWeight=3,
    UseBasePose=4,
    UseMaxValue=5,
    UseMinValue=6,
}