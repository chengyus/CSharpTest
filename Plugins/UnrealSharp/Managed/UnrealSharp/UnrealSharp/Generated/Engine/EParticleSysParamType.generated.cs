using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum EParticleSysParamType : byte
{
    PSPT_None=0,
    PSPT_Scalar=1,
    PSPT_ScalarRand=2,
    PSPT_Vector=3,
    PSPT_VectorRand=4,
    PSPT_Color=5,
    PSPT_Actor=6,
    PSPT_Material=7,
    PSPT_VectorUnitRand=8,
}