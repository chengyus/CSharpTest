using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.CoreUObject;

[UStruct(IsBlittable = true)]
public partial struct Quat
{
    // DoubleProperty /Script/CoreUObject.Quat:X
    public double X;
    
    // DoubleProperty /Script/CoreUObject.Quat:Y
    public double Y;
    
    // DoubleProperty /Script/CoreUObject.Quat:Z
    public double Z;
    
    // DoubleProperty /Script/CoreUObject.Quat:W
    public double W;
    
}