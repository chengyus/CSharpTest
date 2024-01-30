using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.InterchangePipelines;

[UEnum]
public enum EInterchangeMaterialXShaders : byte
{
    StandardSurface=0,
    StandardSurfaceTransmission=1,
    SurfaceUnlit=2,
    UsdPreviewSurface=3,
    MaxShaderCount=4,
}