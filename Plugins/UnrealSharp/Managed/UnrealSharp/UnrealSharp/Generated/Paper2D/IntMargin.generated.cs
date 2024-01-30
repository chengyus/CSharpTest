using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Paper2D;

[UStruct(IsBlittable = true)]
public partial struct IntMargin
{
    // IntProperty /Script/Paper2D.IntMargin:Left
    public int Left;
    
    // IntProperty /Script/Paper2D.IntMargin:Top
    public int Top;
    
    // IntProperty /Script/Paper2D.IntMargin:Right
    public int Right;
    
    // IntProperty /Script/Paper2D.IntMargin:Bottom
    public int Bottom;
    
}