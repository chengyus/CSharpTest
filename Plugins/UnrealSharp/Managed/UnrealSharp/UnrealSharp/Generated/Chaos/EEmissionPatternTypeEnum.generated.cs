using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Chaos;

[UEnum]
public enum EEmissionPatternTypeEnum : byte
{
    Chaos_Emission_Pattern_First_Frame=0,
    Chaos_Emission_Pattern_On_Demand=1,
}