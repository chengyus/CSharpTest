using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.SlateCore;

[UStruct(IsBlittable = true)]
public partial struct Margin
{
    // FloatProperty /Script/SlateCore.Margin:Left
    public float Left;
    
    // FloatProperty /Script/SlateCore.Margin:Top
    public float Top;
    
    // FloatProperty /Script/SlateCore.Margin:Right
    public float Right;
    
    // FloatProperty /Script/SlateCore.Margin:Bottom
    public float Bottom;
    
}