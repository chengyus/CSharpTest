using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum EViewModeIndex : byte
{
    VMI_BrushWireframe=0,
    VMI_Wireframe=1,
    VMI_Unlit=2,
    VMI_Lit=3,
    VMI_Lit_DetailLighting=4,
    VMI_LightingOnly=5,
    VMI_LightComplexity=6,
    VMI_ShaderComplexity=7,
    VMI_LightmapDensity=8,
    VMI_LitLightmapDensity=9,
    VMI_ReflectionOverride=10,
    VMI_VisualizeBuffer=11,
    VMI_StationaryLightOverlap=12,
    VMI_CollisionPawn=13,
    VMI_CollisionVisibility=14,
    VMI_LODColoration=15,
    VMI_QuadOverdraw=16,
    VMI_PrimitiveDistanceAccuracy=17,
    VMI_MeshUVDensityAccuracy=18,
    VMI_ShaderComplexityWithQuadOverdraw=19,
    VMI_HLODColoration=20,
    VMI_GroupLODColoration=21,
    VMI_MaterialTextureScaleAccuracy=22,
    VMI_RequiredTextureResolution=23,
    VMI_PathTracing=24,
    VMI_RayTracingDebug=25,
    VMI_VisualizeNanite=26,
    VMI_VirtualTexturePendingMips=27,
    VMI_VisualizeLumen=28,
    VMI_VisualizeVirtualShadowMap=29,
    VMI_VisualizeGPUSkinCache=30,
    VMI_VisualizeSubstrate=31,
    VMI_VisualizeGroom=32,
    VMI_Unknown=34,
}