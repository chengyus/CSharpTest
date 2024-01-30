using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct(IsBlittable = true)]
public partial struct RigComputedTransform
{
    // StructProperty /Script/ControlRig.RigComputedTransform:Transform
    public UnrealSharp.Transform Transform;
    
}