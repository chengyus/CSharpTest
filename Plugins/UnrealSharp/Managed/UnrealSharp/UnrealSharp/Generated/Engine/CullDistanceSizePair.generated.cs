using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct(IsBlittable = true)]
public partial struct CullDistanceSizePair
{
    // FloatProperty /Script/Engine.CullDistanceSizePair:Size
    public float Size;
    
    // FloatProperty /Script/Engine.CullDistanceSizePair:CullDistance
    public float CullDistance;
    
}