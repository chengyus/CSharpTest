using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum EProxyNormalComputationMethod : byte
{
    AngleWeighted=0,
    AreaWeighted=1,
    EqualWeighted=2,
}