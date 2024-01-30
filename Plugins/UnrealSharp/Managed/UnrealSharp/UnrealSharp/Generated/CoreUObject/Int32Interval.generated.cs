using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.CoreUObject;

[UStruct(IsBlittable = true)]
public partial struct Int32Interval
{
    // IntProperty /Script/CoreUObject.Int32Interval:Min
    public int Min;
    
    // IntProperty /Script/CoreUObject.Int32Interval:Max
    public int Max;
    
}