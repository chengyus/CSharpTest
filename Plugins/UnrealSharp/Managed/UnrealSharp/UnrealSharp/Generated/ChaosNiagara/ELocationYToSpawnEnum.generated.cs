using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ChaosNiagara;

[UEnum]
public enum ELocationYToSpawnEnum : byte
{
    ChaosNiagara_LocationYToSpawn_None=0,
    ChaosNiagara_LocationYToSpawn_Min=1,
    ChaosNiagara_LocationYToSpawn_Max=2,
    ChaosNiagara_LocationYToSpawn_MinMax=3,
}