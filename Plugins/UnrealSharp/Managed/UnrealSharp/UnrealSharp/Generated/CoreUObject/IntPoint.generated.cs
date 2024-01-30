using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.CoreUObject;

[UStruct(IsBlittable = true)]
public partial struct IntPoint
{
    // IntProperty /Script/CoreUObject.IntPoint:X
    public int X;
    
    // IntProperty /Script/CoreUObject.IntPoint:Y
    public int Y;
    
}