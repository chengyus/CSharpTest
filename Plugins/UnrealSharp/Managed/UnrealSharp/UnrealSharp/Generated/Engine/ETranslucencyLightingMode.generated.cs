using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum ETranslucencyLightingMode : byte
{
    TLM_VolumetricNonDirectional=0,
    TLM_VolumetricDirectional=1,
    TLM_VolumetricPerVertexNonDirectional=2,
    TLM_VolumetricPerVertexDirectional=3,
    TLM_Surface=4,
    TLM_SurfacePerPixelLighting=5,
}