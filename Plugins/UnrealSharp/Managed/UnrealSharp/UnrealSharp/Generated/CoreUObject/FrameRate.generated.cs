using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.CoreUObject;

[UStruct(IsBlittable = true)]
public partial struct FrameRate
{
    // IntProperty /Script/CoreUObject.FrameRate:Numerator
    public int Numerator;
    
    // IntProperty /Script/CoreUObject.FrameRate:Denominator
    public int Denominator;
    
}