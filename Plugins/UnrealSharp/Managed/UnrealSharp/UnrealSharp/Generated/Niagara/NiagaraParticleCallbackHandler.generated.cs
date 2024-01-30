using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Niagara;

public partial interface INiagaraParticleCallbackHandler
{
    public void ReceiveParticleData(System.Collections.Generic.IList<UnrealSharp.Niagara.BasicParticleData> data, UnrealSharp.Niagara.NiagaraSystem niagaraSystem, System.DoubleNumerics.Vector3 simulationPositionOffset);
}