using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum EMaterialDecalResponse : byte
{
    MDR_None=0,
    MDR_ColorNormalRoughness=1,
    MDR_Color=2,
    MDR_ColorNormal=3,
    MDR_ColorRoughness=4,
    MDR_Normal=5,
    MDR_NormalRoughness=6,
    MDR_Roughness=7,
}