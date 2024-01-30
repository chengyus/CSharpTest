using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Slate;

[UStruct(IsBlittable = true)]
public partial struct Anchors
{
    // StructProperty /Script/Slate.Anchors:Minimum
    public System.DoubleNumerics.Vector2 Minimum;
    
    // StructProperty /Script/Slate.Anchors:Maximum
    public System.DoubleNumerics.Vector2 Maximum;
    
}