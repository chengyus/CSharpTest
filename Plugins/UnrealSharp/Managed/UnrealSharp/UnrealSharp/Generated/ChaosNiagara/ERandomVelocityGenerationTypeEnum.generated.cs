using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ChaosNiagara;

[UEnum]
public enum ERandomVelocityGenerationTypeEnum : byte
{
    ChaosNiagara_RandomVelocityGenerationType_RandomDistribution=0,
    ChaosNiagara_RandomVelocityGenerationType_RandomDistributionWithStreamers=1,
    ChaosNiagara_RandomVelocityGenerationType_CollisionNormalBased=2,
}