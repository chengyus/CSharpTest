using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Chaos;

[UEnum]
public enum EFieldScalarType : byte
{
    Scalar_ExternalClusterStrain=0,
    Scalar_Kill=1,
    Scalar_DisableThreshold=2,
    Scalar_SleepingThreshold=3,
    Scalar_InternalClusterStrain=4,
}