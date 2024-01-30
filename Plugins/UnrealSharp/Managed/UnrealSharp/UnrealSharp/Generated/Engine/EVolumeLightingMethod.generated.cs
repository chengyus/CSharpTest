using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum EVolumeLightingMethod : byte
{
    VLM_VolumetricLightmap=0,
    VLM_SparseVolumeLightingSamples=1,
}