using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct(IsBlittable = true)]
public partial struct DisplacementScaling
{
    // FloatProperty /Script/Engine.DisplacementScaling:Magnitude
    public float Magnitude;
    
    // FloatProperty /Script/Engine.DisplacementScaling:Center
    public float Center;
    
}