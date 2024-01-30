using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Chaos;

[UEnum]
public enum EFieldPhysicsDefaultFields : byte
{
    Field_RadialIntMask=0,
    Field_RadialFalloff=1,
    Field_UniformVector=2,
    Field_RadialVector=3,
    Field_RadialVectorFalloff=4,
}