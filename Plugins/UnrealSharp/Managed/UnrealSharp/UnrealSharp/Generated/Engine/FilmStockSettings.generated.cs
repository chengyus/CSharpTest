using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct(IsBlittable = true)]
public partial struct FilmStockSettings
{
    // FloatProperty /Script/Engine.FilmStockSettings:Slope
    public float Slope;
    
    // FloatProperty /Script/Engine.FilmStockSettings:Toe
    public float Toe;
    
    // FloatProperty /Script/Engine.FilmStockSettings:Shoulder
    public float Shoulder;
    
    // FloatProperty /Script/Engine.FilmStockSettings:BlackClip
    public float BlackClip;
    
    // FloatProperty /Script/Engine.FilmStockSettings:WhiteClip
    public float WhiteClip;
    
}