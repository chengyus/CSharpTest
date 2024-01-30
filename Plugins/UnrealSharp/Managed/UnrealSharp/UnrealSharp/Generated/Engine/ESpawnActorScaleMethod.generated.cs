using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum ESpawnActorScaleMethod : byte
{
    OverrideRootScale=0,
    MultiplyWithRoot=1,
}