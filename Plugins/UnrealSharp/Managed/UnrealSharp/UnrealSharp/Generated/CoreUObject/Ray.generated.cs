using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.CoreUObject;

[UStruct(IsBlittable = true)]
public partial struct Ray
{
    // StructProperty /Script/CoreUObject.Ray:Origin
    public System.DoubleNumerics.Vector3 Origin;
    
    // StructProperty /Script/CoreUObject.Ray:Direction
    public System.DoubleNumerics.Vector3 Direction;
    
}