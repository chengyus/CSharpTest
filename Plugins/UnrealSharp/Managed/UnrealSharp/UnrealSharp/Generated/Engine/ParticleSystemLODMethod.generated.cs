using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum ParticleSystemLODMethod : byte
{
    PARTICLESYSTEMLODMETHOD_Automatic=0,
    PARTICLESYSTEMLODMETHOD_DirectSet=1,
    PARTICLESYSTEMLODMETHOD_ActivateAutomatic=2,
}