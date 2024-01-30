using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.GeometryCollectionEngine;

[UStruct(IsBlittable = true)]
public partial struct ChaosRemovalEventData
{
    // StructProperty /Script/GeometryCollectionEngine.ChaosRemovalEventData:Location
    public System.DoubleNumerics.Vector3 Location;
    
    // FloatProperty /Script/GeometryCollectionEngine.ChaosRemovalEventData:Mass
    public float Mass;
    
    // IntProperty /Script/GeometryCollectionEngine.ChaosRemovalEventData:ParticleIndex
    public int ParticleIndex;
    
}