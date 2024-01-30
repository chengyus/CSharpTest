using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.CoreUObject;

[UStruct(IsBlittable = true)]
public partial struct TwoVectors
{
    // StructProperty /Script/CoreUObject.TwoVectors:v1
    public System.DoubleNumerics.Vector3 v1;
    
    // StructProperty /Script/CoreUObject.TwoVectors:v2
    public System.DoubleNumerics.Vector3 v2;
    
}