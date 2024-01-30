using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.MeshDescription;

[UStruct(IsBlittable = true)]
public partial struct ElementID
{
    // IntProperty /Script/MeshDescription.ElementID:IDValue
    public int IDValue;
    
}