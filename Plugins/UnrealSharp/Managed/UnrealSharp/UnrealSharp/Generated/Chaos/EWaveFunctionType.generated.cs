using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Chaos;

[UEnum]
public enum EWaveFunctionType : byte
{
    Field_Wave_Cosine=0,
    Field_Wave_Gaussian=1,
    Field_Wave_Falloff=2,
    Field_Wave_Decay=3,
}