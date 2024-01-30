using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ChaosNiagara;

[UEnum]
public enum ELocationZToSpawnEnum : byte
{
    ChaosNiagara_LocationZToSpawn_None=0,
    ChaosNiagara_LocationZToSpawn_Min=1,
    ChaosNiagara_LocationZToSpawn_Max=2,
    ChaosNiagara_LocationZToSpawn_MinMax=3,
}