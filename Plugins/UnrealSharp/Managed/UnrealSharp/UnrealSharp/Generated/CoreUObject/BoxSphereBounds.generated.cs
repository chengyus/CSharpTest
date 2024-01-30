using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.CoreUObject;

[UStruct(IsBlittable = true)]
public partial struct BoxSphereBounds
{
    // StructProperty /Script/CoreUObject.BoxSphereBounds:Origin
    public System.DoubleNumerics.Vector3 Origin;
    
    // StructProperty /Script/CoreUObject.BoxSphereBounds:BoxExtent
    public System.DoubleNumerics.Vector3 BoxExtent;
    
    // DoubleProperty /Script/CoreUObject.BoxSphereBounds:SphereRadius
    public double SphereRadius;
    
}