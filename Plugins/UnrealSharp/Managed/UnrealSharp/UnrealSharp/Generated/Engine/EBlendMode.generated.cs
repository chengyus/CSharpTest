using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum EBlendMode : byte
{
    BLEND_Opaque=0,
    BLEND_Masked=1,
    BLEND_Translucent=2,
    BLEND_Additive=3,
    BLEND_Modulate=4,
    BLEND_AlphaComposite=5,
    BLEND_AlphaHoldout=6,
    BLEND_TranslucentColoredTransmittance=7,
}