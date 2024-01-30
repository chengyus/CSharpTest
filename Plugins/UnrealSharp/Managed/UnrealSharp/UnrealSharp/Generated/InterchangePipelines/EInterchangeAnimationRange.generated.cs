using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.InterchangePipelines;

[UEnum]
public enum EInterchangeAnimationRange : byte
{
    Timeline=0,
    Animated=1,
    SetRange=2,
}