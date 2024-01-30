using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Niagara;

[UEnum]
public enum ENiagaraSimCacheAttributeCaptureMode : byte
{
    All=0,
    RenderingOnly=1,
    ExplicitAttributes=2,
}