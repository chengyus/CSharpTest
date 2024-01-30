using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum EMaterialFloatPrecisionMode : byte
{
    MFPM_Default=0,
    MFPM_Full_MaterialExpressionOnly=1,
    MFPM_Full=2,
    MFPM_Half=3,
}