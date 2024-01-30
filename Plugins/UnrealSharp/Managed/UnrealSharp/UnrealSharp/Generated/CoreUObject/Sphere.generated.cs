using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.CoreUObject;

[UStruct(IsBlittable = true)]
public partial struct Sphere
{
    // StructProperty /Script/CoreUObject.Sphere:Center
    public System.DoubleNumerics.Vector3 Center;
    
    // DoubleProperty /Script/CoreUObject.Sphere:W
    public double W;
    
}