using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct(IsBlittable = true)]
public partial struct VectorAnimationAttribute
{
    // StructProperty /Script/Engine.VectorAnimationAttribute:Value
    public System.DoubleNumerics.Vector3 Value;
    
}