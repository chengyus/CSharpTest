using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Niagara;

[UEnum]
public enum ENiagaraTickBehavior : byte
{
    UsePrereqs=0,
    UseComponentTickGroup=1,
    ForceTickFirst=2,
    ForceTickLast=3,
}