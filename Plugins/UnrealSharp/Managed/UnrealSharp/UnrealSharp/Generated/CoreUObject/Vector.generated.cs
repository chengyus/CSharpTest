using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.CoreUObject;

[UStruct(IsBlittable = true)]
public partial struct Vector
{
    // DoubleProperty /Script/CoreUObject.Vector:X
    public double X;
    
    // DoubleProperty /Script/CoreUObject.Vector:Y
    public double Y;
    
    // DoubleProperty /Script/CoreUObject.Vector:Z
    public double Z;
    
}