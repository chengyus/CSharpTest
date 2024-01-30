using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct(IsBlittable = true)]
public partial struct NamedColor
{
    // StructProperty /Script/Engine.NamedColor:Value
    public UnrealSharp.CoreUObject.Color Value;
    
    // NameProperty /Script/Engine.NamedColor:Name
    public Name Name;
    
}