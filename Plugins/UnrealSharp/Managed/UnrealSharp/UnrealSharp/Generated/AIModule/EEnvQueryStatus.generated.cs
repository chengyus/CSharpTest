using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AIModule;

[UEnum]
public enum EEnvQueryStatus : byte
{
    Processing=0,
    Success=1,
    Failed=2,
    Aborted=3,
    OwnerLost=4,
    MissingParam=5,
}