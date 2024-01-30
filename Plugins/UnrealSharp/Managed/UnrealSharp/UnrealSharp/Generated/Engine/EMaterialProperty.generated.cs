using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum EMaterialProperty : byte
{
    MP_EmissiveColor=0,
    MP_Opacity=1,
    MP_OpacityMask=2,
    MP_BaseColor=5,
    MP_Metallic=6,
    MP_Specular=7,
    MP_Roughness=8,
    MP_Anisotropy=9,
    MP_Normal=10,
    MP_Tangent=11,
    MP_SubsurfaceColor=15,
    MP_AmbientOcclusion=18,
    MP_Refraction=19,
}