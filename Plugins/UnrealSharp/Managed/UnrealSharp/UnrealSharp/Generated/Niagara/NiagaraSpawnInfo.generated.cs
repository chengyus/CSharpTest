using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Niagara;

[UStruct(IsBlittable = true)]
public partial struct NiagaraSpawnInfo
{
    // IntProperty /Script/Niagara.NiagaraSpawnInfo:Count
    public int Count;
    
    // FloatProperty /Script/Niagara.NiagaraSpawnInfo:InterpStartDt
    public float InterpStartDt;
    
    // FloatProperty /Script/Niagara.NiagaraSpawnInfo:IntervalDt
    public float IntervalDt;
    
    // IntProperty /Script/Niagara.NiagaraSpawnInfo:SpawnGroup
    public int SpawnGroup;
    
}