using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.CoreUObject;

[UEnum]
public enum EInterpCurveMode : byte
{
    CIM_Linear=0,
    CIM_CurveAuto=1,
    CIM_Constant=2,
    CIM_CurveUser=3,
    CIM_CurveBreak=4,
    CIM_CurveAutoClamped=5,
}