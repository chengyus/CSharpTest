using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.GeometryCollectionEngine;

[UStruct(IsBlittable = true)]
public partial struct ChaosCollisionEventData
{
    // StructProperty /Script/GeometryCollectionEngine.ChaosCollisionEventData:Location
    public System.DoubleNumerics.Vector3 Location;
    
    // StructProperty /Script/GeometryCollectionEngine.ChaosCollisionEventData:Normal
    public System.DoubleNumerics.Vector3 Normal;
    
    // StructProperty /Script/GeometryCollectionEngine.ChaosCollisionEventData:Velocity1
    public System.DoubleNumerics.Vector3 Velocity1;
    
    // StructProperty /Script/GeometryCollectionEngine.ChaosCollisionEventData:Velocity2
    public System.DoubleNumerics.Vector3 Velocity2;
    
    // FloatProperty /Script/GeometryCollectionEngine.ChaosCollisionEventData:Mass1
    public float Mass1;
    
    // FloatProperty /Script/GeometryCollectionEngine.ChaosCollisionEventData:Mass2
    public float Mass2;
    
    // StructProperty /Script/GeometryCollectionEngine.ChaosCollisionEventData:Impulse
    public System.DoubleNumerics.Vector3 Impulse;
    
}