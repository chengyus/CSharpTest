using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct(IsBlittable = true)]
public partial struct NamedFloat
{
    // FloatProperty /Script/Engine.NamedFloat:Value
    public float Value;
    
    // NameProperty /Script/Engine.NamedFloat:Name
    public Name Name;
    
}