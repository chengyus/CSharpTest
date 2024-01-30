using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.CoreUObject;

[UStruct(IsBlittable = true)]
public partial struct Vector4
{
    // DoubleProperty /Script/CoreUObject.Vector4:X
    public double X;
    
    // DoubleProperty /Script/CoreUObject.Vector4:Y
    public double Y;
    
    // DoubleProperty /Script/CoreUObject.Vector4:Z
    public double Z;
    
    // DoubleProperty /Script/CoreUObject.Vector4:W
    public double W;
    
}