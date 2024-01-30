using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.CoreUObject;

[UStruct(IsBlittable = true)]
public partial struct Matrix
{
    // StructProperty /Script/CoreUObject.Matrix:XPlane
    public UnrealSharp.CoreUObject.Plane XPlane;
    
    // StructProperty /Script/CoreUObject.Matrix:YPlane
    public UnrealSharp.CoreUObject.Plane YPlane;
    
    // StructProperty /Script/CoreUObject.Matrix:ZPlane
    public UnrealSharp.CoreUObject.Plane ZPlane;
    
    // StructProperty /Script/CoreUObject.Matrix:WPlane
    public UnrealSharp.CoreUObject.Plane WPlane;
    
}