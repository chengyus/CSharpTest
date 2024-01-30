using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.CoreUObject;

[UStruct(IsBlittable = true)]
public partial struct Rotator
{
    // DoubleProperty /Script/CoreUObject.Rotator:Pitch
    public double Pitch;
    
    // DoubleProperty /Script/CoreUObject.Rotator:Yaw
    public double Yaw;
    
    // DoubleProperty /Script/CoreUObject.Rotator:Roll
    public double Roll;
    
}