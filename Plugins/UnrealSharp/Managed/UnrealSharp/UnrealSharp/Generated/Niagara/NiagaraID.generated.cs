using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Niagara;

[UStruct(IsBlittable = true)]
public partial struct NiagaraID
{
    // IntProperty /Script/Niagara.NiagaraID:Index
    public int Index;
    
    // IntProperty /Script/Niagara.NiagaraID:AcquireTag
    public int AcquireTag;
    
}