using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.CoreUObject;

[UStruct(IsBlittable = true)]
public partial struct IntVector
{
    // IntProperty /Script/CoreUObject.IntVector:X
    public int X;
    
    // IntProperty /Script/CoreUObject.IntVector:Y
    public int Y;
    
    // IntProperty /Script/CoreUObject.IntVector:Z
    public int Z;
    
}