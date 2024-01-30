using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum EMaterialSamplerType : byte
{
    SAMPLERTYPE_Color=0,
    SAMPLERTYPE_Grayscale=1,
    SAMPLERTYPE_Alpha=2,
    SAMPLERTYPE_Normal=3,
    SAMPLERTYPE_Masks=4,
    SAMPLERTYPE_DistanceFieldFont=5,
    SAMPLERTYPE_LinearColor=6,
    SAMPLERTYPE_LinearGrayscale=7,
    SAMPLERTYPE_Data=8,
    SAMPLERTYPE_External=9,
    SAMPLERTYPE_VirtualColor=10,
    SAMPLERTYPE_VirtualGrayscale=11,
    SAMPLERTYPE_VirtualAlpha=12,
    SAMPLERTYPE_VirtualNormal=13,
    SAMPLERTYPE_VirtualMasks=14,
    SAMPLERTYPE_VirtualLinearColor=15,
    SAMPLERTYPE_VirtualLinearGrayscale=16,
}