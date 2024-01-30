using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.PhysicsCore;

[UStruct(IsBlittable = true)]
public partial struct PhysicalMaterialStrength
{
    // FloatProperty /Script/PhysicsCore.PhysicalMaterialStrength:TensileStrength
    public float TensileStrength;
    
    // FloatProperty /Script/PhysicsCore.PhysicalMaterialStrength:CompressionStrength
    public float CompressionStrength;
    
    // FloatProperty /Script/PhysicsCore.PhysicalMaterialStrength:ShearStrength
    public float ShearStrength;
    
}