using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Chaos;

[UEnum]
public enum EFieldFalloffType : byte
{
    Field_FallOff_None=0,
    Field_Falloff_Linear=1,
    Field_Falloff_Inverse=2,
    Field_Falloff_Squared=3,
    Field_Falloff_Logarithmic=4,
}