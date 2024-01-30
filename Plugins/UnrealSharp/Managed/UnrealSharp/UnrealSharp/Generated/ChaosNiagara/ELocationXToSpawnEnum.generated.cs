using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ChaosNiagara;

[UEnum]
public enum ELocationXToSpawnEnum : byte
{
    ChaosNiagara_LocationXToSpawn_None=0,
    ChaosNiagara_LocationXToSpawn_Min=1,
    ChaosNiagara_LocationXToSpawn_Max=2,
    ChaosNiagara_LocationXToSpawn_MinMax=3,
}