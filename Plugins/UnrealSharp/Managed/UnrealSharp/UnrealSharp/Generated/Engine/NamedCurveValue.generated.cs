using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct(IsBlittable = true)]
public partial struct NamedCurveValue
{
    // NameProperty /Script/Engine.NamedCurveValue:Name
    public Name Name;
    
    // FloatProperty /Script/Engine.NamedCurveValue:Value
    public float Value;
    
}