using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.CoreUObject;

[UStruct(IsBlittable = true)]
public partial struct IntVector4
{
    // IntProperty /Script/CoreUObject.IntVector4:X
    public int X;
    
    // IntProperty /Script/CoreUObject.IntVector4:Y
    public int Y;
    
    // IntProperty /Script/CoreUObject.IntVector4:Z
    public int Z;
    
    // IntProperty /Script/CoreUObject.IntVector4:W
    public int W;
    
}