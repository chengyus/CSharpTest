using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.CoreUObject;

[UStruct(IsBlittable = true)]
public partial struct LinearColor
{
    // FloatProperty /Script/CoreUObject.LinearColor:R
    public float R;
    
    // FloatProperty /Script/CoreUObject.LinearColor:G
    public float G;
    
    // FloatProperty /Script/CoreUObject.LinearColor:B
    public float B;
    
    // FloatProperty /Script/CoreUObject.LinearColor:A
    public float A;
    
}