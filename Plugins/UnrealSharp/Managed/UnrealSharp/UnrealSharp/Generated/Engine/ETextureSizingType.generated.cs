using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum ETextureSizingType : byte
{
    TextureSizingType_UseSingleTextureSize=0,
    TextureSizingType_UseAutomaticBiasedSizes=1,
    TextureSizingType_UseManualOverrideTextureSize=2,
    TextureSizingType_UseSimplygonAutomaticSizing=3,
    TextureSizingType_AutomaticFromTexelDensity=4,
    TextureSizingType_AutomaticFromMeshScreenSize=5,
    TextureSizingType_AutomaticFromMeshDrawDistance=6,
}