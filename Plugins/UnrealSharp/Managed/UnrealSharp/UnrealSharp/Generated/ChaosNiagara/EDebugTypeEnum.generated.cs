using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ChaosNiagara;

[UEnum]
public enum EDebugTypeEnum : byte
{
    ChaosNiagara_DebugType_NoDebug=0,
    ChaosNiagara_DebugType_ColorBySolver=1,
    ChaosNiagara_DebugType_ColorByParticleIndex=2,
}