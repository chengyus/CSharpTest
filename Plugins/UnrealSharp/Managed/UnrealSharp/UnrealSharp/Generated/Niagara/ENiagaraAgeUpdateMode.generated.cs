using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Niagara;

[UEnum]
public enum ENiagaraAgeUpdateMode : byte
{
    TickDeltaTime=0,
    DesiredAge=1,
    DesiredAgeNoSeek=2,
}