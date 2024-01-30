using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.CoreUObject;

[UStruct(IsBlittable = true)]
public partial struct FloatInterval
{
    // FloatProperty /Script/CoreUObject.FloatInterval:Min
    public float Min;
    
    // FloatProperty /Script/CoreUObject.FloatInterval:Max
    public float Max;
    
}