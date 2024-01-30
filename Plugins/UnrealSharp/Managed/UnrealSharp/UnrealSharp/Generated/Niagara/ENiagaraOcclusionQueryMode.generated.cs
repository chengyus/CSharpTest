using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Niagara;

[UEnum]
public enum ENiagaraOcclusionQueryMode : byte
{
    Default=0,
    AlwaysEnabled=1,
    AlwaysDisabled=2,
}