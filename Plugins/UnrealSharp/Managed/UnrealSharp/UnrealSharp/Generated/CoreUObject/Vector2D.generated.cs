using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.CoreUObject;

[UStruct(IsBlittable = true)]
public partial struct Vector2D
{
    // DoubleProperty /Script/CoreUObject.Vector2D:X
    public double X;
    
    // DoubleProperty /Script/CoreUObject.Vector2D:Y
    public double Y;
    
}