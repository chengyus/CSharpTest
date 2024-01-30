using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum ERuntimeVirtualTextureMaterialType : byte
{
    BaseColor=0,
    BaseColor_Normal_Roughness=2,
    BaseColor_Normal_Specular=3,
    BaseColor_Normal_Specular_YCoCg=4,
    BaseColor_Normal_Specular_Mask_YCoCg=5,
    WorldHeight=6,
}