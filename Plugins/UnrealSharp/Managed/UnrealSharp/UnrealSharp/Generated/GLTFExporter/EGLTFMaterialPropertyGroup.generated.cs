using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.GLTFExporter;

[UEnum]
public enum EGLTFMaterialPropertyGroup : byte
{
    None=0,
    BaseColorOpacity=1,
    MetallicRoughness=2,
    EmissiveColor=3,
    Normal=4,
    AmbientOcclusion=5,
    ClearCoatRoughness=6,
    ClearCoatBottomNormal=7,
}