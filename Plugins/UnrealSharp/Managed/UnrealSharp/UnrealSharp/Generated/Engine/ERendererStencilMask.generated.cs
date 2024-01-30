using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum ERendererStencilMask : byte
{
    ERSM_Default=0,
    ERSM_255=1,
    ERSM_1=2,
    ERSM_2=3,
    ERSM_4=4,
    ERSM_8=5,
    ERSM_16=6,
    ERSM_32=7,
    ERSM_64=8,
    ERSM_128=9,
}