using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum EMaterialUsage : byte
{
    MATUSAGE_SkeletalMesh=0,
    MATUSAGE_ParticleSprites=1,
    MATUSAGE_BeamTrails=2,
    MATUSAGE_MeshParticles=3,
    MATUSAGE_StaticLighting=4,
    MATUSAGE_MorphTargets=5,
    MATUSAGE_SplineMesh=6,
    MATUSAGE_InstancedStaticMeshes=7,
    MATUSAGE_GeometryCollections=8,
    MATUSAGE_Clothing=9,
    MATUSAGE_NiagaraSprites=10,
    MATUSAGE_NiagaraRibbons=11,
    MATUSAGE_NiagaraMeshParticles=12,
    MATUSAGE_GeometryCache=13,
    MATUSAGE_Water=14,
    MATUSAGE_HairStrands=15,
    MATUSAGE_LidarPointCloud=16,
    MATUSAGE_VirtualHeightfieldMesh=17,
    MATUSAGE_Nanite=18,
    MATUSAGE_VolumetricCloud=19,
    MATUSAGE_HeterogeneousVolumes=20,
}