using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.GeometryCollectionEngine;

[UStruct(IsBlittable = true)]
public partial struct ChaosTrailingEventData
{
    // StructProperty /Script/GeometryCollectionEngine.ChaosTrailingEventData:Location
    public System.DoubleNumerics.Vector3 Location;
    
    // StructProperty /Script/GeometryCollectionEngine.ChaosTrailingEventData:Velocity
    public System.DoubleNumerics.Vector3 Velocity;
    
    // StructProperty /Script/GeometryCollectionEngine.ChaosTrailingEventData:AngularVelocity
    public System.DoubleNumerics.Vector3 AngularVelocity;
    
    // FloatProperty /Script/GeometryCollectionEngine.ChaosTrailingEventData:Mass
    public float Mass;
    
    // IntProperty /Script/GeometryCollectionEngine.ChaosTrailingEventData:ParticleIndex
    public int ParticleIndex;
    
}