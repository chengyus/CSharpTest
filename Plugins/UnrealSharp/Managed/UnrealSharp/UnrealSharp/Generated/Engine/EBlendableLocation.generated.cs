using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum EBlendableLocation : byte
{
    BL_AfterTonemapping=0,
    BL_BeforeTonemapping=1,
    BL_BeforeTranslucency=2,
    BL_ReplacingTonemapper=3,
    BL_SSRInput=4,
}